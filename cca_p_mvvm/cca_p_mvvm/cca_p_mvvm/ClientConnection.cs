using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Xamarin.Forms;
using Xamarin.Essentials;
using Android.Content.PM;
using System.IO;
using DryIoc;
using Prism.Mvvm;

namespace cca_p_mvvm
{
    public class ClientConnection : BindableBase
    {
        private NetworkStream stream_;
        private Int32 port_;
        private IPAddress local_Address_;
        private TcpClient client_;

        public Int32 Port_
        {
            get
            {
                return this.port_;
            }

            set
            {
                this.SetProperty(ref this.port_, value);
                this.RaisePropertyChanged("Port_");
            }
        }
        public IPAddress Local_Address_
        {
            get
            {
                return this.local_Address_;
            }

            set
            {
                this.SetProperty(ref this.local_Address_, value);
                this.RaisePropertyChanged("Local_Address_");
            }
        }


        public ClientConnection()
        {
            //SET THE LOCAL IP AND PORT 
            this.local_Address_ = IPAddress.Parse("192.168.12.7");
            this.port_ = 45000;
        }

        public bool Connect()
        {
            string connectedMsg = this.local_Address_ + " has connected." + "$";

            try
            {
                //START THE CONNECTION
                this.client_ = new TcpClient();

                if (this.client_.ConnectAsync(this.local_Address_.ToString(), this.port_).Wait(1000))
                {
                    if (this.CheckConnection())
                    {
                        //GET A CLIENT STREAM FOR READING AND WRITING 
                        this.stream_ = this.client_.GetStream();

                        //TRANSLATE THE MESSGE INTO ACII AND THEN STORE IT INTO A BYTE ARRAY
                        Byte[] data = System.Text.Encoding.ASCII.GetBytes(connectedMsg);

                        //SEND THE MESSAGE
                        this.stream_.Write(data, 0, data.Length);

                        this.ReceiveMessage();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());

                return false;
            }
        }

        public string LoginMessage(string typedUsername)
        {
            string newMessage = "USERNAME;" + typedUsername + "$";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(newMessage);

            if(this.CheckConnection())
            {
                this.stream_.Write(data, 0, data.Length);

                return this.ReceiveMessage();
            }
            else
            {
                return string.Empty;
            }
        }

        public void CreateAccount(string firstname, string lastname, string username, string password, string bio,  string profilePicture)
        {
            try
            {
                string msg = "CREATE_ACCOUNT;" + firstname + ";" + lastname + ";" + username + ";" + password + ";" + bio + ";" + profilePicture + "$";

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

                this.stream_.Write(data, 0, data.Length);
                this.stream_.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                this.CloseAllConnections();
            }
        }

        public string[] GetUser(string typedPassword)
        {
            string newMessage = "PASSWORD;" + typedPassword + "$";

            Console.WriteLine(typedPassword);

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(newMessage);

            try
            {
                if (this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string[] userInfo = this.ReceiveMessage().Split(';');

                    return userInfo;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        public string[] GetChannels()
        {
            string msg = "CHANNELS;" + "$";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            try
            {
                if (this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string allChannels = this.ReceiveMessage();

                    string[] splitAllChannels = allChannels.Split(';');

                    return splitAllChannels;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        public string[] GetAllUsers()
        {
            string msg = "USERS;" + "$";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            try
            {
                if(this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string allUsers = this.ReceiveMessage();

                    string[] splitAllUsers = allUsers.Split(';');

                    return splitAllUsers;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        public string[] GetChannelMessages(int channelID)
        {
            string msg = "GET_CHANNEL_MESSAGES;" + Convert.ToString(channelID) + "$";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            try
            {
                if(this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string allMessages = this.ReceiveMessage();

                    if(allMessages != string.Empty)
                    {
                        string[] splitAllMessages = allMessages.Split(';');
                     
                        return splitAllMessages;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        public string[] GetDirectMessages(int senderID, int receiverID)
        {
            string msg = "GET_DIRECT_MESSAGES;" + Convert.ToInt32(senderID) + ";" + Convert.ToInt32(receiverID) + "$";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            try
            {
                if (this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string allDirectMessages = this.ReceiveMessage();

                    if(allDirectMessages != "EMPTY")
                    {
                        string[] splitAllDirectMessages = allDirectMessages.Split(';');

                        return splitAllDirectMessages;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        public void EditUser(int id, string firstName, string lastName, string bio, string picture)
        {
            string msg = "EDIT;" + Convert.ToString(id) + ";" + firstName + ";" + lastName + ";" + bio + ";" + picture + "$";


            Console.Write("EDITING USER: " + msg);

            Byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);


            try
            {
                if(this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SendChannelMessage(int channelID, string userFirstname, string message)
        {
            string msg = "CHANNEL_MESSAGE;" + Convert.ToString(channelID) + ";" + userFirstname + ";" + message + "$";

            Byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);

            try
            {
                if(this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }

        public void SendDirectMessage(int senderID, string senderName, int receiverID, string message)
        {
            string msg = "DIRECT_MESSAGE;" + Convert.ToString(senderID) + ";" + senderName + ";" + Convert.ToString(receiverID) + ";" + message + "$";

            Byte[] data = System.Text.Encoding.UTF8.GetBytes(msg);
            
            try
            {
                if(this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public string SendMessage(string firstname, string message)
        {
            string newMessage = firstname + ": " + message + "$";

            //TRANSLATE THE MESSGE INTO ACII AND THEN STORE IT INTO A BYTE ARRAY
            Byte[] data = System.Text.Encoding.UTF8.GetBytes(newMessage);

            //CHECK IF WE HAVE A CONNECTION AT THE TIME OF SENDING
            if(this.CheckConnection())
            {
                //SEND IT INTO THE STREAM
                this.stream_.Write(data, 0, data.Length);
                return message;
            }
            else
            {
                return string.Empty;
            }
        }

        public string ReceiveMessage()
        {
            if(this.CheckConnection())
            {
                //MAKE A CONTAINER FOR THE DATA WE WILL BE GRABBING FROM THE SERVER
                Byte[] data = new byte[20000];

                string responseMessage = string.Empty;

                //SET THE DATA 
                Int32 bytes = this.stream_.Read(data, 0, data.Length);

                //RETURN IT SO WE CAN ADD IT INTO A LIST ON THE CHATPAGEVIEWMODEL
                responseMessage = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] unicode = utf8.GetBytes(responseMessage);
                string jack = utf8.GetString(unicode);
                Console.WriteLine("MOTHA fucking UTF8 BITCHES" + jack);


                Console.WriteLine("RESPONSE MESSAGE: " + responseMessage);

                if (responseMessage == "EMPTY")
                {
                    return "EMPTY";
                }
                else if (responseMessage == string.Empty)
                {
                    return "EMPTY";
                }
                else
                {
                    Console.WriteLine(responseMessage);

                    return responseMessage;
                }
            }
            else
            {
                return "EMPTY";
            }
        }

        public bool CheckConnection()
        {
            //CHECK IF WE ARE CONNECTED
            if (this.client_.Connected)
            {
                Console.WriteLine("CLIENT CONNECTED.");
                return true;
            }
            else
            {
                //IF NOT CLOSE ALL CONNECTIONS
                Console.WriteLine("CLIENT COULD NOT CONNECT.");

                this.CloseAllConnections();

                return false;
            }
        }

        public void CloseAllConnections()
        {
            //CLOSE ALL CONNECTIONS
            this.stream_.Flush();

            this.stream_.Dispose();
            this.stream_.Close();
            this.client_.Dispose();
            this.client_.Close();
        }
    }
}
