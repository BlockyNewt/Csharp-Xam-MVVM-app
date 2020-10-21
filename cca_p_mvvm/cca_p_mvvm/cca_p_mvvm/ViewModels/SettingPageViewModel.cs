using Android.Speech.Tts;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xamarin.Forms;

namespace cca_p_mvvm.ViewModels
{
    public class SettingPageViewModel : ViewModelBase, INavigationAware
    {
        public SettingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.is_Editing_Connection_Info_ = false;
            this.is_Not_Editing_Connection_Info_ = true;

            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.client_Connection_ = new ClientConnection();

            this.color_Scheme_ = new ColorScheme();

            //this.SetLanguage();
        }
        //NAVIGATION SERVICES 
        private readonly INavigationService navigation_Service_;

        //UI VARIABLES 
        private string setting_Frame_Label_;
        private string setting_Language_Label_;
        private string setting_Radio_ENG_Button_;
        private string setting_Radio_JAP_Button_;
        private string setting_Accept_Button_;
        private string setting_Close_Button_;
        private string setting_App_Info_Label_;
        private string setting_App_Version_;
        private string setting_Color_Design_Label_;
        private string setting_Radio_Light_Button_;
        private string setting_Radio_Dark_Button_;
        private string setting_Radio_Halloween_Button_;
        private string setting_Connection_Info_Label_;
        private string setting_Ip_;
        private string setting_Port_;
        private string setting_Ip_Language_;
        private string setting_Port_Language_;
        private string setting_Ip_Changed_Text_;
        private string setting_Port_Changed_Text_;
        private string setting_Change_Button_;
        private string setting_Confirm_Button_;
        private string setting_Cancel_Button_;
        private string setting_Error_Invalid_Format_Error_Title_;
        private string setting_Error_Invalid_Format_Error_Message_;
        private string setting_Error_Invalid_Format_Error_Button_;

