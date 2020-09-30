using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Xamarin.Forms;
using Xamarin.Essentials;
using Android.Content.PM;

namespace cca_p_mvvm
{
    class ClientConnection
    {
        private NetworkStream stream_;
        private Int32 port_;
        private IPAddress local_Address_;
        private TcpClient client_;

        public async void Connect(string server, Int32 port, string firstname)
        {
            //SET THE LOCAL IP AND PORT 
            this.local_Address_ = IPAddress.Parse(server);
            this.port_ = port;

            string connectedMsg = firstname + " has connected.";

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
                await Application.Current.MainPage.DisplayAlert("Socket Error", "Could not connect", "Close");
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
                Byte[] data = new byte[256];

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
