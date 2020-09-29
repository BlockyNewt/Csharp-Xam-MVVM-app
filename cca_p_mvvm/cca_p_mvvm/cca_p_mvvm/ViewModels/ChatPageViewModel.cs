using Android.Views.Animations;
using Google.Protobuf.WellKnownTypes;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace cca_p_mvvm.ViewModels
{
    public class ChatPageViewModel : ViewModelBase, INavigationAware
    {
        public ChatPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.user_ = new UserViewModel();

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.messages_List_ = new ObservableCollection<Message>();
        }

        private readonly INavigationService navigation_Service_;

        private　LanguageEnglish l_Eng_ { get; set; }
        private　LanguageJapanese l_Jap_ { get; set; }
        private UserViewModel user_ { get; set; }

        private IList<Message> messages_List_;

        private string message_Text_Changed_;
        private string chat_Frame_Label_;
        private string chat_Message_Editor_Placeholder_;
        private string chat_Send_Button_;


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
            //DON'T KNOW IF WE ARE GOING TO WANT TO PASS BACK PARAMETER YET 

            await this.navigation_Service_.GoBackAsync();
        }

        private DelegateCommand send_Button_Command_;
        public DelegateCommand Send_Button_Command_ => this.send_Button_Command_ ?? (this.send_Button_Command_ = new DelegateCommand(this.SendButton));
        private void SendButton()
        {
            if(this.Message_Text_Changed_.Length > 0)
            {
                Message message = new Message();
                message.Sender_Name_ = this.user_.First_Name_;
                message.Message_ = this.Message_Text_Changed_;

                this.Messages_List_.Add(message);

                this.Message_Text_Changed_ = string.Empty;
            }
            else
            {
                Console.WriteLine("Message lenth is too short.");
            }
        }





        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if(parameters.Count() > 0)
            {
                this.user_ = parameters.GetValue<UserViewModel>("user_");

                this.l_Eng_ = parameters.GetValue<LanguageEnglish>("l_Eng_");
                this.l_Jap_ = parameters.GetValue<LanguageJapanese>("l_Jap_");

                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.Chat_Frame_Label_ = parameters.GetValue<string>("frame_Label_");

                this.SetLanguage();
            }
        }



        private void SetLanguage()
        {
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
