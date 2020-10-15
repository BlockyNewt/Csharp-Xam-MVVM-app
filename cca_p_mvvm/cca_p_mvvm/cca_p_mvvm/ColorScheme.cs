using Android.Speech.Tts;
using Android.Webkit;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace cca_p_mvvm
{
    public enum COLOR
    {
        DEFAULT = 0,

        LOGIN_BACKGROUND,
        LOGIN_BUTTONS,
        LOGIN_TEXT,
        LOGIN_TEXT_SECONDARY,

        CREATE_ACCOUNT_BACKGROUND,
        CREATE_ACCOUNT_BUTTONS,
        CREATE_ACCOUNT_TEXT,
        CREATE_ACCOUNT_TEXT_SECONDARY,

        SETTING_BACKGROUND,
        SETTING_BUTTONS,
        SETTING_TEXT,
        SETTING_TEXT_SECONDARY,

        HOME_BACKGROUND,
        HOME_BUTTONS,
        HOME_TEXT,
        HOME_TEXT_SECONDARY,

        PROFILE_EDIT_BACKGROUND,
        PROFILE_EDIT_BUTTONS,
        PROFILE_EDIT_TEXT,
        PROFILE_EDIT_TEXT_SECONDARY,

        VIEW_USER_PROFILE_BACKGROUND,
        VIEW_USER_PROFILE_BUTTONS,
        VIEW_USER_PROFILE_TEXT,
        VIEW_USER_PROFILE_TEXT_SECONDARY,

        CHAT_BACKGROUND,
        CHAT_BUTTONS,
        CHAT_TEXT,
    }


    public class ColorScheme : BindableBase
    {
        public ColorScheme()
        {
            //this.is_Light_Selected_ = false;
            //this.is_Dark_Selected_ = true;
            //this.is_Halloween_Selected_ = false;

            string lightColorBackground = "ffffff";
            string lightColorButton = "cde8f6";
            string lightColorText = "968c83";
            string lightColorTextSecondary = "000000";

            string darkColorBackground = "393e46";
            string darkColorButton = "222831";
            string darkColorText = "eeeeee";
            string darkColorTextSecondary = "7971ea";

            string halloweenColorBackground = "313131";
            string halloweenColorButton = "684656";
            //string halloweenColorButton = "7b3c59"; DECENT PURPLE
            string halloweenColorText = "F36A1F";
            string halloweenColorTextSecondary = "FFA52B";


            //LIGHT
            this.light_Color_Scheme_.Add(COLOR.LOGIN_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.LOGIN_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.LOGIN_TEXT, Color.FromHex(lightColorText));
            this.light_Color_Scheme_.Add(COLOR.LOGIN_TEXT_SECONDARY, Color.FromHex(lightColorTextSecondary));

            this.light_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_TEXT, Color.FromHex(lightColorText));
            this.light_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_TEXT_SECONDARY, Color.FromHex(lightColorTextSecondary));

            this.light_Color_Scheme_.Add(COLOR.SETTING_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.SETTING_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.SETTING_TEXT, Color.FromHex(lightColorText));
            this.light_Color_Scheme_.Add(COLOR.SETTING_TEXT_SECONDARY, Color.FromHex(lightColorTextSecondary));

            this.light_Color_Scheme_.Add(COLOR.HOME_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.HOME_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.HOME_TEXT, Color.FromHex(lightColorText));
            this.light_Color_Scheme_.Add(COLOR.HOME_TEXT_SECONDARY, Color.FromHex(lightColorTextSecondary));

            this.light_Color_Scheme_.Add(COLOR.PROFILE_EDIT_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.PROFILE_EDIT_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.PROFILE_EDIT_TEXT, Color.FromHex(lightColorText));
            this.light_Color_Scheme_.Add(COLOR.PROFILE_EDIT_TEXT_SECONDARY, Color.FromHex(lightColorTextSecondary));

            this.light_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_TEXT, Color.FromHex(lightColorText));
            this.light_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_TEXT_SECONDARY, Color.FromHex(lightColorTextSecondary));

            this.light_Color_Scheme_.Add(COLOR.CHAT_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.CHAT_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.CHAT_TEXT, Color.FromHex(lightColorText));



            //DARK 
            this.dark_Color_Scheme_.Add(COLOR.LOGIN_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.LOGIN_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.LOGIN_TEXT, Color.FromHex(darkColorText));
            this.dark_Color_Scheme_.Add(COLOR.LOGIN_TEXT_SECONDARY, Color.FromHex(darkColorTextSecondary));

            this.dark_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_TEXT, Color.FromHex(darkColorText));
            this.dark_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_TEXT_SECONDARY, Color.FromHex(darkColorTextSecondary));

            this.dark_Color_Scheme_.Add(COLOR.SETTING_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.SETTING_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.SETTING_TEXT, Color.FromHex(darkColorText));
            this.dark_Color_Scheme_.Add(COLOR.SETTING_TEXT_SECONDARY, Color.FromHex(darkColorTextSecondary));

            this.dark_Color_Scheme_.Add(COLOR.HOME_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.HOME_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.HOME_TEXT, Color.FromHex(darkColorText));
            this.dark_Color_Scheme_.Add(COLOR.HOME_TEXT_SECONDARY, Color.FromHex(darkColorTextSecondary));

            this.dark_Color_Scheme_.Add(COLOR.PROFILE_EDIT_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.PROFILE_EDIT_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.PROFILE_EDIT_TEXT, Color.FromHex(darkColorText));
            this.dark_Color_Scheme_.Add(COLOR.PROFILE_EDIT_TEXT_SECONDARY, Color.FromHex(darkColorTextSecondary));

            this.dark_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_TEXT, Color.FromHex(darkColorText));
            this.dark_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_TEXT_SECONDARY, Color.FromHex(darkColorTextSecondary));

            this.dark_Color_Scheme_.Add(COLOR.CHAT_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.CHAT_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.CHAT_TEXT, Color.FromHex(darkColorText));


            //HALLOWEEN
            this.halloween_Color_Scheme_.Add(COLOR.LOGIN_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.LOGIN_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.LOGIN_TEXT, Color.FromHex(halloweenColorText));
            this.halloween_Color_Scheme_.Add(COLOR.LOGIN_TEXT_SECONDARY, Color.FromHex(halloweenColorTextSecondary));

            this.halloween_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_TEXT, Color.FromHex(halloweenColorText));
            this.halloween_Color_Scheme_.Add(COLOR.CREATE_ACCOUNT_TEXT_SECONDARY, Color.FromHex(halloweenColorTextSecondary));

            this.halloween_Color_Scheme_.Add(COLOR.SETTING_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.SETTING_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.SETTING_TEXT, Color.FromHex(halloweenColorText));
            this.halloween_Color_Scheme_.Add(COLOR.SETTING_TEXT_SECONDARY, Color.FromHex(halloweenColorTextSecondary));

            this.halloween_Color_Scheme_.Add(COLOR.HOME_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.HOME_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.HOME_TEXT, Color.FromHex(halloweenColorText));
            this.halloween_Color_Scheme_.Add(COLOR.HOME_TEXT_SECONDARY, Color.FromHex(halloweenColorTextSecondary));

            this.halloween_Color_Scheme_.Add(COLOR.PROFILE_EDIT_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.PROFILE_EDIT_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.PROFILE_EDIT_TEXT, Color.FromHex(halloweenColorText));
            this.halloween_Color_Scheme_.Add(COLOR.PROFILE_EDIT_TEXT_SECONDARY, Color.FromHex(halloweenColorTextSecondary));

            this.halloween_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_TEXT, Color.FromHex(halloweenColorText));
            this.halloween_Color_Scheme_.Add(COLOR.VIEW_USER_PROFILE_TEXT_SECONDARY, Color.FromHex(halloweenColorTextSecondary));

            this.halloween_Color_Scheme_.Add(COLOR.CHAT_BACKGROUND, Color.FromHex(halloweenColorBackground));
            this.halloween_Color_Scheme_.Add(COLOR.CHAT_BUTTONS, Color.FromHex(halloweenColorButton));
            this.halloween_Color_Scheme_.Add(COLOR.CHAT_TEXT, Color.FromHex(halloweenColorText));
        }

        private Dictionary<COLOR, Color> light_Color_Scheme_ = new Dictionary<COLOR, Color>();
        private Dictionary<COLOR, Color> dark_Color_Scheme_ = new Dictionary<COLOR, Color>();
        private Dictionary<COLOR, Color> halloween_Color_Scheme_ = new Dictionary<COLOR, Color>();

        private bool is_Light_Selected_;
        private bool is_Dark_Selected_;
        private bool is_Halloween_Selected_;

        public Dictionary<COLOR, Color> Light_Color_Scheme_
        {
            get
            {
                return this.light_Color_Scheme_;
            }
        }

        public Dictionary<COLOR, Color> Dark_Color_Scheme_
        {
            get
            {
                return this.dark_Color_Scheme_;
            }
        }

        public Dictionary<COLOR, Color> Halloween_Color_Scheme_
        {
            get
            {
                return this.halloween_Color_Scheme_;
            }
        }

        public bool Is_Light_Selected_
        {
            get
            {
                return this.is_Light_Selected_;
            }

            set
            {
                this.SetProperty(ref this.is_Light_Selected_, value);
                this.RaisePropertyChanged("Is_Light_Selected_");
            }
        }

        public bool Is_Dark_Selected_
        {
            get
            {
                return this.is_Dark_Selected_;
            }

            set
            {
                this.SetProperty(ref this.is_Dark_Selected_, value);
                this.RaisePropertyChanged("Is_Dark_Selected_");
            }
        }

        public bool Is_Halloween_Selected_
        {
            get
            {
                return this.is_Halloween_Selected_;
            }

            set
            {
                this.SetProperty(ref this.is_Halloween_Selected_, value);
                this.RaisePropertyChanged("Is_Halloween_Selected_");
            }
        }


        //##########################################
        //##########################################
        //##########################################

        private Color login_Background_;
        private Color login_Button_;
        private Color login_Text_;
        private Color login_Text_Secondary_;

        private Color create_Account_Background_;
        private Color create_Account_Button_;
        private Color create_Account_Text_;
        private Color create_Account_Text_Secondary_;

        private Color setting_Background_;
        private Color setting_Button_;
        private Color setting_Text_;
        private Color setting_Text_Secondary_;

        private Color home_Background_;
        private Color home_Button_;
        private Color home_Text_;
        private Color home_Text_Secondary_;

        private Color profile_Edit_Background_;
        private Color profile_Edit_Button_;
        private Color profile_Edit_Text_;
        private Color profile_Edit_Text_Secondary_;

        private Color view_User_Profile_Background_;
        private Color view_User_Profile_Button_;
        private Color view_User_Profile_Text_;
        private Color view_User_Profile_Text_Secondary_;

        private Color chat_Background_;
        private Color chat_Button_;
        private Color chat_Text_;

        public Color Login_Background_
        {
            get
            {
                return this.login_Background_;
            }

            set
            {
                this.SetProperty(ref this.login_Background_, value);
                this.RaisePropertyChanged("Login_Background_");
            }
        }

        public Color Login_Button_
        {
            get
            {
                return this.login_Button_;
            }

            set
            {
                this.SetProperty(ref this.login_Button_, value);
                this.RaisePropertyChanged("Login_Button_");
            }
        }

        public Color Login_Text_
        {
            get
            {
                return this.login_Text_;
            }

            set
            {
                this.SetProperty(ref this.login_Text_, value);
                this.RaisePropertyChanged("Login_Text_");
            }
        }

        public Color Login_Text_Secondary_
        {
            get
            {
                return this.login_Text_Secondary_;
            }

            set
            {
                this.SetProperty(ref this.login_Text_Secondary_, value);
                this.RaisePropertyChanged("Login_Text_Secondary_");
            }
        }

        public Color Create_Account_Background_
        {
            get
            {
                return this.create_Account_Background_;
            }

            set
            {
                this.SetProperty(ref this.create_Account_Background_, value);
                this.RaisePropertyChanged("Create_Account_Background_");
            }
        }

        public Color Create_Account_Button_
        {
            get
            {
                return this.create_Account_Button_;
            }

            set
            {
                this.SetProperty(ref this.create_Account_Button_, value);
                this.RaisePropertyChanged("Create_Account_Button_");
            }
        }

        public Color Create_Account_Text_
        {
            get
            {
                return this.create_Account_Text_;
            }

            set
            {
                this.SetProperty(ref this.create_Account_Text_, value);
                this.RaisePropertyChanged("Create_Account_Text_");
            }
        }

        public Color Create_Account_Text_Secondary_
        {
            get
            {
                return this.create_Account_Text_Secondary_;
            }

            set
            {
                this.SetProperty(ref this.create_Account_Text_Secondary_, value);
                this.RaisePropertyChanged("Create_Account_Text_Secondary_");
            }
        }

        public Color Setting_Background_
        {
            get
            {
                return this.setting_Background_;
            }

            set
            {
                this.SetProperty(ref this.setting_Background_, value);
                this.RaisePropertyChanged("Setting_Background_");
            }
        }

        public Color Setting_Button_
        {
            get
            {
                return this.setting_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Button_, value);
                this.RaisePropertyChanged("Setting_Button_");
            }
        }

        public Color Setting_Text_
        {
            get
            {
                return this.setting_Text_;
            }

            set
            {
                this.SetProperty(ref this.setting_Text_, value);
                this.RaisePropertyChanged("Setting_Text_");
            }
        }

        public Color Setting_Text_Secondary_
        {
            get
            {
                return this.setting_Text_Secondary_;
            }

            set
            {
                this.SetProperty(ref this.setting_Text_Secondary_, value);
                this.RaisePropertyChanged("Setting_Text_Secondary_");
            }
        }

        public Color Home_Background_
        {
            get
            {
                return this.home_Background_;
            }

            set
            {
                this.SetProperty(ref this.home_Background_, value);
                this.RaisePropertyChanged("Home_Background_");
            }
        }

        public Color Home_Button_
        {
            get
            {
                return this.home_Button_;
            }

            set
            {
                this.SetProperty(ref this.home_Button_, value);
                this.RaisePropertyChanged("Home_Button_");
            }
        }

        public Color Home_Text_
        {
            get
            {
                return this.home_Text_;
            }

            set
            {
                this.SetProperty(ref this.home_Text_, value);
                this.RaisePropertyChanged("Home_Text_");
            }
        }

        public Color Home_Text_Secondary_
        {
            get
            {
                return this.home_Text_Secondary_;
            }

            set
            {
                this.SetProperty(ref this.home_Text_Secondary_, value);
                this.RaisePropertyChanged("Home_Text_Secondary_");
            }
        }

        public Color Profile_Edit_Background_
        {
            get
            {
                return this.profile_Edit_Background_;
            }

            set
            {
                this.SetProperty(ref this.profile_Edit_Background_, value);
                this.RaisePropertyChanged("Profile_Edit_Background_");
            }
        }

        public Color Profile_Edit_Button_
        {
            get
            {
                return this.profile_Edit_Button_;
            }

            set
            {
                this.SetProperty(ref this.profile_Edit_Button_, value);
                this.RaisePropertyChanged("Profile_Edit_Button_");
            }
        }

        public Color Profile_Edit_Text_
        {
            get
            {
                return this.profile_Edit_Text_;
            }

            set
            {
                this.SetProperty(ref this.profile_Edit_Text_, value);
                this.RaisePropertyChanged("Profile_Edit_Text_");
            }
        }

        public Color Profile_Edit_Text_Secondary_
        {
            get
            {
                return this.profile_Edit_Text_Secondary_;
            }

            set
            {
                this.SetProperty(ref this.profile_Edit_Text_Secondary_, value);
                this.RaisePropertyChanged("Profile_Edit_Text_Secondary_");
            }
        }

        public Color View_User_Profile_Background_
        {
            get
            {
                return this.view_User_Profile_Background_;
            }

            set
            {
                this.SetProperty(ref this.view_User_Profile_Background_, value);
                this.RaisePropertyChanged("View_User_Profile_Background_");
            }
        }

        public Color View_User_Profile_Button_
        {
            get
            {
                return this.view_User_Profile_Button_;
            }

            set
            {
                this.SetProperty(ref this.view_User_Profile_Button_, value);
                this.RaisePropertyChanged("View_User_Profile_Button_");
            }
        }

        public Color View_User_Profile_Text_
        {
            get
            {
                return this.view_User_Profile_Text_;
            }

            set
            {
                this.SetProperty(ref this.view_User_Profile_Text_, value);
                this.RaisePropertyChanged("View_User_Profile_Text_");
            }
        }

        public Color View_User_Profile_Text_Secondary_
        {
            get
            {
                return this.view_User_Profile_Text_Secondary_;
            }

            set
            {
                this.SetProperty(ref this.view_User_Profile_Text_Secondary_, value);
                this.RaisePropertyChanged("View_User_Profile_Text_Secondary_");
            }
        }

        public Color Chat_Background_
        {
            get
            {
                return this.chat_Background_;
            }

            set
            {
                this.SetProperty(ref this.chat_Background_, value);
                this.RaisePropertyChanged("Chat_Background_");
            }
        }

        public Color Chat_Button_
        {
            get
            {
                return this.chat_Button_;
            }

            set
            {
                this.SetProperty(ref this.chat_Button_, value);
                this.RaisePropertyChanged("Chat_Button_");
            }
        }

        public Color Chat_Text_
        {
            get
            {
                return this.chat_Text_;
            }

            set
            {
                this.SetProperty(ref this.chat_Text_, value);
                this.RaisePropertyChanged("Chat_Text_");
            }
        }

        //##########################################
        //##########################################
        //##########################################


        public void SetColors()
        {
            if(this.Is_Light_Selected_)
            {
                this.Login_Background_ = this.Light_Color_Scheme_[COLOR.LOGIN_BACKGROUND];
                this.Login_Button_ = this.Light_Color_Scheme_[COLOR.LOGIN_BUTTONS];
                this.Login_Text_ = this.Light_Color_Scheme_[COLOR.LOGIN_TEXT];
                this.Login_Text_Secondary_ = this.Light_Color_Scheme_[COLOR.LOGIN_TEXT_SECONDARY];

                this.Create_Account_Background_ = this.Light_Color_Scheme_[COLOR.CREATE_ACCOUNT_BACKGROUND];
                this.Create_Account_Button_ = this.Light_Color_Scheme_[COLOR.CREATE_ACCOUNT_BUTTONS];
                this.Create_Account_Text_ = this.Light_Color_Scheme_[COLOR.CREATE_ACCOUNT_TEXT];
                this.Create_Account_Text_Secondary_ = this.Light_Color_Scheme_[COLOR.CREATE_ACCOUNT_TEXT_SECONDARY];

                this.Setting_Background_ = this.Light_Color_Scheme_[COLOR.SETTING_BACKGROUND];
                this.Setting_Button_ = this.Light_Color_Scheme_[COLOR.SETTING_BUTTONS];
                this.Setting_Text_ = this.Light_Color_Scheme_[COLOR.SETTING_TEXT];
                this.Setting_Text_Secondary_ = this.Light_Color_Scheme_[COLOR.SETTING_TEXT_SECONDARY];

                this.Home_Background_ = this.Light_Color_Scheme_[COLOR.HOME_BACKGROUND];
                this.Home_Button_ = this.Light_Color_Scheme_[COLOR.HOME_BUTTONS];
                this.Home_Text_ = this.Light_Color_Scheme_[COLOR.HOME_TEXT];
                this.Home_Text_Secondary_ = this.Light_Color_Scheme_[COLOR.HOME_TEXT_SECONDARY];

                this.Profile_Edit_Background_ = this.Light_Color_Scheme_[COLOR.PROFILE_EDIT_BACKGROUND];
                this.Profile_Edit_Button_ = this.Light_Color_Scheme_[COLOR.PROFILE_EDIT_BUTTONS];
                this.Profile_Edit_Text_ = this.Light_Color_Scheme_[COLOR.PROFILE_EDIT_TEXT];
                this.Profile_Edit_Text_Secondary_ = this.Light_Color_Scheme_[COLOR.PROFILE_EDIT_TEXT_SECONDARY];

                this.View_User_Profile_Background_ = this.Light_Color_Scheme_[COLOR.VIEW_USER_PROFILE_BACKGROUND];
                this.View_User_Profile_Button_ = this.Light_Color_Scheme_[COLOR.VIEW_USER_PROFILE_BUTTONS];
                this.View_User_Profile_Text_ = this.Light_Color_Scheme_[COLOR.VIEW_USER_PROFILE_TEXT];
                this.View_User_Profile_Text_Secondary_ = this.Light_Color_Scheme_[COLOR.VIEW_USER_PROFILE_TEXT_SECONDARY];

                this.Chat_Background_ = this.Light_Color_Scheme_[COLOR.CHAT_BACKGROUND];
                this.Chat_Button_ = this.Light_Color_Scheme_[COLOR.CHAT_BUTTONS];
                this.Chat_Text_ = this.Light_Color_Scheme_[COLOR.CHAT_TEXT];
            }
            else if(this.Is_Dark_Selected_)
            {
                this.Login_Background_ = this.Dark_Color_Scheme_[COLOR.LOGIN_BACKGROUND];
                this.Login_Button_ = this.Dark_Color_Scheme_[COLOR.LOGIN_BUTTONS];
                this.Login_Text_ = this.Dark_Color_Scheme_[COLOR.LOGIN_TEXT];
                this.Login_Text_Secondary_ = this.Dark_Color_Scheme_[COLOR.LOGIN_TEXT_SECONDARY];

                this.Create_Account_Background_ = this.Dark_Color_Scheme_[COLOR.CREATE_ACCOUNT_BACKGROUND];
                this.Create_Account_Button_ = this.Dark_Color_Scheme_[COLOR.CREATE_ACCOUNT_BUTTONS];
                this.Create_Account_Text_ = this.Dark_Color_Scheme_[COLOR.CREATE_ACCOUNT_TEXT];
                this.Create_Account_Text_Secondary_ = this.Dark_Color_Scheme_[COLOR.CREATE_ACCOUNT_TEXT_SECONDARY];

                this.Setting_Background_ = this.Dark_Color_Scheme_[COLOR.SETTING_BACKGROUND];
                this.Setting_Button_ = this.Dark_Color_Scheme_[COLOR.SETTING_BUTTONS];
                this.Setting_Text_ = this.Dark_Color_Scheme_[COLOR.SETTING_TEXT];
                this.Setting_Text_Secondary_ = this.Dark_Color_Scheme_[COLOR.SETTING_TEXT_SECONDARY];

                this.Home_Background_ = this.Dark_Color_Scheme_[COLOR.HOME_BACKGROUND];
                this.Home_Button_ = this.Dark_Color_Scheme_[COLOR.HOME_BUTTONS];
                this.Home_Text_ = this.Dark_Color_Scheme_[COLOR.HOME_TEXT];
                this.Home_Text_Secondary_ = this.Dark_Color_Scheme_[COLOR.HOME_TEXT_SECONDARY];

                this.Profile_Edit_Background_ = this.Dark_Color_Scheme_[COLOR.PROFILE_EDIT_BACKGROUND];
                this.Profile_Edit_Button_ = this.Dark_Color_Scheme_[COLOR.PROFILE_EDIT_BUTTONS];
                this.Profile_Edit_Text_ = this.Dark_Color_Scheme_[COLOR.PROFILE_EDIT_TEXT];
                this.Profile_Edit_Text_Secondary_ = this.Dark_Color_Scheme_[COLOR.PROFILE_EDIT_TEXT_SECONDARY];

                this.View_User_Profile_Background_ = this.Dark_Color_Scheme_[COLOR.VIEW_USER_PROFILE_BACKGROUND];
                this.View_User_Profile_Button_ = this.Dark_Color_Scheme_[COLOR.VIEW_USER_PROFILE_BUTTONS];
                this.View_User_Profile_Text_ = this.Dark_Color_Scheme_[COLOR.VIEW_USER_PROFILE_TEXT];
                this.View_User_Profile_Text_Secondary_ = this.Dark_Color_Scheme_[COLOR.VIEW_USER_PROFILE_TEXT_SECONDARY];

                this.Chat_Background_ = this.Dark_Color_Scheme_[COLOR.CHAT_BACKGROUND];
                this.Chat_Button_ = this.Dark_Color_Scheme_[COLOR.CHAT_BUTTONS];
                this.Chat_Text_ = this.Dark_Color_Scheme_[COLOR.CHAT_TEXT];
            }
            else if (this.Is_Halloween_Selected_)
            {
                this.Login_Background_ = this.Halloween_Color_Scheme_[COLOR.LOGIN_BACKGROUND];
                this.Login_Button_ = this.Halloween_Color_Scheme_[COLOR.LOGIN_BUTTONS];
                this.Login_Text_ = this.Halloween_Color_Scheme_[COLOR.LOGIN_TEXT];
                this.Login_Text_Secondary_ = this.Halloween_Color_Scheme_[COLOR.LOGIN_TEXT_SECONDARY];

                this.Create_Account_Background_ = this.Halloween_Color_Scheme_[COLOR.CREATE_ACCOUNT_BACKGROUND];
                this.Create_Account_Button_ = this.Halloween_Color_Scheme_[COLOR.CREATE_ACCOUNT_BUTTONS];
                this.Create_Account_Text_ = this.Halloween_Color_Scheme_[COLOR.CREATE_ACCOUNT_TEXT];
                this.Create_Account_Text_Secondary_ = this.Halloween_Color_Scheme_[COLOR.CREATE_ACCOUNT_TEXT_SECONDARY];

                this.Setting_Background_ = this.Halloween_Color_Scheme_[COLOR.SETTING_BACKGROUND];
                this.Setting_Button_ = this.Halloween_Color_Scheme_[COLOR.SETTING_BUTTONS];
                this.Setting_Text_ = this.Halloween_Color_Scheme_[COLOR.SETTING_TEXT];
                this.Setting_Text_Secondary_ = this.Halloween_Color_Scheme_[COLOR.SETTING_TEXT_SECONDARY];

                this.Home_Background_ = this.Halloween_Color_Scheme_[COLOR.HOME_BACKGROUND];
                this.Home_Button_ = this.Halloween_Color_Scheme_[COLOR.HOME_BUTTONS];
                this.Home_Text_ = this.Halloween_Color_Scheme_[COLOR.HOME_TEXT];
                this.Home_Text_Secondary_ = this.Halloween_Color_Scheme_[COLOR.HOME_TEXT_SECONDARY];

                this.Profile_Edit_Background_ = this.Halloween_Color_Scheme_[COLOR.PROFILE_EDIT_BACKGROUND];
                this.Profile_Edit_Button_ = this.Halloween_Color_Scheme_[COLOR.PROFILE_EDIT_BUTTONS];
                this.Profile_Edit_Text_ = this.Halloween_Color_Scheme_[COLOR.PROFILE_EDIT_TEXT];
                this.Profile_Edit_Text_Secondary_ = this.Halloween_Color_Scheme_[COLOR.PROFILE_EDIT_TEXT_SECONDARY];

                this.View_User_Profile_Background_ = this.Halloween_Color_Scheme_[COLOR.VIEW_USER_PROFILE_BACKGROUND];
                this.View_User_Profile_Button_ = this.Halloween_Color_Scheme_[COLOR.VIEW_USER_PROFILE_BUTTONS];
                this.View_User_Profile_Text_ = this.Halloween_Color_Scheme_[COLOR.VIEW_USER_PROFILE_TEXT];
                this.View_User_Profile_Text_Secondary_ = this.Halloween_Color_Scheme_[COLOR.VIEW_USER_PROFILE_TEXT_SECONDARY];

                this.Chat_Background_ = this.Halloween_Color_Scheme_[COLOR.CHAT_BACKGROUND];
                this.Chat_Button_ = this.Halloween_Color_Scheme_[COLOR.CHAT_BUTTONS];
                this.Chat_Text_ = this.Halloween_Color_Scheme_[COLOR.CHAT_TEXT];
            }
        }
    }
}
