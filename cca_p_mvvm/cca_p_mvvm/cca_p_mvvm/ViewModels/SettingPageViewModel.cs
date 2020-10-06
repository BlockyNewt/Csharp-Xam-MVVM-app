using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cca_p_mvvm.ViewModels
{
    public class SettingPageViewModel : ViewModelBase, INavigationAware
    {
        public SettingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.SetLanguage();
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

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }


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
                this.setting_Frame_Label_ = value;
                this.OnPropertyChanged("Setting_Frame_Label_");
                this.SetProperty(ref this.setting_Frame_Label_, value);
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
                this.setting_Language_Label_ = value;
                this.OnPropertyChanged("Setting_Language_Label_");
                this.SetProperty(ref this.setting_Language_Label_, value);
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
                this.setting_Radio_ENG_Button_ = value;
                this.OnPropertyChanged("Setting_Radio_ENG_Button_");
                this.SetProperty(ref this.setting_Radio_ENG_Button_, value);
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
                this.setting_Radio_JAP_Button_ = value;
                this.OnPropertyChanged("Setting_Radio_JAP_Button_");
                this.SetProperty(ref this.setting_Radio_JAP_Button_, value);
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
                this.setting_Accept_Button_ = value;
                this.OnPropertyChanged("Setting_Accept_Button_");
                this.SetProperty(ref this.setting_Accept_Button_, value);
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
                this.setting_Close_Button_ = value;
                this.OnPropertyChanged("Setting_Close_Button_");
                this.SetProperty(ref this.setting_Close_Button_, value);
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
                this.setting_App_Info_Label_ = value;
                this.OnPropertyChanged("Setting_App_Info_Label_");
                this.SetProperty(ref this.setting_App_Info_Label_, value);
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
                this.setting_App_Version_ = value;
                this.OnPropertyChanged("Setting_App_Version_");
                this.SetProperty(ref this.setting_App_Version_, value);
            }
        }



        private DelegateCommand setting_Accept_Button_Command_;
        public DelegateCommand Setting_Accept_Button_Command_ => this.setting_Accept_Button_Command_ ?? (this.setting_Accept_Button_Command_ = new DelegateCommand(this.SettingAcceptButton));
        private void SettingAcceptButton()
        {
            //CHANGE THE CURRENT LANGUAGE FOR THE PAGE
            this.SetLanguage();
        }

        private DelegateCommand setting_Close_Button_Command_;
        public DelegateCommand Setting_Close_Button_Command_ => this.setting_Close_Button_Command_ ?? (this.setting_Close_Button_Command_ = new DelegateCommand(this.SettingCloseButton));
        private async void SettingCloseButton()
        {
            //CREATE PARAMETERS
            var p = new NavigationParameters();

            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);

            //PASS PARAMETERS
            await this.navigation_Service_.GoBackAsync(p);
        }


        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON WHICH ONE IS CURRENTLY ACTIVE
            if(this.l_Eng_.Is_English_Selected_)
            {
                this.Setting_Frame_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_FRAME_LABEL];
                this.Setting_Language_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_LANGUAGE_LABEL];
                this.Setting_Radio_ENG_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_ENG_BUTTON];
                this.Setting_Radio_JAP_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_RADIO_JAP_BUTTON];
                this.Setting_Accept_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_ACCEPT_BUTTON];
                this.Setting_Close_Button_ = this.l_Eng_.Word[ENG_WORD.SETTING_CLOSE_BUTTON];
                this.Setting_App_Info_Label_ = this.l_Eng_.Word[ENG_WORD.SETTING_APP_INFORMATION_LABEL];
                this.Setting_App_Version_ = this.l_Eng_.Word[ENG_WORD.SETTING_APP_VERSION_] + "1.0.0";
            }
            else if(this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Setting_Frame_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_FRAME_LABEL];
                this.Setting_Language_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_LANGUAGE_LABEL];
                this.Setting_Radio_ENG_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_ENG_BUTTON];
                this.Setting_Radio_JAP_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_RADIO_JAP_BUTTON];
                this.Setting_Accept_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_ACCEPT_BUTTON];
                this.Setting_Close_Button_ = this.l_Jap_.Word[JAP_WORD.SETTING_CLOSE_BUTTON];
                this.Setting_App_Info_Label_ = this.l_Jap_.Word[JAP_WORD.SETTING_APP_INFORMATION_LABEL];
                this.Setting_App_Version_ = this.l_Jap_.Word[JAP_WORD.SETTING_APP_VERSION_] + "1.0.0";
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
            this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

            this.SetLanguage();
        }
    }
}
