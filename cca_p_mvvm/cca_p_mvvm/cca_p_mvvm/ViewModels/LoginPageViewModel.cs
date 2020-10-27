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
using Org.Apache.Http.Cookie.Params;
using System.Threading.Tasks;
using System.IO;
using Android.Provider;

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

            this.client_Connection_ = new ClientConnection();

            this.user_ = new UserViewModel();

            this.color_Scheme_ = new ColorScheme();
            //this.color_Scheme_.Is_Light_Selected_ = false;
            //this.color_Scheme_.Is_Dark_Selected_ = true;
            //this.color_Scheme_.Is_Halloween_Selected_ = false;
            //this.color_Scheme_.Is_Christmas_Selected_ = false;

            this.file_Name_ = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "settings.txt");

            //File.WriteAllText(this.file_Name_, string.Empty);
            this.ReadSettingsFromFile();

            this.SetLanguage();
        }

        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //FILE TO SAVE USERNAME THEME AND LANGAUGE SETTINGS
        private string file_Name_;

        //UI VARIABLES
        private string sign_In_Frame_Label_;
        private string sign_In_Username_Entry_Placeholder_;
        private string sign_In_Password_Entry_Placeholder_;
        private string sign_In_Login_Button_;
        private string sign_In_Login_Error_Credentials_Title_;
        private string sign_In_Login_Error_Credentials_Message_;
        private string sign_In_Login_Error_Credentials_Button_;
        private string sign_In_Login_Error_Connection_Title_;
        private string sign_In_Login_Error_Connection_Message_;
        private string sign_In_Login_Error_Connection_Button_;
        private string sign_In_Login_Error_Already_Logged_In_Title_;
        private string sign_In_Login_Error_Already_Logged_In_Message_;
        private string sign_In_Login_Error_Already_Logged_In_Button_;
        private string sign_In_Create_Account_Button_;
        private string sign_In_Save_Username_Checkbox_;

        private string username_Entry_Changed_Text_;
        private string password_Entry_Changed_Text_;

        private string connection_Error_Title_;
        private string connection_Error_Message_;
        private string connection_Error_Button_;

        private bool is_Save_Username_Checked_;

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }

        //CONNECTION TO THE SERVER
        public ClientConnection client_Connection_ { get; private set; }

        //CLIENT USER
        public UserViewModel user_ { get; private set; }

        //COLOR-SCHEMES
        public ColorScheme color_Scheme_ { get; private set; }


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
                this.SetProperty(ref this.sign_In_Frame_Label_, value);
                this.RaisePropertyChanged("Sign_In_Frame_Label_");
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
                this.SetProperty(ref this.sign_In_Username_Entry_Placeholder_, value);
                this.RaisePropertyChanged("Sign_In_Username_Entry_Placeholder_");
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
                this.SetProperty(ref this.sign_In_Password_Entry_Placeholder_, value);
                this.RaisePropertyChanged("Sign_In_Password_Entry_Placeholder_");
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
                this.SetProperty(ref this.sign_In_Login_Button_, value);
                this.RaisePropertyChanged("Sign_In_Login_Button_");
            }
        }
        
        public string Sign_In_Login_Error_Credentials_Title_
        {
            get
            {
                if (string.IsNullOrEmpty(this.sign_In_Login_Error_Credentials_Title_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Credentials_Title_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Credentials_Title_, value);
                this.RaisePropertyChanged("Sign_In_Login_Error_Credentials_Title_");
            }
        }

        public string Sign_In_Login_Error_Credentials_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Credentials_Message_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Credentials_Message_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Credentials_Message_, value);
                this.RaisePropertyChanged("Sign_In_Login_Error_Credentials_Message_");
            }
        }

        public string Sign_In_Login_Error_Credentials_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Credentials_Button_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Credentials_Button_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Credentials_Button_, value);
                this.RaisePropertyChanged("Sign_In_Login_Error_Credentials_Button_");
            }
        }

        public string Sign_In_Login_Error_Connection_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Connection_Title_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Connection_Title_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Connection_Title_, value);
                this.RaisePropertyChanged("Sign_In_Login_Error_Connection_Title_");
            }
        }

        public string Sign_In_Login_Error_Connection_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Connection_Message_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Connection_Message_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Connection_Message_, value);
                this.RaisePropertyChanged("Sign_In_Login_Error_Connection_Message_");
            }
        }

        public string Sign_In_Login_Error_Connection_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Connection_Button_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Connection_Button_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Connection_Button_, value);
                this.RaisePropertyChanged("Sign_In_Login_Error_Connection_Button_");
            }
        }

        public string Sign_In_Login_Error_Already_Logged_In_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Already_Logged_In_Title_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Already_Logged_In_Title_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Already_Logged_In_Title_, value);
                this.RaisePropertyChanged("");
            }
        }

        public string Sign_In_Login_Error_Already_Logged_In_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(sign_In_Login_Error_Already_Logged_In_Message_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Already_Logged_In_Message_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Already_Logged_In_Message_, value);
                this.RaisePropertyChanged("");
            }
        }

        public string Sign_In_Login_Error_Already_Logged_In_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Login_Error_Already_Logged_In_Button_))
                {
                    return "Empty string";
                }

                return this.sign_In_Login_Error_Already_Logged_In_Button_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Login_Error_Already_Logged_In_Button_, value);
                this.RaisePropertyChanged("");
            }
        }

        public string Sign_In_Create_Account_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sign_In_Create_Account_Button_))
                {
                    return "Empty string";
                }

                return this.sign_In_Create_Account_Button_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Create_Account_Button_, value);
                this.RaisePropertyChanged("Sign_In_Create_Account_Button_");
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
                this.SetProperty(ref this.username_Entry_Changed_Text_, value);
                this.RaisePropertyChanged("Username_Entry_Changed_Text_");
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
                this.SetProperty(ref this.password_Entry_Changed_Text_, value);
                this.RaisePropertyChanged("Password_Entry_Changed_Text_");
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
                this.SetProperty(ref this.connection_Error_Title_, value);
                this.RaisePropertyChanged("Connection_Error_Title_");
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
                this.SetProperty(ref this.connection_Error_Message_, value);
                this.RaisePropertyChanged("Connection_Error_Message_");
            }
        }

        public string Connection_Error_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.connection_Error_Button_))
                {
                    return "Empty string";
                }

                return this.connection_Error_Button_;
            }

            set
            {
                this.SetProperty(ref this.connection_Error_Button_, value);
                this.RaisePropertyChanged("Connection_Error_Button_");
            }
        }

        public bool Is_Save_Username_Checked_
        {
            get
            {
                return this.is_Save_Username_Checked_;
            }

            set
            {
                this.SetProperty(ref this.is_Save_Username_Checked_, value);
                this.RaisePropertyChanged("Is_Save_Username_Checked_");
            }
        }

        public string Sign_In_Save_Username_Checkbox_
        {
            get
            {
                if (string.IsNullOrEmpty(this.sign_In_Save_Username_Checkbox_))
                {
                    return "Empty string";
                }

                return this.sign_In_Save_Username_Checkbox_;
            }

            set
            {
                this.SetProperty(ref this.sign_In_Save_Username_Checkbox_, value);
                this.RaisePropertyChanged("Sign_In_Save_Username_Checkbox_");
            }
        }



        private DelegateCommand setting_Button_Command_;
        public DelegateCommand Setting_Button_Command_ => this.setting_Button_Command_ ?? (this.setting_Button_Command_ = new DelegateCommand(this.SettingButton));
        private async void SettingButton()
        {
            //IF CLICKED IT WILL TAKE YOU TO THE SETTINGS PAGE 
            var p = new NavigationParameters();

            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);
            p.Add("client_Connection_", this.client_Connection_);
            p.Add("color_Scheme_", this.color_Scheme_);

            await this.navigation_Service_.NavigateAsync("SettingPage", p);
        }



        private DelegateCommand login_Command_;
        public DelegateCommand Login_Command_ => this.login_Command_ ?? (this.login_Command_ = new DelegateCommand(this.LoggingIn));
        private async void LoggingIn()
        {
            //CHECK MOBILE DEVICE CONNECTION
            if(this.CheckConnection())
            {
                //MAKE SURE BOTH USERNAME AND PASSWORD TEXT FIELDS ARE NOT EMPTY OR NULL
                if (!string.IsNullOrEmpty(this.Username_Entry_Changed_Text_) && 
                    !string.IsNullOrEmpty(this.Password_Entry_Changed_Text_) || 
                    !string.IsNullOrEmpty(this.Username_Entry_Changed_Text_) || 
                    !string.IsNullOrEmpty(this.Password_Entry_Changed_Text_))
                {
                    //FIRST CONNECT TO SERVER ON LOGIN
                    if (this.client_Connection_.Connect())
                    {
                        //SEND LOGIN CREDIDENTIALS TO THE SERVER TO CHECK WITH THE DATABASE
                        if (this.client_Connection_.LoginMessage(this.Username_Entry_Changed_Text_) == this.Password_Entry_Changed_Text_)
                        {
                            //GET USER ID, FIRSTNAME, AND LASTNAME
                            string[] userInfo = this.client_Connection_.GetUser(this.Password_Entry_Changed_Text_);

                            this.user_.ID_ = Convert.ToInt32(userInfo[0]);
                            this.user_.First_Name_ = userInfo[1];
                            this.user_.Last_Name_ = userInfo[2];
                            this.user_.Fullname_ = this.user_.First_Name_ + " " + this.user_.Last_Name_;
                            this.user_.Bio_ = userInfo[3];
                            this.user_.Picture_ = userInfo[4];

                            if(!this.client_Connection_.CheckIfUserIsLogged(this.user_.ID_))
                            {
                                //PASS VARIABLES TO NEXT PAGE
                                var p = new NavigationParameters();

                                p.Add("l_Eng_", this.l_Eng_);
                                p.Add("l_Jap_", this.l_Jap_);
                                p.Add("user_", user_);
                                p.Add("client_Connection_", this.client_Connection_);
                                p.Add("color_Scheme_", this.color_Scheme_);

                                if(this.client_Connection_.ChangeUserLoggedValue(this.user_.ID_, 1))
                                {
                                    this.SaveSettingsToFile();

                                    if(!this.Is_Save_Username_Checked_)
                                    {
                                        //RESET USERNAME AND PASSWORD TEXT FIELDS
                                        this.Username_Entry_Changed_Text_ = string.Empty;
                                    }

                                    this.Password_Entry_Changed_Text_ = string.Empty;


                                    //GOTO NEXT PAGE
                                    await this.navigation_Service_.NavigateAsync("HomePage", p);
                                }
                                else
                                {
                                    if (!this.Is_Save_Username_Checked_)
                                    {
                                        //RESET USERNAME AND PASSWORD TEXT FIELDS
                                        this.Username_Entry_Changed_Text_ = string.Empty;
                                    }

                                    this.Password_Entry_Changed_Text_ = string.Empty;

                                    //CONNECTION ERROR
                                    await Application.Current.MainPage.DisplayAlert(this.Sign_In_Login_Error_Connection_Title_, this.Sign_In_Login_Error_Connection_Message_, this.Sign_In_Login_Error_Connection_Button_);
                                }
                            }
                            else
                            {
                                if (!this.Is_Save_Username_Checked_)
                                {
                                    //RESET USERNAME AND PASSWORD TEXT FIELDS
                                    this.Username_Entry_Changed_Text_ = string.Empty;
                                }

                                this.Password_Entry_Changed_Text_ = string.Empty;

                                //THIS ACCOUNT IS ALREADY LOGGED IN ERROR 
                                await Application.Current.MainPage.DisplayAlert(this.Sign_In_Login_Error_Already_Logged_In_Title_, this.Sign_In_Login_Error_Already_Logged_In_Message_, this.Sign_In_Login_Error_Already_Logged_In_Message_);
                            }
                        }
                        else
                        {
                            if (!this.Is_Save_Username_Checked_)
                            {
                                //RESET USERNAME AND PASSWORD TEXT FIELDS
                                this.Username_Entry_Changed_Text_ = string.Empty;
                            }

                            this.Password_Entry_Changed_Text_ = string.Empty;

                            //GIVE AN ERROR IF LOGIN CREDIDENTIALS CAME BACK INVALID
                            await Application.Current.MainPage.DisplayAlert(this.Sign_In_Login_Error_Credentials_Title_, this.Sign_In_Login_Error_Credentials_Message_, this.Sign_In_Login_Error_Credentials_Button_);
                        }
                    }
                    else
                    {
                        if (!this.Is_Save_Username_Checked_)
                        {
                            //RESET USERNAME AND PASSWORD TEXT FIELDS
                            this.Username_Entry_Changed_Text_ = string.Empty;
                        }

                        this.Password_Entry_Changed_Text_ = string.Empty;

                        //CONNECTION ERROR 
                        await Application.Current.MainPage.DisplayAlert(this.Sign_In_Login_Error_Connection_Title_, this.Sign_In_Login_Error_Connection_Message_, this.Sign_In_Login_Error_Connection_Button_);
                    }
                }
                else
                {
                    if (!this.Is_Save_Username_Checked_)
                    {
                        //RESET USERNAME AND PASSWORD TEXT FIELDS
                        this.Username_Entry_Changed_Text_ = string.Empty;
                    }

                    this.Password_Entry_Changed_Text_ = string.Empty;

                    //LOGIN CREDENTIALS ARE INCORRECT ERROR
                    await Application.Current.MainPage.DisplayAlert(this.Sign_In_Login_Error_Credentials_Title_, this.Sign_In_Login_Error_Credentials_Message_, this.Sign_In_Login_Error_Credentials_Button_);
                }
            }
        }



        private DelegateCommand create_Account_Button_Command_;
        public DelegateCommand Create_Account_Button_Command_ => this.create_Account_Button_Command_ ?? (this.create_Account_Button_Command_ = new DelegateCommand(this.CreateAccount));
        private async void CreateAccount()
        {
            //PASS USER AND LANGUAGE PARAMETERS 
            var p = new NavigationParameters();

            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);
            p.Add("client_Connection_", this.client_Connection_);
            p.Add("color_Scheme_", this.color_Scheme_);

            //PUSH TO PAGE
            await this.navigation_Service_.NavigateAsync("CreateAccountPage", p);
        }



        
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //WHEN WE LOGOUT IT WILL PASS BACK THESE VARIABLES FROM HOME PAGE
            if(parameters.Count() == 3)
            {
                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;
                
                this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
                this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;
                this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;
                this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;
            }
            //COMING BACK FROM SETTINGS PAGE
            else if (parameters.Count() == 4)
            {
                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;

                this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
                this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;
                this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;
                this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;
            }
            //COMING BACK FROM ACCOUNT CREATION
            else if(parameters.Count() == 5)
            {
                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;

                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;
                this.user_.Picture_ = parameters.GetValue<UserViewModel>("user_").Picture_;

                this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
                this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;
                this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;
                this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;
            }

            this.SetLanguage();
            this.color_Scheme_.SetColors();
        }




        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON WHICH ONE IS TRUE
            if (this.l_Eng_.Is_English_Selected_)
            {
                this.Sign_In_Frame_Label_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_FRAME_LABEL];
                this.Sign_In_Username_Entry_Placeholder_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER];
                this.Sign_In_Password_Entry_Placeholder_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER];
                this.Sign_In_Login_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_BUTTON];
                this.Sign_In_Login_Error_Credentials_Title_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_TITLE];
                this.Sign_In_Login_Error_Credentials_Message_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_MESSAGE];
                this.Sign_In_Login_Error_Credentials_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_BUTTON];
                this.Sign_In_Login_Error_Connection_Title_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_TITLE];
                this.Sign_In_Login_Error_Connection_Message_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_MESSAGE];
                this.Sign_In_Login_Error_Connection_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_BUTTON];
                this.Sign_In_Create_Account_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_CREATE_ACCOUNT_BUTTON];
                this.Sign_In_Login_Error_Already_Logged_In_Title_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_TITLE];
                this.Sign_In_Login_Error_Already_Logged_In_Message_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_MESSAGE];
                this.Sign_In_Login_Error_Already_Logged_In_Button_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_BUTTON];
                this.Sign_In_Save_Username_Checkbox_ = this.l_Eng_.Word[ENG_WORD.SIGN_IN_SAVE_USERNAME_BUTTON];

                this.connection_Error_Title_ = this.l_Eng_.Word[ENG_WORD.CONNECTION_ERROR_TITLE];
                this.connection_Error_Message_ = this.l_Eng_.Word[ENG_WORD.CONNECTION_ERROR_MESSAGE];
                this.connection_Error_Button_ = this.l_Eng_.Word[ENG_WORD.CONNECTION_ERROR_BUTTON];
            }
            else if (this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Sign_In_Frame_Label_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_FRAME_LABEL];
                this.Sign_In_Username_Entry_Placeholder_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_USERNAME_ENTRY_PLACEHOLDER];
                this.Sign_In_Password_Entry_Placeholder_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_PASSWORD_ENTRY_PLACEHOLDER];
                this.Sign_In_Login_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_BUTTON];
                this.Sign_In_Login_Error_Credentials_Title_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_TITLE];
                this.Sign_In_Login_Error_Credentials_Message_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_MESSAGE];
                this.Sign_In_Login_Error_Credentials_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_CREDENTIALS_BUTTON];
                this.Sign_In_Login_Error_Connection_Title_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_TITLE];
                this.Sign_In_Login_Error_Connection_Message_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_MESSAGE];
                this.Sign_In_Login_Error_Connection_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_CONNECTION_BUTTON];
                this.Sign_In_Create_Account_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_CREATE_ACCOUNT_BUTTON];
                this.Sign_In_Login_Error_Already_Logged_In_Title_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_TITLE];
                this.Sign_In_Login_Error_Already_Logged_In_Message_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_MESSAGE];
                this.Sign_In_Login_Error_Already_Logged_In_Button_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_LOGIN_ERROR_ALREADY_LOGGED_IN_BUTTON];
                this.Sign_In_Save_Username_Checkbox_ = this.l_Jap_.Word[JAP_WORD.SIGN_IN_SAVE_USERNAME_BUTTON];

                this.connection_Error_Title_ = this.l_Jap_.Word[JAP_WORD.CONNECTION_ERROR_TITLE];
                this.connection_Error_Message_ = this.l_Jap_.Word[JAP_WORD.CONNECTION_ERROR_MESSAGE];
                this.connection_Error_Button_ = this.l_Jap_.Word[JAP_WORD.CONNECTION_ERROR_BUTTON];
            }
        }

        private bool CheckConnection()
        {
            var current = Connectivity.NetworkAccess;
            
            if (current == NetworkAccess.Internet)
            {
                //IF CLIENT IS CONNECTED THEN CONTINUE
                Console.WriteLine("MOBILE DEVICE IS CONNECTED TO INTERNET.");
                return true;
            }
            else
            {
                Console.WriteLine("NOT CONNECTED TO WIFI BITCH.");
                //IF IT'S NOT CONNECTED THEN IT WILL DISPLAY AN ALERT 
                Application.Current.MainPage.DisplayAlert(this.connection_Error_Title_, this.Connection_Error_Message_, this.connection_Error_Button_);

                return false;
            }
        }

        private void ReadSettingsFromFile()
        {
            if (File.Exists(this.file_Name_))
            {
                string getFromFile = File.ReadAllText(this.file_Name_);

                Console.WriteLine("FILE STRING: " + getFromFile);
                if (!string.IsNullOrEmpty(getFromFile))
                {
                    Console.WriteLine("ABEF");
                    string[] settings = getFromFile.Split(';');
                    Console.WriteLine("GEGF");

                    if (!string.IsNullOrEmpty(settings[0]))
                    {
                        this.Is_Save_Username_Checked_ = Convert.ToBoolean(settings[0]);
                    }
                    Console.WriteLine("ABEFG");

                    if (!string.IsNullOrEmpty(settings[1]))
                    {
                        this.Username_Entry_Changed_Text_ = settings[1];
                    }
                    Console.WriteLine("ACEF");

                    if (!string.IsNullOrEmpty(settings[2]))
                    {
                        this.color_Scheme_.Is_Light_Selected_ = Convert.ToBoolean(settings[2]);
                    }
                    else
                    {
                        this.color_Scheme_.Is_Light_Selected_ = false;
                    }
                    Console.WriteLine("ADEF");

                    if (!string.IsNullOrEmpty(settings[3]))
                    {
                        this.color_Scheme_.Is_Dark_Selected_ = Convert.ToBoolean(settings[3]);
                    }
                    else
                    {
                        this.color_Scheme_.Is_Dark_Selected_ = true;
                    }
                    Console.WriteLine("AEEF");

                    if (!string.IsNullOrEmpty(settings[4]))
                    {
                        this.color_Scheme_.Is_Halloween_Selected_ = Convert.ToBoolean(settings[4]);
                    }
                    else
                    {
                        this.color_Scheme_.Is_Halloween_Selected_ = false;
                    }
                    Console.WriteLine("AFEF");

                    if (!string.IsNullOrEmpty(settings[5]))
                    {
                        this.color_Scheme_.Is_Christmas_Selected_ = Convert.ToBoolean(settings[5]);
                    }
                    else
                    {
                        this.color_Scheme_.Is_Christmas_Selected_ = false;
                    }
                    Console.WriteLine("AEEF");

                    if (!string.IsNullOrEmpty(settings[6]))
                    {
                        this.l_Eng_.Is_English_Selected_ = Convert.ToBoolean(settings[6]);
                    }
                    else
                    {
                        this.l_Eng_.Is_English_Selected_ = true;
                    }
                    Console.WriteLine("AGEF");

                    if (!string.IsNullOrEmpty(settings[7]))
                    {
                        this.l_Jap_.Is_Japanese_Selected_ = Convert.ToBoolean(settings[7]);
                    }
                    else
                    {
                        this.l_Jap_.Is_Japanese_Selected_ = false;
                    }
                    Console.WriteLine("AHEF");

                }
                else
                {
                    Console.WriteLine("BACCE");

                    this.color_Scheme_.Is_Light_Selected_ = false;
                    this.color_Scheme_.Is_Dark_Selected_ = true;
                    this.color_Scheme_.Is_Halloween_Selected_ = false;
                    this.color_Scheme_.Is_Christmas_Selected_ = false;

                    this.l_Eng_.Is_English_Selected_ = true;
                    this.l_Jap_.Is_Japanese_Selected_ = false;

                    this.is_Save_Username_Checked_ = false;
                }
            }
            else
            {
                Console.WriteLine("CCAAC");

                this.color_Scheme_.Is_Light_Selected_ = false;
                this.color_Scheme_.Is_Dark_Selected_ = true;
                this.color_Scheme_.Is_Halloween_Selected_ = false;
                this.color_Scheme_.Is_Christmas_Selected_ = false;

                this.l_Eng_.Is_English_Selected_ = true;
                this.l_Jap_.Is_Japanese_Selected_ = false;

                this.is_Save_Username_Checked_ = false;
            }
        }

        private void SaveSettingsToFile()
        {
            if (File.Exists(this.file_Name_))
            {
                string writeToFile = string.Empty;
                File.WriteAllText(this.file_Name_, writeToFile);

                if (this.Is_Save_Username_Checked_)
                {
                    writeToFile += this.Is_Save_Username_Checked_.ToString() + ";";
                    writeToFile += this.username_Entry_Changed_Text_ + ";";
                }
                else
                {
                    writeToFile += this.Is_Save_Username_Checked_.ToString() + ";";
                    writeToFile += string.Empty + ";";
                }

                Console.WriteLine("CURRENT USERNAME: " + this.Username_Entry_Changed_Text_);
                writeToFile += this.color_Scheme_.Is_Light_Selected_.ToString() + ";";
                writeToFile += this.color_Scheme_.Is_Dark_Selected_.ToString() + ";";
                writeToFile += this.color_Scheme_.Is_Halloween_Selected_.ToString() + ";";
                writeToFile += this.color_Scheme_.Is_Christmas_Selected_.ToString() + ";";

                writeToFile += this.l_Eng_.Is_English_Selected_.ToString() + ";";
                writeToFile += this.l_Jap_.Is_Japanese_Selected_.ToString() + ";";


                Console.WriteLine("SAVING TO FILE: " + writeToFile);
                File.WriteAllText(this.file_Name_, writeToFile);
            }
        }
    }
}
