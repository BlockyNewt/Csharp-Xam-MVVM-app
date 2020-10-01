using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Xamarin.Forms;
using Xamarin.Essentials;
using Android.Content.PM;
using Google.Protobuf.WellKnownTypes;

namespace cca_p_mvvm
{
    public class ClientConnection
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
                this.port_ = value;
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
                this.local_Address_ = value;
            }
        }


        public async void Connect(string server, Int32 port)
        {
            //SET THE LOCAL IP AND PORT 
            this.local_Address_ = IPAddress.Parse(server);
            this.port_ = port;

            string connectedMsg = this.local_Address_ + " has connected.";

            try
            {
                //START THE CONNECTION
                this.client_ = new TcpClient(this.local_Address_.ToString(), this.port_);

                if (this.CheckConnection())
                {
                    //GET A CLIENT STREAM FOR READING AND WRITING 
                    this.stream_ = this.client_.GetStream();

                    //TRANSLATE THE MESSGE INTO ACII AND THEN STORE IT INTO A BYTE ARRAY
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(connectedMsg);

                    //SEND THE MESSAGE
                    this.stream_.Write(data, 0, data.Length);

                    
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Could not connect to the server.", "Close");
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
                await Application.Current.MainPage.DisplayAlert("Socket Error", "Could not connect", "Close");
            }
        }

        public string LoginMessage(string typedUsername)
        {
            string newMessage = "USERNAME;" + typedUsername;

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

        public string[] GetUser(string typedPassword)
        {
            string newMessage = "PASSWORD;" + typedPassword;

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
            string msg = "CHANNELS;";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            try
            {
                if (this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string allChannels = this.ReceiveMessage();

                    string[] splitAllChannels = allChannels.Split(';');

                    for(int i = 0; i < splitAllChannels.Length; ++i)
                    {
                        Console.WriteLine("Channel Name: " + splitAllChannels[i] + "\n");
                    }

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
            string msg = "USERS;";

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

            try
            {
                if(this.CheckConnection())
                {
                    this.stream_.Write(data, 0, data.Length);

                    string allUsers = this.ReceiveMessage();

                    string[] splitAllUsers = allUsers.Split(';');

                    for(int i = 0; i < splitAllUsers.Length; ++i)
                    {
                        Console.WriteLine("USER: " + splitAllUsers[i] + "\n");
                    }

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

        public void EditUser(int id, string firstName, string lastName, string picture)
        {
            string msg = "EDIT;" + Convert.ToString(id) + ";" + firstName + ";" + lastName + ";" + picture;

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);

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
            string newMessage = firstname + ": " + message;

            //TRANSLATE THE MESSGE INTO ACII AND THEN STORE IT INTO A BYTE ARRAY
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(newMessage);

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
                responseMessage = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                return responseMessage;
            }
            else
            {
                return string.Empty;
            }
        }

        public bool CheckConnection()
        {
            //IM PROBABLY WRONG ON CHECKING THE CONNECTION SINCE IT GIVES AN ERROR EVERY TIME

            //CHECK IF WE ARE CONNECTED
            if (this.client_.Connected)
            {
                Console.WriteLine("#### STILL CONNECTED ####");

                return true;
            }
            else
            {
                //IF NOT CLOSE ALL CONNECTIONS
                this.stream_.Close();
                this.client_.Close();

                return false;
            }
        }

        public void CloseAllConnections()
        {
            //CLOSE ALL CONNECTIONS
            this.stream_.Close();
            this.client_.Close();
        }
    }
}
