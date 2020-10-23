using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cca_p_mvvm.ViewModels
{
    public class ViewUserProfilePageViewModel : ViewModelBase, INavigationAware
    {
        public ViewUserProfilePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.target_User_ = new UserViewModel();

            this.color_Scheme_ = new ColorScheme();
        }

        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //THE USER WE ARE LOOKING AT (NOT OUR PROFILE)
        public UserViewModel target_User_ { get; private set; }

        //COLOR-SCHEMES
        public ColorScheme color_Scheme_ { get; private set; }

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }


        private string view_User_Profile_Fullname_Label_;
        private string view_User_Profile_Bio_Label_;

        public string View_User_Profile_Fullname_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.view_User_Profile_Fullname_Label_))
                {
                    return "Empty string";
                }

                return this.view_User_Profile_Fullname_Label_;
            }

            set
            {
                this.SetProperty(ref this.view_User_Profile_Fullname_Label_, value);
                this.RaisePropertyChanged("View_User_Profile_Fullname_Label_");
            }
        }

        public string View_User_Profile_Bio_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.view_User_Profile_Bio_Label_))
                {
                    return "Empty string";
                }

                return this.view_User_Profile_Bio_Label_;
            }

            set
            {
                this.SetProperty(ref this.view_User_Profile_Bio_Label_, value);
                this.RaisePropertyChanged("view_User_Profile_Bio_Label_");
            }
        }


        private DelegateCommand back_Button_Command;
        public DelegateCommand Back_Button_Command => back_Button_Command ?? (this.back_Button_Command = new DelegateCommand(this.BackButton));
        private async void BackButton()
        {
            //GO BACK TO PREVIOUS PAGE
            await this.navigation_Service_.GoBackAsync();
        }



        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.Count > 0)
            {
                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.target_User_.First_Name_ = parameters.GetValue<UserViewModel>("target_User_").First_Name_;
                this.target_User_.Last_Name_ = parameters.GetValue<UserViewModel>("target_User_").Last_Name_;
                this.target_User_.Fullname_ = parameters.GetValue<UserViewModel>("target_User_").Fullname_;
                this.target_User_.Bio_ = parameters.GetValue<UserViewModel>("target_User_").Bio_;
                this.target_User_.Picture_ = parameters.GetValue<UserViewModel>("target_User_").Picture_;

                this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
                this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;
                this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;
                this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;

                this.color_Scheme_.SetColors();

                this.SetLanguage();
            }
        }




        private void SetLanguage()
        {
            //SET UI VARIABLES BASED ON THE CURRENTLY ACTIVE LANGUAGE
            if (this.l_Eng_.Is_English_Selected_)
            {
                this.View_User_Profile_Fullname_Label_ = this.l_Eng_.Word[ENG_WORD.VIEW_USER_PROFILE_FULLNAME_LABEL];
                this.View_User_Profile_Bio_Label_ = this.l_Eng_.Word[ENG_WORD.VIEW_USER_PROFILE_BIO_LABEL];
            }
            else if (this.l_Jap_.Is_Japanese_Selected_)
            {
                this.View_User_Profile_Fullname_Label_ = this.l_Jap_.Word[JAP_WORD.VIEW_USER_PROFILE_FULLNAME_LABEL];
                this.View_User_Profile_Bio_Label_ = this.l_Jap_.Word[JAP_WORD.VIEW_USER_PROFILE_BIO_LABEL];
            }
        }
    }
}
