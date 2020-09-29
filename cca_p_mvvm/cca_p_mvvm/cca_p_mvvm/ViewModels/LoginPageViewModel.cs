using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Android.Telecom;
using System.Runtime.CompilerServices;
using DryIoc;
using Java.Util;
using System.Collections.ObjectModel;

namespace cca_p_mvvm.ViewModels
{
    public class LoginPageViewModel : ViewModelBase, INavigationAware
    {
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.user_Credidentials_ = new List<UserViewModel>();
            this.GetUsers();

            this.SetLanguage();
        }

        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //UI VARIABLES
        private string sign_In_Frame_Label_;
        private string sign_In_Username_Entry_Placeholder_;
        private string sign_In_Password_Entry_Placeholder_;
        private string sign_In_Login_Button_;
        private string sign_In_Login_Error_Title_;
        private string sign_In_Login_Error_Message_;
        private string sign_In_Login_Error_Button_;

        private string username_Entry_Changed_Text_;
        private string password_Entry_Changed_Text_;

        private string connection_Error_Title_;
        private string connection_Error_Message_;
        private string connection_Error_Button_;


        //THIS WILL GATHER ALL USER LOGINS AND PASSWORDS FROM THE JSON
        private IList<UserViewModel> user_Credidentials_ { get; set; }

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }


        public string Sign_In_Frame_Label_
        {
            get
            {
                if (string.IsNullOrEmpty(this.sign_In_Frame_Label_))
                {
                    return "Empty string";
                }

                return this.sign_In_Frame_Label_;
            }

            set
            {
                this.sign_In_Frame_Label_ = value;
                this.OnPropertyChanged("Sign_In_Frame_Label_");
                this.SetProperty(ref this.sign_In_Frame_Label_, value);
            }
        }

        public string Sign_In_Username_Entry_Placeholder_
        {
            get
            {
                if (string.IsNullOrEmpty(this.sign_In_Password_Entry_Placeholder_))
                {
                    return "Empty string";
                }

                return this.sign_In_Username_Entry_Placeholder_;
            }

            set
            {
                this.sign_In_Username_Entry_Placeholder_ = value;
                this.OnPropertyChanged("Sign_In_Username_Entry_Placeholder_");
                this.SetProperty(ref this.sign_In_Username_Entry_Placeholder_, value);
            }
        }

        public string Sign_In_Password_Entry_Placeholder_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Username_Entry_Placeholder_))
                {
                    return "Empty string";
                }

                return this.sign_In_Password_Entry_Placeholder_;
            }

            set
            {
                this.sign_In_Password_Entry_Placeholder_ = value;
                this.OnPropertyChanged("Sign_In_Password_Entry_Placeholder_");
                this.SetProperty(ref this.sign_In_Password_Entry_Placeholder_, value);
            }
        }

        public string Sign_In_Login_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.sign_In_Login_Button_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Button_;
            }

            set
            {
                this.sign_In_Login_Button_ = value;
                this.OnPropertyChanged("Sign_In_Login_Button_");
                this.SetProperty(ref this.sign_In_Login_Button_, value);
            }
        }
        
        public string Sign_In_Login_Error_Title_
        {
            get
            {
                if (string.IsNullOrEmpty(this.sign_In_Login_Error_Title_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Title_;
            }

            set
            {
                this.sign_In_Login_Error_Title_ = value;
                this.OnPropertyChanged("Sign_In_Login_Error_Title_");
                this.SetProperty(ref this.sign_In_Login_Error_Title_, value);
            }
        }

        public string Sign_In_Login_Error_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Message_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Message_;
            }

            set
            {
                this.sign_In_Login_Error_Message_ = value;
                this.OnPropertyChanged("Sign_In_Login_Error_Message_");
                this.SetProperty(ref this.sign_In_Login_Error_Message_, value);
            }
        }

        public string Sign_In_Login_Error_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Button_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Button_;
            }

            set
            {
                this.sign_In_Login_Error_Button_ = value;
                this.OnPropertyChanged("Sign_In_Login_Error_Button_");
                this.SetProperty(ref this.sign_In_Login_Error_Button_, value);
            }
        }

        public string Username_Entry_Changed_Text_
        {
            get
            {
                return this.username_Entry_Changed_Text_;
            }

            set
            {
                this.username_Entry_Changed_Text_ = value;
                this.OnPropertyChanged("Username_Entry_Changed_Text_");
                this.SetProperty(ref this.username_Entry_Changed_Text_, value);
            }
        }

        public string Password_Entry_Changed_Text_
        {
            get
            {
                return this.password_Entry_Changed_Text_;
            }

            set
            {
                this.password_Entry_Changed_Text_ = value;
                this.OnPropertyChanged("Password_Entry_Changed_Text_");
                this.SetProperty(ref this.password_Entry_Changed_Text_, value);
            }
        }

        public string Connection_Error_Title_
        {
            get
            {
                if (string.IsNullOrEmpty(this.connection_Error_Title_))
                {
                    return "Empty string";
                }

                return this.connection_Error_Title_;
            }

            set
            {
                this.connection_Error_Title_ = value;
                this.OnPropertyChanged("Connection_Error_Title_");
                this.SetProperty(ref this.connection_Error_Title_, value);
            }
        }

        public string Connection_Error_Message_
        {
            get
            {
                if (string.IsNullOrEmpty(this.connection_Error_Message_))
                {
                    return "Empty string";
                }

                return this.connection_Error_Message_;
            }

            set
            {
                this.connection_Error_Message_ = value;
                this.OnPropertyChanged("Connection_Error_Message_");
                this.SetProperty(ref this.connection_Error_Message_, value);
            }
        }

        private string Connection_Error_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.connection_Error_Button_))
                {
                    return "Empty string";
                }

                return this.Connection_Error_Button_;
            }

            set
            {
                this.connection_Error_Button_ = value;
                this.OnPropertyChanged("Connection_Error_Button_");
                this.SetProperty(ref this.connection_Error_Button_, value); 
            }
        }



        public IList<UserViewModel> User_Credidentials_
        {
            get
            {
                return this.user_Credidentials_;
            }
        }


        private async void GetUsers()
        {
            //CHECKS CONNECTION AND THEN GRABS ALL THE CREATED USERS INSIDE THE JSON
            if(this.CheckConnection())
            {
                WebServiceClient client = new WebServiceClient();
                var result = await client.Get<UserViewModel>("https://my-json-server.typicode.com/BlockyNewt/test/users");

                if (result != null)
                {
                    for (int i = 0; i < result.Count(); ++i)
                    {
                        UserViewModel newUser = new UserViewModel();
                        newUser.First_Name_ = result[i].First_Name_;
                        newUser.Last_Name_ = result[i].Last_Name_;
                        newUser.Username_ = result[i].Username_;
                        newUser.Password_ = result[i].Password_;

                        this.User_Credidentials_.Add(newUser);
                    }
                }
            }
        }




        private DelegateCommand login_Command_;
        public DelegateCommand Login_Command_ => this.login_Command_ ?? (this.login_Command_ = new DelegateCommand(this.LoggingIn));
        private async void LoggingIn()
        {
            //FIRST CHECK CONNECTION
            if (this.CheckConnection())
            {
                for(int i = 0; i < this.User_Credidentials_.Count(); ++i)
                {
                    //SECOND LOOP THROUGH ALL THE USER IN THE JSON FILE AND CHECK IF WE HAVE THE CORRECT CREDIDENTIALS
                    if(this.Username_Entry_Changed_Text_ == this.User_Credidentials_[i].Username_ && this.Password_Entry_Changed_Text_ == this.user_Credidentials_[i].Password_)
                    {
                        //THIRD CREATE NEW USER IF THE USERNAME AND PASSWORD WERE CORRECT
                        UserViewModel user = new UserViewModel(); 
                        user.First_Name_ = this.User_Credidentials_[i].First_Name_;
                        user.Last_Name_ = this.User_Credidentials_[i].Last_Name_;

                        //PASS ALL THE REQUIRED VARIABLES INTO THE HOME PAGE
                        var p = new NavigationParameters();

                        p.Add("l_Eng_", this.l_Eng_);
                        p.Add("l_Jap_", this.l_Jap_);
                        p.Add("user_", user);

                        this.Username_Entry_Changed_Text_ = string.Empty;
                        this.Password_Entry_Changed_Text_ = string.Empty;

                        await this.navigation_Service_.NavigateAsync("HomePage", p);

                        //MAY WANT TO FIGURE SOMETHING OUT FOR THIS. WE DONT WANT TO KEEP ALL USER CREDIDENTIALS ON THE CLIENT AFTER LOGIN
                        //this.User_Credidentials_.Clear();
                        //Console.WriteLine("Cleared the creds ");
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert(this.Sign_In_Login_Error_Title_, this.Sign_In_Login_Error_Message_, this.Sign_In_Login_Error_Button_);
                    }
                }
            }
            else
            {
                this.Username_Entry_Changed_Text_ = string.Empty;
                this.Password_Entry_Changed_Text_ = string.Empty;
            }
        }

        private bool CheckConnection()
        {
            //CHECK TO SEE IF THE CURRENT CLIENT IS CONNECTED TO THE INTERNET OR WIFI
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                return true;
            }
            else
            {
                //IF IT'S NOT CONNECTED THEN IT WILL DISPLAY AN ALERT 
                Application.Current.MainPage.DisplayAlert(this.connection_Error_Title_, this.Connection_Error_Message_, this.connection_Error_Button_);
                return false;
            }
        }

        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON WHICH ONE IS TRUE
            if(this.l_Eng_.Is_English_Selected_)
            {
                this.Sign_In_Frame_Label_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_FRAME_LABEL];
                this.Sign_In_Username_Entry_Placeholder_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER];
                this.Sign_In_Password_Entry_Placeholder_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER];
                this.Sign_In_Login_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_BUTTON];
                this.Sign_In_Login_Error_Title_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_TITLE];
                this.Sign_In_Login_Error_Message_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_MESSAGE];
                this.Sign_In_Login_Error_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_BUTTON];


                this.connection_Error_Title_ = this.l_Eng_.Word[ENG_WORD.CONNECTION_ERROR_TITLE];
                this.connection_Error_Message_ = this.l_Eng_.Word[ENG_WORD.CONNECTION_ERROR_MESSAGE];
                this.connection_Error_Button_ = this.l_Eng_.Word[ENG_WORD.CONNECTION_ERROR_BUTTON];
            }
            else if(this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Sign_In_Frame_Label_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_FRAME_LABEL];
                this.Sign_In_Username_Entry_Placeholder_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER];
                this.Sign_In_Password_Entry_Placeholder_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER];
                this.Sign_In_Login_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_BUTTON];
                this.Sign_In_Login_Error_Title_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_TITLE];
                this.Sign_In_Login_Error_Message_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_MESSAGE];
                this.Sign_In_Login_Error_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_BUTTON];

                this.connection_Error_Title_ = this.l_Jap_.Word[JAP_WORD.CONNECTION_ERROR_TITLE];
                this.connection_Error_Message_ = this.l_Jap_.Word[JAP_WORD.CONNECTION_ERROR_MESSAGE];
                this.connection_Error_Button_ = this.l_Jap_.Word[JAP_WORD.CONNECTION_ERROR_BUTTON];
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //WHEN WE LOGOUT IT WILL PASS BACK THESE VARIABLES FROM HOME PAGE
            if(parameters.Count() > 0)
            {
                this.l_Eng_ = parameters.GetValue<LanguageEnglish>("l_Eng_");
                this.l_Jap_ = parameters.GetValue<LanguageJapanese>("l_Jap_");

                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.SetLanguage();
            }
        }
    }
}
