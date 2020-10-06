using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xamarin.Forms;

namespace cca_p_mvvm.ViewModels
{
    public class ProfileEditPageViewModel : ViewModelBase, INavigationAware
    {
        public ProfileEditPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.user_ = new UserViewModel();

            this.client_Connection_ = new ClientConnection();

            this.SetLanguage();
        }

        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //UI VARIABLES
        private string first_Name_Placeholder_;
        private string first_Name_Changed_Text_;
        private string last_Name_Placeholder_;
        private string last_Name_Changed_Text_;
        private string picture_Changed_Text_;
        private string picture_Placeholder_;
        private string confirm_Button_;
        private string cancel_Button_;
        private string alert_Title_;
        private string alert_Message_;
        private string alert_Button_;

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }

        //CURRENTLY LOGGED IN USER
        public UserViewModel user_ { get; private set; }

        //CLIENT CONNECTION
        public ClientConnection client_Connection_ { get; private set; }



        public string First_Name_Placeholder_
        {
            get
            {
                if (string.IsNullOrEmpty(this.first_Name_Placeholder_))
                {
                    return "Empty string";
                }

                return this.first_Name_Placeholder_;
            }

            set
            {
                this.first_Name_Placeholder_ = value;
                this.OnPropertyChanged("First_Name_Placeholder_");
                this.SetProperty(ref this.first_Name_Placeholder_, value);
            }
        }

        public string First_Name_Changed_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.first_Name_Changed_Text_))
                {
                    return string.Empty;
                }

                return this.first_Name_Changed_Text_;
            }

            set
            {
                this.first_Name_Changed_Text_ = value;
                this.OnPropertyChanged("First_Name_Changed_Text_");
                this.SetProperty(ref this.first_Name_Changed_Text_, value);
            }
        }

        public string Last_Name_Placeholder_
        {
            get
            {
                if (string.IsNullOrEmpty(this.last_Name_Placeholder_))
                {
                    return "Empty string";
                }

                return this.last_Name_Placeholder_;
            }

            set
            {
                this.last_Name_Placeholder_ = value;
                this.OnPropertyChanged("Last_Name_Placeholder_");
                this.SetProperty(ref this.last_Name_Placeholder_, value);
            }
        }

        public string Last_Name_Changed_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.last_Name_Changed_Text_))
                {
                    return string.Empty;
                }

                return this.last_Name_Changed_Text_;
            }

            set
            {
                this.last_Name_Changed_Text_ = value;
                this.OnPropertyChanged("Last_Name_Changed_Text_");
                this.SetProperty(ref this.last_Name_Changed_Text_, value);
            }
        }

        public string Picture_Changed_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.picture_Changed_Text_))
                {
                    return string.Empty;
                }

                return this.picture_Changed_Text_;
            }

            set
            {
                this.picture_Changed_Text_ = value;
                this.OnPropertyChanged("Picture_Changed_Text_");
                this.SetProperty(ref this.picture_Changed_Text_, value);
            }
        }

        public string Picture_Placeholder_
        {
            get
            {
                if (string.IsNullOrEmpty(this.picture_Placeholder_))
                {
                    return "Empty string";
                }

                return this.picture_Placeholder_;
            }

            set
            {
                this.picture_Placeholder_ = value;
                this.OnPropertyChanged("Picture_Placeholder_");
                this.SetProperty(ref this.picture_Placeholder_, value);
            }
        }

        public string Confirm_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.confirm_Button_))
                {
                    return "Empty string";
                }

                return this.confirm_Button_;
            }

            set
            {
                this.confirm_Button_ = value;
                this.OnPropertyChanged("Confirm_Button_");
                this.SetProperty(ref this.confirm_Button_, value);
            }
        }

        public string Cancel_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.cancel_Button_))
                {
                    return "Empty string";
                }

                return this.cancel_Button_;
            }

            set
            {
                this.cancel_Button_ = value;
                this.OnPropertyChanged("Cancel_Button_");
                this.SetProperty(ref this.cancel_Button_, value);
            }
        }

        public string Alert_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.alert_Title_))
                {
                    return "Empty string";
                }

                return this.alert_Title_;
            }

            set
            {
                this.alert_Title_ = value;
                this.OnPropertyChanged("Alert_Title_");
                this.SetProperty(ref this.alert_Title_, value);
            }
        }

        public string Alert_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.alert_Message_))
                {
                    return "Empty string";
                }

                return this.alert_Message_;
            }

            set
            {
                this.alert_Message_ = value;
                this.OnPropertyChanged("Alert_Message_");
                this.SetProperty(ref this.alert_Message_, value);
            }
        }

        public string Alert_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.alert_Button_))
                {
                    return "Empty string";
                }

                return this.alert_Button_;
            }

            set
            {
                this.alert_Button_ = value;
                this.OnPropertyChanged("Alert_Button_");
                this.SetProperty(ref this.alert_Button_, value);
            }
        }



        private DelegateCommand profile_Edit_Confirm_Button_Command_;
        public DelegateCommand Profile_Edit_Confirm_Button_Command_ => this.profile_Edit_Confirm_Button_Command_ ?? (this.profile_Edit_Confirm_Button_Command_ = new DelegateCommand(this.ProfileEditConfirmButton));
        private async void ProfileEditConfirmButton()
        {
            //CHECK IF FIRSTNAME, LASTNAME, AND PICTURE FIELD TEXT VALUES ARE NOT NULL OR EMPTY
            if(!string.IsNullOrEmpty(this.First_Name_Changed_Text_) && !string.IsNullOrEmpty(this.Last_Name_Changed_Text_) && !string.IsNullOrEmpty(this.Picture_Changed_Text_))
            {
                //IF THE FIRSTNAME TEXT FIELD HAS BEEN CHANGED THEN UPDATE THE USERS FIRSTNAME
                if (this.First_Name_Changed_Text_.Length > 0)
                {
                    this.user_.First_Name_ = this.First_Name_Changed_Text_;
                }
                //IF THE LASTNAME TEXT FIELD HAS BEEN CHANGED THEN UPDATE THE USERS LASTNAME
                if (this.Last_Name_Changed_Text_.Length > 0)
                {
                    this.user_.Last_Name_ = this.Last_Name_Changed_Text_;
                }
                //IF THE PICTURES TEXT FIELD HAS BEEN CHANGED THEN UPDATE THE USERS PICTURE URL LINK
                if (this.Picture_Changed_Text_.Length > 0)
                {
                    this.user_.Picture_ = this.Picture_Changed_Text_;
                }

                //CREATE PARAMETERS
                var p = new NavigationParameters();

                p.Add("user_", this.user_);

                //UPDATE THE USERS VALUES IN THE DATABASE
                this.client_Connection_.EditUser(this.user_.ID_, this.user_.First_Name_, this.user_.Last_Name_, this.user_.Picture_);

                //PASS PARAMETERS
                await this.navigation_Service_.GoBackAsync(p);
            }
            else
            {
                //IF ALL 3 TEXT FIELDS ARE NULL OR EMPTY THEN GIVE AN ERROR DEPENDING ON CURRENTLY ACTIVE LANGUAGE
                if(this.l_Eng_.Is_English_Selected_)
                {
                    await Application.Current.MainPage.DisplayAlert(this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_ALERT_TITLE], this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_ALERT_MESSAGE], this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_ALERT_BUTTON]);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_ALERT_TITLE], this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_ALERT_MESSAGE], this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_ALERT_BUTTON]);
                }
            }
            
        }

        private DelegateCommand profile_Edit_Cancel_Button_Command_;
        public DelegateCommand Profile_Edit_Cancel_Button_Command_ => this.profile_Edit_Cancel_Button_Command_ ?? (this.profile_Edit_Cancel_Button_Command_ = new DelegateCommand(this.ProfileEditCancelButton));
        private void ProfileEditCancelButton()
        {
            //GO BACK TO PREVIOUS PAGE WITHOUT CHANGING ANYTHING 
            this.navigation_Service_.GoBackAsync();
        }

        private void SetLanguage()
        {
            //CHECK WHICH LANGUAGE IS CURRENTLY SELECTED AND THEN SET IT BASED ON THAT
            if(this.l_Eng_.Is_English_Selected_)
            {
                this.Confirm_Button_ = this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_CONFIRM_BUTTON];
                this.Cancel_Button_ = this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_CANCEL_BUTTON];
                this.Alert_Title_ = this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_ALERT_TITLE];
                this.Alert_Message_ = this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_ALERT_MESSAGE];
                this.Alert_Button_ = this.l_Eng_.Word[ENG_WORD.PROFILE_EDIT_ALERT_BUTTON];
            }
            else if(this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Confirm_Button_ = this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_CONFIRM_BUTTON];
                this.Cancel_Button_ = this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_CANCEL_BUTTON];
                this.Alert_Title_ = this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_ALERT_TITLE];
                this.Alert_Message_ = this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_ALERT_MESSAGE];
                this.Alert_Button_ = this.l_Jap_.Word[JAP_WORD.PROFILE_EDIT_ALERT_BUTTON];
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //VALUES BEING PASSED INTO THE SETTING PAGE FROM THE PREVIOUS PAGE
            if(parameters.Count() > 0)
            {
                this.user_.ID_ = parameters.GetValue<UserViewModel>("user_").ID_;
                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;
                this.user_.Picture_ = parameters.GetValue<UserViewModel>("user_").Picture_;

                this.l_Eng_ = parameters.GetValue<LanguageEnglish>("l_Eng_");
                this.l_Jap_ = parameters.GetValue<LanguageJapanese>("l_Jap_");

                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.client_Connection_ = parameters.GetValue<ClientConnection>("client_Connection_");
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;
                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;

                this.First_Name_Placeholder_ = this.user_.First_Name_;
                this.Last_Name_Placeholder_ = this.user_.Last_Name_;
                this.Picture_Placeholder_ = this.user_.Picture_;

                this.SetLanguage();
            }
        }
    }
}
