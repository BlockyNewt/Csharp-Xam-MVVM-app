using Android.Views.Animations;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Net;
using System.Net.Sockets;
using Xamarin.Forms;

namespace cca_p_mvvm.ViewModels
{
    public class ChatPageViewModel : ViewModelBase, INavigationAware
    {
        public ChatPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.user_ = new UserViewModel();
            this.target_User_ = new UserViewModel();

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.messages_List_ = new ObservableCollection<Message>();

            this.client_Connection_ = new ClientConnection();

            this.channel_Or_Direct_Message = false;
        }
        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //LANGUAGES
        private　LanguageEnglish l_Eng_ { get; set; }
        private　LanguageJapanese l_Jap_ { get; set; }
        
        //CURRENTLY LOGGED INTO THE CLIENT USER
        private UserViewModel user_ { get; set; }

        //TARGET CLIENT (IF WE ARE DIRECTLY MESSAGING)
        private UserViewModel target_User_ { get; set; }   
        
        //CLIENT CONNECTION
        private ClientConnection client_Connection_ { get; set; }

        //CURRENT CHANNEL (IF WE ARE ENTERING A CHANNEL)
        private Channel channel_ { get; set; }  

        private IList<Message> messages_List_;

        private string message_Text_Changed_;
        private string chat_Frame_Label_;
        private string chat_Message_Editor_Placeholder_;
        private string chat_Send_Button_;
        private bool channel_Or_Direct_Message;


        public IList<Message> Messages_List_
        {
            get
            {
                return this.messages_List_;
            }
        }

        public string Message_Text_Changed_
        {
            get
            {
                return this.message_Text_Changed_;
            }

            set
            {
                this.message_Text_Changed_ = value;
                this.OnPropertyChanged("Message_Text_Changed_");
                this.SetProperty(ref this.message_Text_Changed_, value);
            }
        }

