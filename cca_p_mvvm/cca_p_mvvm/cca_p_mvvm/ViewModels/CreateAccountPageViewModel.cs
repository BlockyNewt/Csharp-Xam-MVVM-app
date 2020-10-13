using Android.Icu.Util;
using Android.Speech.Tts;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace cca_p_mvvm.ViewModels
{
    public class CreateAccountPageViewModel : ViewModelBase, INavigationAware
    {
        public CreateAccountPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.client_Connection_ = new ClientConnection();

            this.color_Scheme_ = new ColorScheme();
        }
        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }

        //CONNECTION TO THE SERVER
        public ClientConnection client_Connection_ { get; private set; }

        //COLOR-SCHEMES
        public ColorScheme color_Scheme_ { get; private set; }

        private string first_Name_Label_Text_;
        private string first_Name_Text_Changed_;
        private string first_Name_Placeholder_Text_;
        private string last_Name_Label_Text_;
        private string last_Name_Text_Changed_;
        private string last_Name_Placeholder_Text_;
        private string username_Label_Text_;
        private string username_Placeholder_Text_;
        private string username_Text_Changed_;
        private string password_Label_Text_;
        private string password_Text_Changed_;
        private string password_Placeholder_Text_;
        private string password_Confirm_Text_Changed_;
        private string profile_Picture_Label_Text_;
        private string profile_Picture_Placeholder_Text_;
        private string profile_Picture_Text_Changed_;

        private string clear_Button_;
        private string confirm_Button_;
        private string cancel_Button_;

        private string error_Title_;
        private string error_Message_;
        private string error_Button_;

        public string First_Name_Label_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.first_Name_Label_Text_))
                {
                    return "Empty";
                }

                return this.first_Name_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.first_Name_Label_Text_, value);
                this.RaisePropertyChanged("First_Name_Label_Text_");
            }
        }

        public string First_Name_Text_Changed_
        {
            get
            {
                return this.first_Name_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.first_Name_Text_Changed_, value);
                this.RaisePropertyChanged("First_Name_Text_Changed_");
            }
        }

        public string First_Name_Placeholder_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.first_Name_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.first_Name_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.first_Name_Placeholder_Text_, value);
                this.RaisePropertyChanged("First_Name_Placeholder_Text_");
            }
        }

        public string Last_Name_Label_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.last_Name_Label_Text_))
                {
                    return "Empty";
                }

                return this.last_Name_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.last_Name_Label_Text_, value);
                this.RaisePropertyChanged("Last_Name_Label_Text_");
            }
        }

        public string Last_Name_Text_Changed_
        {
            get
            {
                return last_Name_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.last_Name_Text_Changed_, value);
                this.RaisePropertyChanged("Last_Name_Text_Changed_");
            }
        }

        public string Last_Name_Placeholder_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.last_Name_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.last_Name_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.last_Name_Placeholder_Text_, value);
                this.RaisePropertyChanged("Last_Name_Placeholder_Text_");
            }
        }

        public string Username_Label_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.username_Label_Text_))
                {
                    return "Empty";
                }

                return this.username_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.username_Label_Text_, value);
                this.RaisePropertyChanged("Username_Label_Text_");
            }
        }

        public string Username_Placeholder_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.username_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.username_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.username_Placeholder_Text_, value);
                this.RaisePropertyChanged("Username_Placeholder_Text_");
            }
        }

        public string Username_Text_Changed_
        {
            get
            {
                return this.username_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.username_Text_Changed_, value);
                this.RaisePropertyChanged("Username_Text_Changed_");
            }
        }

        public string Password_Label_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.password_Label_Text_))
                {
                    return "Empty";
                }

                return this.password_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.password_Label_Text_, value);
                this.RaisePropertyChanged("Password_Label_Text_");
            }
        }

        public string Password_Text_Changed_
        {
            get
            {
                return this.password_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.password_Text_Changed_, value);
                this.RaisePropertyChanged("Password_Text_Changed_");
            }
        }

        public string Password_Confirm_Text_Changed_
        {
            get
            {
                return this.password_Confirm_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.password_Confirm_Text_Changed_, value);
                this.RaisePropertyChanged("Password_Confirm_Text_Changed_");
            }
        }

        public string Password_Placeholder_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.password_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.password_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.password_Placeholder_Text_, value);
                this.RaisePropertyChanged("Password_Placeholder_Text_");
            }
        }

        public string Profile_Picture_Label_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(profile_Picture_Label_Text_))
                {
                    return "Empty";
                }

                return this.profile_Picture_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.profile_Picture_Label_Text_, value);
                this.RaisePropertyChanged("Profile_Picture_Label_Text_");
            }
        }

        public string Profile_Picture_Placeholder_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.profile_Picture_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.profile_Picture_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.profile_Picture_Placeholder_Text_, value);
                this.RaisePropertyChanged("Profile_Picture_Placeholder_Text_");
            }
        }
        
        public string Profile_Picture_Text_Changed_
        {
            get
            {
                return this.profile_Picture_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.profile_Picture_Text_Changed_, value);
                this.RaisePropertyChanged("Profile_Picture_Text_Changed_");
            }
        }

        public string Clear_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.clear_Button_))
                {
                    return "Empty";
                }

                return this.clear_Button_;
            }

            set
            {
                this.SetProperty(ref this.clear_Button_, value);
                this.RaisePropertyChanged("Clear_Button_");
            }
        }

        public string Confirm_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.confirm_Button_))
                {
                    return "Empty";
                }

                return this.confirm_Button_;
            }

            set
            {
                this.SetProperty(ref this.confirm_Button_, value);
                this.RaisePropertyChanged("Confirm_Button_");
            }
        }

        public string Error_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Title_))
                {
                    return "Empty";
                }

                return this.error_Title_;
            }

            set
            {
                this.SetProperty(ref this.error_Title_, value);
                this.RaisePropertyChanged("Error_Title_");
            }
        }

        public string Error_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Message_))
                {
                    return "Empty";
                }

                return this.error_Message_;
            }

            set
            {
                this.SetProperty(ref this.error_Message_, value);
                this.RaisePropertyChanged("Error_Messsage_");
            }
        }

        public string Error_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.Error_Button_))
                {
                    return "Empty";
                }

                return this.error_Button_;
            }

            set
            {
                this.SetProperty(ref this.error_Button_, value);
                this.RaisePropertyChanged("Error_Button_");
            }
        }

        public string Cancel_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.cancel_Button_))
                {
                    return "Empty";
                }

                return cancel_Button_;
            }

            set
            {
                this.SetProperty(ref this.cancel_Button_, value);
                this.RaisePropertyChanged("Cancel_Button_");
            }
        }



        private DelegateCommand clear_Button_Command_;
        public DelegateCommand Clear_Button_Command_ => this.clear_Button_Command_ ?? (this.clear_Button_Command_ = new DelegateCommand(this.ClearButton));
        private void ClearButton()
        {
            //CLEAR ALL TEXT FIELDS
            this.First_Name_Text_Changed_ = string.Empty;
            this.Last_Name_Text_Changed_ = string.Empty;
            this.Username_Text_Changed_ = string.Empty;
            this.Password_Text_Changed_ = string.Empty;
            this.Password_Confirm_Text_Changed_ = string.Empty;
            this.Profile_Picture_Text_Changed_ = string.Empty;
        }

        private DelegateCommand confirm_Button_Command_;
        public DelegateCommand Confirm_Button_Command_ => this.confirm_Button_Command_ ?? (this.confirm_Button_Command_ = new DelegateCommand(this.ConfirmButton));
        private async void ConfirmButton()
        {
            Console.WriteLine("A");
            //CREATE USER AND PUSH BACK 
            if(this.Password_Confirm_Text_Changed_ == this.Password_Text_Changed_)
            {
                this.client_Connection_.Connect("192.168.12.7", 45000);

                Console.WriteLine("DETAILS: " + " firstname: " + this.First_Name_Text_Changed_ + " lastname: " + this.Last_Name_Text_Changed_ + " username: " + this.Username_Text_Changed_ + " password:" + this.Password_Text_Changed_ + " profile picture:" + this.Profile_Picture_Text_Changed_);

                //SEND THROUGH CLIENT
                this.client_Connection_.CreateAccount(this.First_Name_Text_Changed_, this.Last_Name_Text_Changed_, this.Username_Text_Changed_, this.Password_Confirm_Text_Changed_, this.Profile_Picture_Text_Changed_);

                this.client_Connection_.CloseAllConnections();

                await this.navigation_Service_.GoBackAsync();
            }
            else
            {
                Console.WriteLine("B");

                this.Password_Text_Changed_ = string.Empty;
                this.Password_Confirm_Text_Changed_ = string.Empty;

                await Application.Current.MainPage.DisplayAlert(this.error_Title_, this.error_Message_, this.error_Button_);
            }
        }

        private DelegateCommand cancel_Button_Command_;
        public DelegateCommand Cancel_Button_Command_ => this.cancel_Button_Command_ ?? (this.cancel_Button_Command_ = new DelegateCommand(this.CancelButton));
        private async void CancelButton()
        {
            //CLEAR ALL FIELDS AND PUSH BACK 
            ClearButton();

            await this.navigation_Service_.GoBackAsync();
        }



        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
            this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

            this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;
            this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;

            this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
            this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;

            this.SetLanguage();
            this.color_Scheme_.SetColors();
        }


        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON WHICH ONE IS TRUE
            if (this.l_Eng_.Is_English_Selected_)
            {
                this.First_Name_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL];  
                this.First_Name_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER];  
                this.Last_Name_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL];
                this.Last_Name_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER];
                this.Username_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_LABEL];
                this.Username_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER];
                this.Password_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_LABEL];
                this.Password_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER];
                this.Profile_Picture_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_LABEL];
                this.Profile_Picture_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER];
                this.Clear_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_CLEAR_BUTTON];
                this.Confirm_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON];
                this.Cancel_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_CANCEL_BUTTON];
                this.Error_Title_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_ERROR_TITLE];
                this.Error_Message_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_ERROR_MESSAGE];
                this.Error_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_ERROR_BUTTON];

            }
            else if (this.l_Jap_.Is_Japanese_Selected_)
            {
                this.First_Name_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL];
                this.First_Name_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER];
                this.Last_Name_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL];
                this.Last_Name_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER];
                this.Username_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_LABEL];
                this.Username_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER];
                this.Password_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_LABEL];
                this.Password_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER];
                this.Profile_Picture_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_LABEL];
                this.Profile_Picture_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER];
                this.Clear_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_CLEAR_BUTTON];
                this.Confirm_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON];
                this.Cancel_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_CANCEL_BUTTON];
                this.Error_Title_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_ERROR_TITLE];
                this.Error_Message_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_ERROR_MESSAGE];
                this.Error_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_ERROR_BUTTON];
            }
        }

    }
}