        private bool is_Editing_Connection_Info_;
        private bool is_Not_Editing_Connection_Info_;

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }

        //CONNECTION TO THE SERVER
        public ClientConnection client_Connection_ { get; private set; }

        //COLOR-SCHEMES
        public ColorScheme color_Scheme_ { get; private set; }


        public string Setting_Frame_Label_
        {
            get
            {
                if (string.IsNullOrEmpty(this.setting_Frame_Label_))
                {
                    return "Empty string";
                }

                return this.setting_Frame_Label_;
            }

            set
            {
                this.SetProperty(ref this.setting_Frame_Label_, value);
                this.RaisePropertyChanged("Setting_Frame_Label_");
            }
        }

        public string Setting_Language_Label_
        {
            get
            {
                if (string.IsNullOrEmpty(this.setting_Language_Label_))
                {
                    return "Empty string";
                }

                return this.setting_Language_Label_;
            }

            set
            {
                this.SetProperty(ref this.setting_Language_Label_, value);
                this.RaisePropertyChanged("Setting_Language_Label_");
            }
        }

        public string Setting_Radio_ENG_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.setting_Radio_ENG_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Radio_ENG_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Radio_ENG_Button_, value);
                this.RaisePropertyChanged("Setting_Radio_ENG_Button_");
            }
        }

        public string Setting_Radio_JAP_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.setting_Radio_JAP_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Radio_JAP_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Radio_JAP_Button_, value);
                this.RaisePropertyChanged("Setting_Radio_JAP_Button_");
            }
        }

        public string Setting_Accept_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.setting_Accept_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Accept_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Accept_Button_, value);
                this.RaisePropertyChanged("Setting_Accept_Button_");
            }
        }

        public string Setting_Close_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.setting_Close_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Close_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Close_Button_, value);
                this.RaisePropertyChanged("Setting_Close_Button_");
            }
        }

        public string Setting_App_Info_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_App_Info_Label_))
                {
                    return "Empty string";
                }

                return setting_App_Info_Label_;
            }

            set
            {
                this.SetProperty(ref this.setting_App_Info_Label_, value);
                this.RaisePropertyChanged("Setting_App_Info_Label_");
            }
        }

        public string Setting_App_Version_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_App_Version_))
                {
                    return "Empty string";
                }

                return this.setting_App_Version_;
            }

            set
            {
                this.SetProperty(ref this.setting_App_Version_, value);
                this.RaisePropertyChanged("Setting_App_Version_");
            }
        }

        public string Setting_Color_Design_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Color_Design_Label_))
                {
                    return "Empty string";
                }

                return this.setting_Color_Design_Label_;
            }

            set
            {
                this.SetProperty(ref this.setting_Color_Design_Label_, value);
                this.RaisePropertyChanged("Setting_Color_Design_Label_");
            }
        }

        public string Setting_Radio_Light_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Radio_Light_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Radio_Light_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Radio_Light_Button_, value);
                this.RaisePropertyChanged("Setting_Radio_Light_Button_");
            }
        }

        public string Setting_Radio_Dark_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Radio_Dark_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Radio_Dark_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Radio_Dark_Button_, value);
                this.RaisePropertyChanged("Setting_Radio_Dark_Button_");
            }
        }

        public string Setting_Radio_Halloween_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Radio_Halloween_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Radio_Halloween_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Radio_Halloween_Button_, value);
                this.RaisePropertyChanged("setting_Radio_Halloween_Button_");
            }
        }

        public string Setting_Connection_Info_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Connection_Info_Label_))
                {
                    return "Empty string";
                }

                return this.setting_Connection_Info_Label_;
            }

            set
            {
                this.SetProperty(ref this.setting_Connection_Info_Label_, value);
                this.RaisePropertyChanged("Setting_Connection_Info_Label_");
            }
        }

        public string Setting_Ip_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Ip_))
                {
                    return "Empty string";
                }

                return this.Setting_Ip_Language_ + this.setting_Ip_;
            }

            set
            {
                this.SetProperty(ref this.setting_Ip_, value);
                this.RaisePropertyChanged("Setting_Ip_");
            }
        }

        public string Setting_Port_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Port_))
                {
                    return "Empty string";
                }

                return this.Setting_Port_Language_ + this.setting_Port_;
            }

            set
            {
                this.SetProperty(ref this.setting_Port_, value);
                this.RaisePropertyChanged("Setting_Port_");
            }
        }

        public string Setting_Ip_Language_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Ip_Language_))
                {
                    return "Empty string";
                }

                return this.setting_Ip_Language_;
            }

            set
            {
                this.SetProperty(ref this.setting_Ip_Language_, value);
                this.RaisePropertyChanged("Setting_Ip_Language_");
            }
        }

        public string Setting_Port_Language_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Port_Language_))
                {
                    return "Empty string";
                }

                return this.setting_Port_Language_;
            }

            set
            {
                this.SetProperty(ref this.setting_Port_Language_, value);
                this.RaisePropertyChanged("Setting_Port_Language_");
            }
        }

        public string Setting_Ip_Changed_Text_
        {
            get
            {
                return this.setting_Ip_Changed_Text_;
            }

            set
            {
                this.SetProperty(ref this.setting_Ip_Changed_Text_, value);
                this.RaisePropertyChanged("Setting_Ip_Changed_Text_");
            }
        }

        public string Setting_Port_Changed_Text_
        {
            get
            {
                return this.setting_Port_Changed_Text_;
            }

            set
            {
                this.SetProperty(ref this.setting_Port_Changed_Text_, value);
                this.RaisePropertyChanged("Setting_Port_Changed_Text_");
            }
        }

        public bool Is_Editing_Connection_Info_
        {
            get
            {
                return this.is_Editing_Connection_Info_;
            }

            set
            {
                this.SetProperty(ref this.is_Editing_Connection_Info_, value);
                this.RaisePropertyChanged("Is_Editing_Connection_Info_");
            }
        }

        public bool Is_Not_Editing_Connection_Info_
        {
            get
            {
                return this.is_Not_Editing_Connection_Info_;
            }

            set
            {
                this.SetProperty(ref this.is_Not_Editing_Connection_Info_, value);
                this.RaisePropertyChanged("Is_Not_Editing_Connection_Info_");
            }
        }

        public string Setting_Change_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Change_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Change_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Change_Button_, value);
                this.RaisePropertyChanged("Setting_Changed_Button_");
            }
        }

        public string Setting_Confirm_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Confirm_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Confirm_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Confirm_Button_, value);
                this.RaisePropertyChanged("Setting_Confirm_Button_");
            }
        }

        public string Setting_Cancel_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Cancel_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Cancel_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Cancel_Button_, value);
                this.RaisePropertyChanged("Setting_Cancel_Button_");
            }
        }

        public string Setting_Error_Invalid_Format_Error_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(setting_Error_Invalid_Format_Error_Title_))
                {
                    return "Empty string";
                }

                return this.setting_Error_Invalid_Format_Error_Title_;
            }

            set
            {
                this.SetProperty(ref this.setting_Error_Invalid_Format_Error_Title_, value);
                this.RaisePropertyChanged("Setting_Error_Invalid_Error_Title_");
            }
        }

        public string Setting_Error_Invalid_Format_Error_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Error_Invalid_Format_Error_Message_))
                {
                    return "Empty string";
                }

                return this.setting_Error_Invalid_Format_Error_Message_;
            }

            set
            {
                this.SetProperty(ref this.setting_Error_Invalid_Format_Error_Message_, value);
                this.RaisePropertyChanged("Setting_Error_Invalid_Error_Message_");
            }
        }

        public string Setting_Error_Invalid_Format_Error_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.setting_Error_Invalid_Format_Error_Button_))
                {
                    return "Empty string";
                }

                return this.setting_Error_Invalid_Format_Error_Button_;
            }

            set
            {
                this.SetProperty(ref this.setting_Error_Invalid_Format_Error_Button_, value);
                this.RaisePropertyChanged("Setting_Error_Invalid_Error_Button_");
            }
        }




        private DelegateCommand setting_Change_Button_Command_;
        public DelegateCommand Setting_Change_Button_Command_ => this.setting_Change_Button_Command_ ?? (this.setting_Change_Button_Command_ = new DelegateCommand(this.SettingChangeButton));
        private void SettingChangeButton()
        {
            this.Is_Not_Editing_Connection_Info_ = false;
            this.Is_Editing_Connection_Info_ = true;
        }

        private DelegateCommand setting_Confirm_Button_Command_;
        public DelegateCommand Setting_Confirm_Button_Command_ => this.setting_Confirm_Button_Command_ ?? (this.setting_Confirm_Button_Command_ = new DelegateCommand(this.ConfirmButton));
        private async void ConfirmButton()
        {
            if (!string.IsNullOrEmpty(this.Setting_Ip_Changed_Text_))
            {
                try
                {
                    this.client_Connection_.Local_Address_ = IPAddress.Parse(this.Setting_Ip_Changed_Text_);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                    await Application.Current.MainPage.DisplayAlert(this.Setting_Error_Invalid_Format_Error_Title_, this.Setting_Error_Invalid_Format_Error_Message_, this.Setting_Error_Invalid_Format_Error_Button_);
                }
            }

            if (!string.IsNullOrEmpty(this.Setting_Port_Changed_Text_))
            {
                try
                {
                    this.client_Connection_.Port_ = Convert.ToInt32(this.Setting_Port_Changed_Text_);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                    await Application.Current.MainPage.DisplayAlert(this.Setting_Error_Invalid_Format_Error_Title_, this.Setting_Error_Invalid_Format_Error_Message_, this.Setting_Error_Invalid_Format_Error_Button_);
                }
            }

            this.Setting_Ip_Changed_Text_ = string.Empty;
            this.Setting_Port_Changed_Text_ = string.Empty;

            this.Setting_Ip_ = this.client_Connection_.Local_Address_.ToString();
            this.Setting_Port_ = this.client_Connection_.Port_.ToString();

            Console.Write("NEW IP: " + this.client_Connection_.Local_Address_ + " NEW PORT: " + this.client_Connection_.Port_);

            this.Is_Editing_Connection_Info_ = false;
            this.Is_Not_Editing_Connection_Info_ = true;
        }

        private DelegateCommand setting_Cancel_Button_Command_;
        public DelegateCommand Setting_Cancel_Button_Command_ => this.setting_Cancel_Button_Command_ ?? (this.setting_Cancel_Button_Command_ = new DelegateCommand(this.CancelButton));
        private void CancelButton()
        {
            this.Is_Editing_Connection_Info_ = false;
            this.Is_Not_Editing_Connection_Info_ = true;
        }

        private DelegateCommand setting_Accept_Button_Command_;
        public DelegateCommand Setting_Accept_Button_Command_ => this.setting_Accept_Button_Command_ ?? (this.setting_Accept_Button_Command_ = new DelegateCommand(this.SettingAcceptButton));
        private void SettingAcceptButton()
        {
            //CHANGE THE CURRENT LANGUAGE FOR THE PAGE
            this.SetLanguage();
            this.color_Scheme_.SetColors();
        }



        private DelegateCommand setting_Close_Button_Command_;
        public DelegateCommand Setting_Close_Button_Command_ => this.setting_Close_Button_Command_ ?? (this.setting_Close_Button_Command_ = new DelegateCommand(this.SettingCloseButton));
        private async void SettingCloseButton()
        {
            //CREATE PARAMETERS
            var p = new NavigationParameters();

            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);
            p.Add("client_Connection_", this.client_Connection_);
            p.Add("color_Scheme_", this.color_Scheme_);

            //PASS PARAMETERS
            await this.navigation_Service_.GoBackAsync(p);
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
            this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;

            this.SetLanguage();

            this.color_Scheme_.SetColors();
        }



        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON WHICH ONE IS CURRENTLY ACTIVE
            if (this.l_Eng_.Is_English_Selected_)
            {
                this.Setting_Frame_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_FRAME_LABEL];
                this.Setting_Language_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_LANGUAGE_LABEL];
                this.Setting_Radio_ENG_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_ENG_BUTTON];
                this.Setting_Radio_JAP_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_JAP_BUTTON];
                this.Setting_Accept_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_ACCEPT_BUTTON];
                this.Setting_Close_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_CLOSE_BUTTON];
                this.Setting_App_Info_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_APP_INFORMATION_LABEL];
                this.Setting_App_Version_ = this.l_Eng_.Word[ENG_WORD.SETTING_APP_VERSION] + "1.0.0";
                this.Setting_Color_Design_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_COLOR_DESIGN_LABEL];
                this.Setting_Radio_Light_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_LIGHT_BUTTON];
                this.Setting_Radio_Dark_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_DARK_BUTTON];
                this.Setting_Radio_Halloween_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_HALLOWEEN_BUTTON];
                this.Setting_Connection_Info_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_CONNECTION_INFO_LABEL];
                this.Setting_Ip_Language_ = this.l_Eng_.Word[ENG_WORD.SETTING_IP_LABEL];
                this.Setting_Port_Language_ = this.l_Eng_.Word[ENG_WORD.SETTING_PORT_LABEL];
                this.Setting_Change_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_CHANGE_BUTTON];
                this.Setting_Confirm_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_CONFIRM_BUTTON];
                this.Setting_Cancel_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_CANCEL_BUTTON];
                this.Setting_Error_Invalid_Format_Error_Title_ = this.l_Eng_.Word[ENG_WORD.SETTING_INVALID_FORMAT_ERROR_TITLE];
                this.Setting_Error_Invalid_Format_Error_Message_ = this.l_Eng_.Word[ENG_WORD.SETTING_INVALID_FORMAT_ERROR_MESSAGE];
                this.Setting_Error_Invalid_Format_Error_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_INVALID_FORMAT_ERROR_BUTTON];
            }
            else if (this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Setting_Frame_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_FRAME_LABEL];
                this.Setting_Language_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_LANGUAGE_LABEL];
                this.Setting_Radio_ENG_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_ENG_BUTTON];
                this.Setting_Radio_JAP_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_JAP_BUTTON];
                this.Setting_Accept_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_ACCEPT_BUTTON];
                this.Setting_Close_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_CLOSE_BUTTON];
                this.Setting_App_Info_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_APP_INFORMATION_LABEL];
                this.Setting_App_Version_ = this.l_Jap_.Word[JAP_WORD.SETTING_APP_VERSION_] + "1.0.0";
                this.Setting_Color_Design_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_COLOR_DESIGN_LABEL];
                this.Setting_Radio_Light_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_LIGHT_BUTTON];
                this.Setting_Radio_Dark_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_DARK_BUTTON];
                this.Setting_Radio_Halloween_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_HALLOWEEN_BUTTON];
                this.Setting_Connection_Info_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_CONNECTION_INFO_LABEL];
                this.Setting_Ip_Language_ = this.l_Jap_.Word[JAP_WORD.SETTING_IP_LABEL];
                this.Setting_Port_Language_ = this.l_Jap_.Word[JAP_WORD.SETTING_PORT_LABEL];
                this.Setting_Change_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_CHANGE_BUTTON];
                this.Setting_Confirm_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_CONFIRM_BUTTON];
                this.Setting_Cancel_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_CANCEL_BUTTON];
                this.Setting_Error_Invalid_Format_Error_Title_ = this.l_Jap_.Word[JAP_WORD.SETTING_INVALID_FORMAT_ERROR_TITLE];
                this.Setting_Error_Invalid_Format_Error_Message_ = this.l_Jap_.Word[JAP_WORD.SETTING_INVALID_FORMAT_ERROR_MESSAGE];
                this.Setting_Error_Invalid_Format_Error_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_INVALID_FORMAT_ERROR_BUTTON];
            }


            this.Setting_Ip_ = this.client_Connection_.Local_Address_.ToString();
            this.Setting_Port_ = this.client_Connection_.Port_.ToString();
        }

    }
}