        public string Chat_Frame_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.chat_Frame_Label_))
                {
                    return "Empty string";
                }

                return this.chat_Frame_Label_;
            }

            set
            {
                this.chat_Frame_Label_ = value;
                this.OnPropertyChanged("Chat_Frame_Label_");
                this.SetProperty(ref this.chat_Frame_Label_, value);
            }
        }

        public string Chat_Message_Editor_Placeholder_
        {
            get
            {
                if (string.IsNullOrEmpty(this.chat_Message_Editor_Placeholder_))
                {
                    return "Empty string";
                }

                return this.chat_Message_Editor_Placeholder_;
            }

            set
            {
                this.chat_Message_Editor_Placeholder_ = value;
                this.OnPropertyChanged("Chat_Message_Editor_Placeholder_");
                this.SetProperty(ref this.chat_Message_Editor_Placeholder_, value);
            }
        }

        public string Chat_Send_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.chat_Send_Button_))
                {
                    return "Empty string";
                }

                return this.chat_Send_Button_;
            }

            set
            {
                this.chat_Send_Button_ = value;
                this.OnPropertyChanged("Chat_Send_Button_");
                this.SetProperty(ref this.chat_Send_Button_, value);
            }
        }


        private DelegateCommand back_Button_Command_;
        public DelegateCommand Back_Button_Command_ => this.back_Button_Command_ ?? (this.back_Button_Command_ = new DelegateCommand(this.GoBack));
        private async void GoBack()
        {
            //GO BACK TO PREVIOUS PAGE
            await this.navigation_Service_.GoBackAsync();
        }

        private DelegateCommand send_Button_Command_;
        public DelegateCommand Send_Button_Command_ => this.send_Button_Command_ ?? (this.send_Button_Command_ = new DelegateCommand(this.SendButton));
        private void SendButton()
        {
            //IF THE MESSAGE TEXT FIELD IS NOT NULL OR EMPTY
            if(this.Message_Text_Changed_.Length > 0)
            {
                //CREATE NEW MESSAGE
                Message message = new Message();
                message.Sender_Name_ = this.user_.First_Name_;
                message.Message_ = this.Message_Text_Changed_;

                //ADD MESSAGE TO THE LIST
                this.Messages_List_.Add(message);

                //CHECK IF WE ARE CURRENTLY TALKING WITHIN A CHANNEL OR A TALKING DIRECTLY TO ANOTHER USER (CLIENT)
                if(!this.channel_Or_Direct_Message)
                {
                    this.client_Connection_.SendChannelMessage(this.channel_.ID_, this.user_.First_Name_, this.Message_Text_Changed_);
                }
                else
                {
                    this.client_Connection_.SendDirectMessage(this.user_.ID_, this.user_.First_Name_, this.target_User_.ID_, this.Message_Text_Changed_);
                }

                //RESET MESSAGE TEXT FIELD
                this.Message_Text_Changed_ = string.Empty;
            }
        }





        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //CHECK IF WE ARE TALKING TO A CHANNEL
            if(parameters.ContainsKey("channel_"))
            {
                this.user_ = parameters.GetValue<UserViewModel>("user_");
                this.user_.ID_ = parameters.GetValue<UserViewModel>("user_").ID_;
                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;

                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.client_Connection_ = parameters.GetValue<ClientConnection>("client_Connection_");
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;
                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;

                this.channel_ = parameters.GetValue<Channel>("channel_");
                this.channel_.Name_ = parameters.GetValue<Channel>("channel_").Name_;
                this.channel_.ID_ = parameters.GetValue<Channel>("channel_").ID_;

                this.Chat_Frame_Label_ = this.channel_.Name_;

                this.SetLanguage();

                this.GetMessages(false);
            }
            //CHECK IF WE ARE TALKING DIRECTLY TO ANOTHER USER (CLIENT)
            else if(parameters.ContainsKey("target_User_"))
            {
                this.user_ = parameters.GetValue<UserViewModel>("user_");
                this.user_.ID_ = parameters.GetValue<UserViewModel>("user_").ID_;
                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;

                this.l_Eng_ = parameters.GetValue<LanguageEnglish>("l_Eng_");
                this.l_Jap_ = parameters.GetValue<LanguageJapanese>("l_Jap_");

                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.client_Connection_ = parameters.GetValue<ClientConnection>("client_Connection_");
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;
                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;

                this.target_User_ = parameters.GetValue<UserViewModel>("target_User_");
                this.target_User_.ID_ = parameters.GetValue<UserViewModel>("target_User_").ID_;
                this.target_User_.First_Name_ = parameters.GetValue<UserViewModel>("target_User_").First_Name_;
                this.target_User_.Last_Name_ = parameters.GetValue<UserViewModel>("target_User_").Last_Name_;

                this.Chat_Frame_Label_ = this.target_User_.First_Name_;

                this.SetLanguage();

                this.GetMessages(true);
            }
        }


        private void GetMessages(bool channelOrDirectMessage)
        {
            //CHECK IF WE ARE CONNECTED
            if (this.client_Connection_.CheckConnection())
            {
                //CREATE A STRING TO MESSAGES
                string[] allMessages = null;

                //IF WE ARE WITHIN A CHANNEL 
                if (!channelOrDirectMessage)
                {
                    allMessages = this.client_Connection_.GetChannelMessages(this.channel_.ID_);

                    this.channel_Or_Direct_Message = false;
                }
                //IF WE ARE DIRECTLY TALKING TO ANOTHER USER (CLIENT)
                else
                {
                    allMessages = this.client_Connection_.GetDirectMessages(this.user_.ID_, this.target_User_.ID_);

                    this.channel_Or_Direct_Message = true;
                }

                //AS LONG AS THE STRING ARRAY IS NOT NULL
                if (allMessages != null)
                {
                    for (int i = 0; i < allMessages.Length; ++i)
                    {
                        //SPLIT AGAIN TO MAKE MESSAGE
                        string seperatingMessages = allMessages[i];
                        string[] getMessageInfo = seperatingMessages.Split(',');

                        //CREATE A NEW MESSAGE
                        Message message = new Message();
                        message.Sender_Name_ = getMessageInfo[0];
                        message.Message_ = getMessageInfo[1];

                        //ADD INTO LIST 
                        this.Messages_List_.Add(message);
                    }
                }
            }
        }

        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON CURRENTLY ACTIVE
            if(this.l_Eng_.Is_English_Selected_)
            {
                this.Chat_Message_Editor_Placeholder_ = this.l_Eng_.Word[ENG_WORD.CHAT_EDITOR_PLACEHOLDER];
                this.Chat_Send_Button_ = this.l_Eng_.Word[ENG_WORD.CHAT_SEND_BUTTON];
            }
            else if(this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Chat_Message_Editor_Placeholder_ = this.l_Jap_.Word[JAP_WORD.CHAT_EDITOR_PLACEHOLDER];
                this.Chat_Send_Button_ = this.l_Jap_.Word[JAP_WORD.CHAT_SEND_BUTTON];
            }
        }
    }
}
