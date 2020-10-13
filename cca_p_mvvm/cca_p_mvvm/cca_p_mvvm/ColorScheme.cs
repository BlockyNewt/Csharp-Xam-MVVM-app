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

        LIGHT_LOGIN_BACKGROUND,
        LIGHT_LOGIN_BUTTONS,
        LIGHT_LOGIN_TEXT,

        LIGHT_CREATE_ACCOUNT_BACKGROUND,
        LIGHT_CREATE_ACCOUNT_BUTTONS,
        LIGHT_CREATE_ACCOUNT_TEXT,

        LIGHT_SETTING_BACKGROUND,
        LIGHT_SETTING_BUTTONS,
        LIGHT_SETTING_TEXT,

        LIGHT_HOME_BACKGROUND,
        LIGHT_HOME_BUTTONS,
        LIGHT_HOME_TEXT,

        LIGHT_PROFILE_EDIT_BACKGROUND,
        LIGHT_PROFILE_EDIT_BUTTONS,
        LIGHT_PROFILE_EDIT_TEXT,


        DARK_LOGIN_BACKGROUND,
        DARK_LOGIN_BUTTONS,
        DARK_LOGIN_TEXT,

        DARK_CREATE_ACCOUNT_BACKGROUND,
        DARK_CREATE_ACCOUNT_BUTTONS,
        DARK_CREATE_ACCOUNT_TEXT,

        DARK_SETTING_BACKGROUND,
        DARK_SETTING_BUTTONS,
        DARK_SETTING_TEXT,

        DARK_HOME_BACKGROUND,
        DARK_HOME_BUTTONS,
        DARK_HOME_TEXT,

        DARK_PROFILE_EDIT_BACKGROUND,
        DARK_PROFILE_EDIT_BUTTONS,
        DARK_PROFILE_EDIT_TEXT,
    }


    public class ColorScheme : BindableBase
    {
        public ColorScheme()
        {
            this.is_Light_Selected_ = false;
            this.is_Dark_Selected_ = true;

            string lightColorBackground = "ffffff";
            string lightColorButton = "cde8f6";
            string lightColorText = "000000";

            string darkColorBackground = "313131";
            string darkColorButton = "525252";
            string darkColorText = "ca3e47";


            //LIGHT COLORS
            this.light_Color_Scheme_.Add(COLOR.LIGHT_LOGIN_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_LOGIN_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_LOGIN_TEXT, Color.FromHex(lightColorText));

            this.light_Color_Scheme_.Add(COLOR.LIGHT_CREATE_ACCOUNT_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_CREATE_ACCOUNT_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_CREATE_ACCOUNT_TEXT, Color.FromHex(lightColorText));

            this.light_Color_Scheme_.Add(COLOR.LIGHT_SETTING_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_SETTING_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_SETTING_TEXT, Color.FromHex(lightColorText));

            this.light_Color_Scheme_.Add(COLOR.LIGHT_HOME_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_HOME_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_HOME_TEXT, Color.FromHex(lightColorText));

            this.light_Color_Scheme_.Add(COLOR.LIGHT_PROFILE_EDIT_BACKGROUND, Color.FromHex(lightColorBackground));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_PROFILE_EDIT_BUTTONS, Color.FromHex(lightColorButton));
            this.light_Color_Scheme_.Add(COLOR.LIGHT_PROFILE_EDIT_TEXT, Color.FromHex(lightColorText));

            //DARK COLORS 
            this.dark_Color_Scheme_.Add(COLOR.DARK_LOGIN_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.DARK_LOGIN_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.DARK_LOGIN_TEXT, Color.FromHex(darkColorText));

            this.dark_Color_Scheme_.Add(COLOR.DARK_CREATE_ACCOUNT_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.DARK_CREATE_ACCOUNT_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.DARK_CREATE_ACCOUNT_TEXT, Color.FromHex(darkColorText));

            this.dark_Color_Scheme_.Add(COLOR.DARK_SETTING_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.DARK_SETTING_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.DARK_SETTING_TEXT, Color.FromHex(darkColorText));

            this.dark_Color_Scheme_.Add(COLOR.DARK_HOME_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.DARK_HOME_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.DARK_HOME_TEXT, Color.FromHex(darkColorText));

            this.dark_Color_Scheme_.Add(COLOR.DARK_PROFILE_EDIT_BACKGROUND, Color.FromHex(darkColorBackground));
            this.dark_Color_Scheme_.Add(COLOR.DARK_PROFILE_EDIT_BUTTONS, Color.FromHex(darkColorButton));
            this.dark_Color_Scheme_.Add(COLOR.DARK_PROFILE_EDIT_TEXT, Color.FromHex(darkColorText));
        }
        private Dictionary<COLOR, Color> light_Color_Scheme_ = new Dictionary<COLOR, Color>();
        private Dictionary<COLOR, Color> dark_Color_Scheme_ = new Dictionary<COLOR, Color>();

        private bool is_Light_Selected_;
        private bool is_Dark_Selected_;

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



        //##########################################
        //##########################################
        //##########################################

        private Color login_Background_;
        private Color login_Button_;
        private Color login_Text_;

        private Color create_Account_Background_;
        private Color create_Account_Button_;
        private Color create_Account_Text_;

        private Color setting_Background_;
        private Color setting_Button_;
        private Color setting_Text_;

        private Color home_Background_;
        private Color home_Button_;
        private Color home_Text_;

        private Color profile_Edit_Background_;
        private Color profile_Edit_Button_;
        private Color profile_Edit_Text_;

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

        //##########################################
        //##########################################
        //##########################################


        public void SetColors()
        {
            if(this.Is_Light_Selected_)
            {
                this.Login_Background_ = this.Light_Color_Scheme_[COLOR.LIGHT_LOGIN_BACKGROUND];
                this.Login_Button_ = this.Light_Color_Scheme_[COLOR.LIGHT_LOGIN_BUTTONS];
                this.Login_Text_ = this.Light_Color_Scheme_[COLOR.LIGHT_LOGIN_TEXT];

                this.Create_Account_Background_ = this.Light_Color_Scheme_[COLOR.LIGHT_CREATE_ACCOUNT_BACKGROUND];
                this.Create_Account_Button_ = this.Light_Color_Scheme_[COLOR.LIGHT_CREATE_ACCOUNT_BUTTONS];
                this.Create_Account_Text_ = this.Light_Color_Scheme_[COLOR.LIGHT_CREATE_ACCOUNT_TEXT];

                this.Setting_Background_ = this.Light_Color_Scheme_[COLOR.LIGHT_SETTING_BACKGROUND];
                this.Setting_Button_ = this.Light_Color_Scheme_[COLOR.LIGHT_SETTING_BUTTONS];
                this.Setting_Text_ = this.Light_Color_Scheme_[COLOR.LIGHT_SETTING_TEXT];

                this.Home_Background_ = this.Light_Color_Scheme_[COLOR.LIGHT_HOME_BACKGROUND];
                this.Home_Button_ = this.Light_Color_Scheme_[COLOR.LIGHT_HOME_BUTTONS];
                this.Home_Text_ = this.Light_Color_Scheme_[COLOR.LIGHT_HOME_TEXT];

                this.Profile_Edit_Background_ = this.Light_Color_Scheme_[COLOR.LIGHT_PROFILE_EDIT_BACKGROUND];
                this.Profile_Edit_Button_ = this.Light_Color_Scheme_[COLOR.LIGHT_PROFILE_EDIT_BUTTONS];
                this.Profile_Edit_Text_ = this.Light_Color_Scheme_[COLOR.LIGHT_PROFILE_EDIT_TEXT];
            }
            else if(this.Is_Dark_Selected_)
            {
                this.Login_Background_ = this.Dark_Color_Scheme_[COLOR.DARK_LOGIN_BACKGROUND];
                this.Login_Button_ = this.Dark_Color_Scheme_[COLOR.DARK_LOGIN_BUTTONS];
                this.Login_Text_ = this.Dark_Color_Scheme_[COLOR.DARK_LOGIN_TEXT];

                this.Create_Account_Background_ = this.Dark_Color_Scheme_[COLOR.DARK_CREATE_ACCOUNT_BACKGROUND];
                this.Create_Account_Button_ = this.Dark_Color_Scheme_[COLOR.DARK_CREATE_ACCOUNT_BUTTONS];
                this.Create_Account_Text_ = this.Dark_Color_Scheme_[COLOR.DARK_CREATE_ACCOUNT_TEXT];

                this.Setting_Background_ = this.Dark_Color_Scheme_[COLOR.DARK_SETTING_BACKGROUND];
                this.Setting_Button_ = this.Dark_Color_Scheme_[COLOR.DARK_SETTING_BUTTONS];
                this.Setting_Text_ = this.Dark_Color_Scheme_[COLOR.DARK_SETTING_TEXT];

                this.Home_Background_ = this.Dark_Color_Scheme_[COLOR.DARK_HOME_BACKGROUND];
                this.Home_Button_ = this.Dark_Color_Scheme_[COLOR.DARK_HOME_BUTTONS];
                this.Home_Text_ = this.Dark_Color_Scheme_[COLOR.DARK_HOME_TEXT];

                this.Profile_Edit_Background_ = this.Dark_Color_Scheme_[COLOR.DARK_PROFILE_EDIT_BACKGROUND];
                this.Profile_Edit_Button_ = this.Dark_Color_Scheme_[COLOR.DARK_PROFILE_EDIT_BUTTONS];
                this.Profile_Edit_Text_ = this.Dark_Color_Scheme_[COLOR.DARK_PROFILE_EDIT_TEXT];
            }
        }
    }
}
