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

            this.target_User_ = new UserViewModel();
        }
        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //THE USER WE ARE LOOKING AT (NOT OUR PROFILE)
        public UserViewModel target_User_ { get; private set; }


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
                this.target_User_.First_Name_ = parameters.GetValue<UserViewModel>("target_User_").First_Name_;
                this.target_User_.Last_Name_ = parameters.GetValue<UserViewModel>("target_User_").Last_Name_;
                this.target_User_.Picture_ = parameters.GetValue<UserViewModel>("target_User_").Picture_;
            }
        }
    }
}
