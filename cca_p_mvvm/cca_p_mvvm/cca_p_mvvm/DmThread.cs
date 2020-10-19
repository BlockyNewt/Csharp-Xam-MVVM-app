using Android.OS;
using cca_p_mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cca_p_mvvm
{
    public class DmThread
    {
        public DmThread(ref IList<ViewModels.Message> messageList, ClientConnection clientConnection)
        {
            Thread dm = new Thread(nothing);
        }

        private void StartChat(ref IList<ViewModels.Message> messageList, ClientConnection clientConnection)
        {
            ViewModels.Message msg = new ViewModels.Message();

            while (true)
            {
                if (clientConnection.ReceiveMessage() != string.Empty)
                {
                    msg.Sender_Name_ = "Tommy";
                    msg.Message_ = clientConnection.ReceiveMessage();
                    messageList.Add(msg);
                }
            }
        }

        private void nothing()
        {

        }


    }
}
