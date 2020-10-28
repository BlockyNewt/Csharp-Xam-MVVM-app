using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace cca_p_mvvm.ViewModels
{
    public class HomePageViewModel : ViewModelBase, INavigationAware
    {
        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.u_View_Model_ = new UserViewModel();

            this.channel_Display_ = true;
            this.dm_Display_ = false;
            this.users_Display_ = false;
            this.profile_Display_ = false;

            this.user_ = new UserViewModel();

            this.channel_ = new ObservableCollection<Channel>();
            this.user_Messages_ = new ObservableCollection<UserViewModel>();
            this.user_List_ = new ObservableCollection<UserViewModel>();

            this.client_Connection_ = new ClientConnection();

            this.color_Scheme_ = new ColorScheme();
            
            this.SetLanguage();
        }

        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //UI VARIABLES
        private string hub_Frame_Label_;
        private string hub_Channel_Button_;
        private string hub_Profile_Button_;
        private string hub_Profile_Edit_Button_;
        private string hub_Profile_Logout_Button_;
        private string hub_Profile_Fullname_Label_;
        private string hub_Profile_Bio_Label_;
        private string hub_Profile_Bio_Placeholder_;
        private string hub_Channel_Event_Enter_;
        private string hub_Channel_Event_Cancel_;
        private string hub_DM_Event_Chat_;
        private string hub_DM_Button_;
        private string hub_DM_Event_Profile_;
        private string hub_DM_Event_Delete_;
        private string hub_DM_Event_Cancel_;
        private string hub_Users_Label_;
        private string hub_Users_Event_Add_;
        private string hub_Users_Event_Profile_;
        private string hub_Users_Event_Button_;

        private bool channel_Display_;
        private bool dm_Display_;
        private bool profile_Display_;
        private bool users_Display_;

        private IList<Channel> channel_;
        private IList<UserViewModel> user_Messages_;
        private IList<UserViewModel> user_List_;

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }

        //LOGGED IN USER ON THE CLIENT
        public UserViewModel u_View_Model_ { get; private set; }

        //LOGGED IN USER
        public UserViewModel user_ { get; private set; }
        public ClientConnection client_Connection_ { get; private set; }

        //COLOR-SCHEMES
        public ColorScheme color_Scheme_ { get; private set; }


        public string Hub_Frame_Label_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Frame_Label_))
                {
                    return "Empty string";
                }

                return this.hub_Frame_Label_;
            }

            set
            {
                this.SetProperty(ref this.hub_Frame_Label_, value);
                this.RaisePropertyChanged("Hub_Frame_Label_");
            }
        }

        public string Hub_Channel_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Channel_Button_))
                {
                    return "Empty string";
                }

                return this.hub_Channel_Button_;
            }

            set
            {
                this.SetProperty(ref this.hub_Channel_Button_, value);
                this.RaisePropertyChanged("Hub_Channel_Button_");
            }
        }

        public string Hub_DM_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_DM_Button_))
                {
                    return "Empty string";
                }

                return this.hub_DM_Button_;
            }

            set
            {
                this.SetProperty(ref this.hub_DM_Button_, value);
                this.RaisePropertyChanged("Hub_DM_Button_");
            }
        }

        public string Hub_Profile_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Profile_Button_))
                {
                    return "Empty string";
                }

                return this.hub_Profile_Button_;
            }

            set
            {
                this.SetProperty(ref this.hub_Profile_Button_, value);
                this.RaisePropertyChanged("Hub_Profile_Button_");
            }
        }

        public string Hub_Profile_Edit_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Profile_Edit_Button_))
                {
                    return "Empty string";
                }

                return this.hub_Profile_Edit_Button_;
            }

            set
            {
                this.SetProperty(ref this.hub_Profile_Edit_Button_, value);
                this.RaisePropertyChanged("Hub_Profile_Edit_Button_");
            }
        }

        public string Hub_Profile_Logout_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Profile_Edit_Button_))
                {
                    return "Empty string";
                }

                return this.hub_Profile_Logout_Button_;
            }

            set
            {
                this.SetProperty(ref this.hub_Profile_Logout_Button_, value);
                this.RaisePropertyChanged("Hub_Profile_Logout_Button_");
            }
        }

        public string Hub_Profile_Fullname_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Profile_Fullname_Label_))
                {
                    return "Empty string";
                }

                return this.hub_Profile_Fullname_Label_;
            }

            set
            {
                this.SetProperty(ref this.hub_Profile_Fullname_Label_, value);
                this.RaisePropertyChanged("Hub_Profile_Fullname_Label_");
            }
        }

        public string Hub_Profile_Bio_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Profile_Bio_Label_))
                {
                    return "Empty string";
                }

                return this.hub_Profile_Bio_Label_;
            }

            set
            {
                this.SetProperty(ref this.hub_Profile_Bio_Label_, value);
                this.RaisePropertyChanged("Hub_Profile_Bio_Label_");
            }
        }

        public string Hub_Profile_Bio_Placeholder_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Profile_Bio_Placeholder_))
                {
                    return "Empty string";
                }

                return this.hub_Profile_Bio_Placeholder_;
            }

            set
            {
                this.SetProperty(ref this.hub_Profile_Bio_Placeholder_, value);
                this.RaisePropertyChanged("Hub_Profile_Bio_Placeholder_");
            }
        }

        public string Hub_DM_Event_Chat_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_DM_Event_Chat_))
                {
                    return "Empty string";
                }

                return this.hub_DM_Event_Chat_;
            }

            set
            {
                this.SetProperty(ref this.hub_DM_Event_Chat_, value);
                this.RaisePropertyChanged("Hub_DM_Event_Chat_");
            }
        }

        public string Hub_DM_Event_Profile_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_DM_Event_Profile_))
                {
                    return "Empty string";
                }

                return this.hub_DM_Event_Profile_;
            }

            set
            {
                this.SetProperty(ref this.hub_DM_Event_Profile_, value);
                this.RaisePropertyChanged("Hub_DM_Event_Profile_");
            }
        }

        public string Hub_DM_Event_Delete_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_DM_Event_Delete_))
                {
                    return "Empty string";
                }

                return this.hub_DM_Event_Delete_;
            }

            set
            {
                this.SetProperty(ref this.hub_DM_Event_Delete_, value);
                this.RaisePropertyChanged("Hub_DM_Event_Delete_");
            }
        }

        public string Hub_DM_Event_Cancel_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_DM_Event_Cancel_))
                {
                    return "Empty string";
                }

                return this.hub_DM_Event_Cancel_;
            }

            set
            {
                this.SetProperty(ref this.hub_DM_Event_Cancel_, value);
                this.RaisePropertyChanged("Hub_DM_Event_Cancel_");
            }
        }

        public string Hub_Channel_Event_Enter_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Channel_Event_Enter_))
                {
                    return "Empty string";
                }

                return this.hub_Channel_Event_Enter_;
            }

            set
            {
                this.SetProperty(ref this.hub_Channel_Event_Enter_, value);
                this.RaisePropertyChanged("Hub_Channel_Event_Enter_");
            }
        }

        public string Hub_Channel_Event_Cancel_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Channel_Event_Cancel_))
                {
                    return "Empty string";
                }

                return this.hub_Channel_Event_Cancel_;
            }

            set
            {
                this.SetProperty(ref this.hub_Channel_Event_Cancel_, value);
                this.RaisePropertyChanged("Hub_Channel_Event_Cancel_");
            }
        }

        public string Hub_Users_Label_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Users_Label_))
                {
                    return "Empty string";
                }

                return this.hub_Users_Label_;
            }

            set
            {
                this.SetProperty(ref this.hub_Users_Label_, value);
                this.RaisePropertyChanged("Hub_Users_Label_");
            }
        }

        public string Hub_Users_Event_Add_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Users_Event_Add_))
                {
                    return "Empty string";
                }

                return this.hub_Users_Event_Add_;
            }

            set
            {
                this.SetProperty(ref this.hub_Users_Event_Add_, value);
                this.RaisePropertyChanged("Hub_Users_Event_Add_");
            }
        }

        public string Hub_Users_Event_Profile_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Users_Event_Profile_))
                {
                    return "Empty string";
                }

                return this.hub_Users_Event_Profile_;
            }

            set
            {
                this.SetProperty(ref this.hub_Users_Event_Profile_, value);
                this.RaisePropertyChanged("Hub_Users_Event_Profile_");
            }
        }

        public string Hub_Users_Event_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.hub_Users_Event_Button_))
                {
                    return "Empty string";
                }

                return this.hub_Users_Event_Button_;
            }

            set
            {
                this.SetProperty(ref this.hub_Users_Event_Button_, value);
                this.RaisePropertyChanged("Hub_Users_Event_Button_");
            }
        }

        public bool Channel_Display_
        {
            get
            {
                return this.channel_Display_;
            }

            set
            {
                this.SetProperty(ref this.channel_Display_, value);
                this.RaisePropertyChanged("Channel_Display_");
            }
        }

        public bool DM_Display_
        {
            get
            {
                return this.dm_Display_;
            }

            set
            {
                this.SetProperty(ref this.dm_Display_, value);
                this.RaisePropertyChanged("DM_Display_");
            }
        }

        public bool Profile_Display_
        {
            get
            {
                return this.profile_Display_;
            }

            set
            {
                this.SetProperty(ref this.profile_Display_, value);
                this.RaisePropertyChanged("Profile_Display_");
            }
        }

        public bool Users_Display_
        {
            get
            {
                return this.users_Display_;
            }

            set
            {
                this.SetProperty(ref this.users_Display_, value);
                this.RaisePropertyChanged("Users_Display_");
            }
        }



        public IList<Channel> Channel_
        {
            get
            {
                return this.channel_;
            }
        }

        public IList<UserViewModel> User_Messages_
        {
            get
            {
                return this.user_Messages_;
            }

            set
            {
                this.SetProperty(ref this.user_Messages_, value);
                this.RaisePropertyChanged("User_Messages_");
            }
        }
        
        public IList<UserViewModel> User_List_
        {
            get
            {
                return this.user_List_;
            }

            set
            {
                this.SetProperty(ref this.user_List_, value);
                this.RaisePropertyChanged("User_List_");
            }
        }

        private void GetChannels()
        {
            //MAKE A STRING THAT WILL GATHER ALL THE CHANNELS INFORMATION FROM THE SERVER
            string[] allChannels = this.client_Connection_.GetChannels();

            for(int i = 0; i < allChannels.Length - 1; ++i)
            {
                //SEPERATE EACH CHANNEL SO WE CAN GET THEM INDIVIDUALLY
                string seperatingChannels = allChannels[i];
                string[] getChannelInfo = seperatingChannels.Split(',');

                //SET THE DATA FOR THE CHANNEL
                Channel channel = new Channel();
                channel.Text_Color_ = this.color_Scheme_.Home_Text_;
                channel.ID_ = Convert.ToInt32(getChannelInfo[0]);
                channel.Name_ = getChannelInfo[1];

                //ADD INTO LIST
                this.Channel_.Add(channel);
            }
        }

        private void GetUserChats()
        {
            //MAKE A STRING ARRAY THAT WILL GATHER ALL THE USERS INFORMATION FROM THE SERVER
            string[] allUsers = this.client_Connection_.GetAllChats(this.user_.ID_);

            Console.WriteLine("A");
            if(allUsers != null)
            {
                Console.WriteLine("B");

                for (int i = 0; i < allUsers.Length - 1; ++i)
                {
                    //SEPERATE EACH USER SO WE CAN GET THEM INDIVIDUALLY
                    string seperatingUsers = allUsers[i];
                    string[] getUserInfo = seperatingUsers.Split(',');

                    //IF A USER ID WE PULL FROM THE SERVER IS THE SAME AS THE CURRENTLY LOGGED IN USER IT WILL NOT ADD IT TO THE LIST
                    if (Convert.ToInt32(getUserInfo[0]) != this.user_.ID_)
                    {
                        //SET DATA FOR THE USER
                        UserViewModel user = new UserViewModel();
                        user.Text_Color_ = this.color_Scheme_.Home_Text_;
                        user.ID_ = Convert.ToInt32(getUserInfo[0]);
                        user.First_Name_ = getUserInfo[1];
                        user.Last_Name_ = getUserInfo[2];
                        user.Fullname_ = user.First_Name_ + " " + user.Last_Name_;
                        user.Bio_ = getUserInfo[3];
                        user.Picture_ = getUserInfo[4];

                        Console.WriteLine("ID: " + user.ID_ + " Fullname: " + user.Fullname_ + " Bio: " + user.Bio_ + " Picture:" + user.Picture_);

                        //ADD IT INTO THE LIST
                        this.User_Messages_.Add(user);
                        //this.User_List_.Add(user);
                    }
                }
                Console.WriteLine("C");

            }
        }

        private void GetUsers()
        {
            //MAKE A STRING ARRAY THAT WILL GATHER ALL THE USERS INFORMATION FROM THE SERVER
            string[] allUsers = this.client_Connection_.GetAllUsers();

            for (int i = 0; i < allUsers.Length - 1; ++i)
            {
                //SEPERATE EACH USER SO WE CAN GET THEM INDIVIDUALLY
                string seperatingUsers = allUsers[i];
                string[] getUserInfo = seperatingUsers.Split(',');

                //IF A USER ID WE PULL FROM THE SERVER IS THE SAME AS THE CURRENTLY LOGGED IN USER IT WILL NOT ADD IT TO THE LIST
                if (Convert.ToInt32(getUserInfo[0]) != this.user_.ID_)
                {
                    //SET DATA FOR THE USER
                    UserViewModel user = new UserViewModel();
                    user.Text_Color_ = this.color_Scheme_.Home_Text_;
                    user.ID_ = Convert.ToInt32(getUserInfo[0]);
                    user.First_Name_ = getUserInfo[1];
                    user.Last_Name_ = getUserInfo[2];
                    user.Fullname_ = user.First_Name_ + " " + user.Last_Name_;
                    user.Bio_ = getUserInfo[3];
                    user.Picture_ = getUserInfo[4];

                    Console.WriteLine("ID: " + user.ID_ + " Fullname: " + user.Fullname_ + " Bio: " + user.Bio_ + " Picture:" + user.Picture_);

                    //ADD IT INTO THE LIST
                    //this.User_Messages_.Add(user);
                    this.User_List_.Add(user);
                }
            }
        }



        private Channel selected_Channel_ { get; set; }
        public Channel Selected_Channel_
        {
            get
            {
                return this.selected_Channel_;
            }

            set
            {
                if (this.selected_Channel_ != value)
                {
                    this.selected_Channel_ = value;
                    this.HandleChannelSelectedItem();
                }
            }
        }
        private async void HandleChannelSelectedItem()
        {
            //WHEN A CHANNEL IS CLICKED IT WILL DISPLAY AN ACTION SHEET GIVING YOU OPTIONS ON WHAT YOU CAN DO
            string action = await Application.Current.MainPage.DisplayActionSheet(this.selected_Channel_.Name_, this.Hub_Channel_Event_Cancel_, null, this.Hub_Channel_Event_Enter_);

            //IF YOU CLICK THE ENTER ACTION THEN GO INTO A CHAT ROOM
            if (action == this.Hub_Channel_Event_Enter_)
            {
                //CREATE PARAMETERS
                var p = new NavigationParameters();

                p.Add("user_", this.user_);
                p.Add("l_Eng_", this.l_Eng_);
                p.Add("l_Jap_", this.l_Jap_);
                p.Add("client_Connection_", this.client_Connection_);
                p.Add("channel_", this.Selected_Channel_);
                p.Add("color_Scheme_", this.color_Scheme_);

                //PASS PARAMETERS
                await this.navigation_Service_.NavigateAsync("ChatPage", p);
            }
        }



        private UserViewModel selected_Messages_ { get; set; }
        public UserViewModel Selected_Messages_
        {
            get
            {
                return this.selected_Messages_;
            }

            set
            {
                if (this.selected_Messages_ != value)
                {
                    this.selected_Messages_ = value;
                    this.HandleDirectMessageSelectedItem();
                }
            }
        }
        private async void HandleDirectMessageSelectedItem()
        {
            //WHEN A DM IS CLICKED IT WILL DISPLAY AN ACTION SHEET GIVING YOU OPTIONS ON WHAT TO DO
            string action = await Application.Current.MainPage.DisplayActionSheet(this.selected_Messages_.First_Name_, this.Hub_DM_Event_Cancel_, null, this.Hub_DM_Event_Chat_, this.Hub_DM_Event_Profile_, this.Hub_DM_Event_Delete_);

            //IF YOU CLICK THE CHAT ACTION, YOU WILL THEN BE BROUGHT TO A CHAT PAGE WITH THE CURRENTLY SELECTED USER
            if (action == this.Hub_DM_Event_Chat_)
            {
                //CREATE PARAMETERS
                var p = new NavigationParameters();

                p.Add("user_", this.user_);
                p.Add("l_Eng_", this.l_Eng_);
                p.Add("l_Jap_", this.l_Jap_);
                p.Add("client_Connection_", this.client_Connection_);
                p.Add("target_User_", this.selected_Messages_);
                p.Add("color_Scheme_", this.color_Scheme_);

                //PASS PARAMETERS
                await this.navigation_Service_.NavigateAsync("ChatPage", p);
            }
            //IF YOU CLICK THE VIEW PROFILE ACTION, THEN IT WILL VIEW THE CURRENTLY SELECTED PROFILE 
            else if (action == this.Hub_DM_Event_Profile_)
            {
                //CREATE PARAMETERS
                var p = new NavigationParameters();

                p.Add("target_User_", this.selected_Messages_);
                p.Add("l_Eng_", this.l_Eng_);
                p.Add("l_Jap_", this.l_Jap_);
                p.Add("color_Scheme_", this.color_Scheme_);

                //PASS PARAMETERS
                await this.navigation_Service_.NavigateAsync("ViewUserProfilePage", p);
            }
            //IF YOU CLICKED THE DELETE ACTION, THEN IT WILL DELETE THE CURRENTLY SELECTED USER
            else if (action == this.Hub_DM_Event_Delete_)
            {
                //REMOVE CURRENTLY SELECTED USER FROM THE LIST
                this.User_Messages_.Remove(this.selected_Messages_);
                this.client_Connection_.RemoveChat(this.selected_Messages_.ID_);
            }
        }



        private UserViewModel selected_User_ { get; set; }
        public UserViewModel Selected_User_
        {
            get
            {
                return this.selected_User_;
            }

            set
            {
                if(this.selected_User_ != value)
                {
                    this.selected_User_ = value;
                    this.HandleUserSelectedItem();
                }
            }
        }
        private async void HandleUserSelectedItem()
        {
            //WHEN A DM IS CLICKED IT WILL DISPLAY AN ACTION SHEET GIVING YOU OPTIONS ON WHAT TO DO
            string action = await Application.Current.MainPage.DisplayActionSheet(this.Selected_User_.First_Name_, this.Hub_Users_Event_Button_, null, this.Hub_Users_Event_Add_, this.Hub_Users_Event_Profile_);

            if(action == this.Hub_Users_Event_Add_)
            {
                this.client_Connection_.AddNewChat(this.user_.ID_, this.Selected_User_);
                this.User_Messages_.Add(this.Selected_User_);
            }
            else if(action == this.Hub_Users_Event_Profile_)
            {
                //CREATE PARAMETERS
                var p = new NavigationParameters();

                p.Add("target_User_", this.selected_User_);
                p.Add("l_Eng_", this.l_Eng_);
                p.Add("l_Jap_", this.l_Jap_);
                p.Add("color_Scheme_", this.color_Scheme_);

                //PASS PARAMETERS
                await this.navigation_Service_.NavigateAsync("ViewUserProfilePage", p);
            }
        }



        private DelegateCommand channel_Button_Command_;
        public DelegateCommand Channel_Button_Command_ => this.channel_Button_Command_ ?? (this.channel_Button_Command_ = new DelegateCommand(this.ChannelButton));
        private void ChannelButton()
        {
            //IF CLICKED IT WILL DISPLAY CHANNELS 
            if (!this.Channel_Display_)
            {
                this.DM_Display_ = false;
                this.Profile_Display_ = false;
                this.Users_Display_ = false;
                this.Channel_Display_ = true;
            }
        }



        private DelegateCommand dm_Button_Command_;
        public DelegateCommand DM_Button_Command_ => this.dm_Button_Command_ ?? (this.dm_Button_Command_ = new DelegateCommand(this.DMButton));
        private void DMButton()
        {
            //IF CLICKED IT WILL DISPLAY MESSAGES
            if (!this.DM_Display_)
            {
                this.Channel_Display_ = false;
                this.Profile_Display_ = false;
                this.Users_Display_ = false;
                this.DM_Display_ = true;

            }
        }



        private DelegateCommand profile_Button_Command_;
        public DelegateCommand Profile_Button_Command_ => this.profile_Button_Command_ ?? (this.profile_Button_Command_ = new DelegateCommand(this.ProfileButton));
        private void ProfileButton()
        {
            //IF CLICKED IT WILL DISPLAY PROFILE
            if (!this.Profile_Display_)
            {
                this.Channel_Display_ = false;
                this.DM_Display_ = false;
                this.Users_Display_ = false;
                this.Profile_Display_ = true;
            }
        }



        private DelegateCommand users_Button_Command_;
        public DelegateCommand Users_Button_Command_ => this.users_Button_Command_ ?? (this.users_Button_Command_ = new DelegateCommand(this.UsersButton));
        private void UsersButton()
        {
            if(!this.Users_Display_)
            {
                this.Channel_Display_ = false;
                this.DM_Display_ = false;
                this.Profile_Display_ = false;
                this.Users_Display_ = true;
            }
        }



        private DelegateCommand setting_Button_Command_;
        public DelegateCommand Setting_Button_Command_ => this.setting_Button_Command_ ?? (this.setting_Button_Command_ = new DelegateCommand(this.SettingButton));
        private async void SettingButton()
        {
            //CREATE PARAMETERS
            var p = new NavigationParameters();

            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);
            p.Add("client_Connection_", this.client_Connection_);
            p.Add("color_Scheme_", this.color_Scheme_);
            //p.Add("Channel_", this.Channel_);

            //PASS PARAMETERS
            await this.navigation_Service_.NavigateAsync("SettingPage", p);
        }


        private DelegateCommand logout_Button_Command_;
        public DelegateCommand Logout_Button_Command_ => this.logout_Button_Command_ ?? (this.logout_Button_Command_ = new DelegateCommand(this.LogoutButton));
        private void LogoutButton()
        {
            this.ProfileLogoutButton();
        }

        private DelegateCommand profile_Edit_Button_Command_;
        public DelegateCommand Profile_Edit_Button_Command_ => this.profile_Edit_Button_Command_ ?? (this.profile_Edit_Button_Command_ = new DelegateCommand(this.ProfileEditButton));
        private void ProfileEditButton()
        {
            //CREATE PARAMETERS
            var p = new NavigationParameters();

            p.Add("user_", this.user_);
            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);
            p.Add("client_Connection_", this.client_Connection_);
            p.Add("color_Scheme_", this.color_Scheme_);

            //PASS PARAMETERS
            this.navigation_Service_.NavigateAsync("ProfileEditPage", p);
        }



        private DelegateCommand profile_Logout_Button_Command_;
        public DelegateCommand Profile_Logout_Button_Command_ => this.profile_Logout_Button_Command_ ?? (this.profile_Logout_Button_Command_ = new DelegateCommand(this.ProfileLogoutButton));
        private async void ProfileLogoutButton()
        {
            //CREATE PARAMETERS
            var p = new NavigationParameters();

            p.Add("l_Eng_", this.l_Eng_);
            p.Add("l_Jap_", this.l_Jap_);
            p.Add("color_Scheme_", this.color_Scheme_);

            //IF I ADD A SHOW LOGIN FUNCTION, THEN THIS WOULD BE THE PLACE TO SET THE VALUE IN THE DATABASE TO LOGGED OFF

            if(this.client_Connection_.ChangeUserLoggedValue(this.user_.ID_, 0))
            {
                //CLOSE CURRENT CONNECTION
                this.client_Connection_.CloseAllConnections();
                
                //PASS PARAMETERS 
                await this.navigation_Service_.GoBackAsync(p);
            }
        }

        private DelegateCommand edit_Profile_Button_Command_;
        public DelegateCommand Edit_Profile_Button_Command_ => this.edit_Profile_Button_Command_ ?? (this.edit_Profile_Button_Command_ = new DelegateCommand(this.EditProfileButton));
        private void EditProfileButton()
        {
            ProfileEditButton();
        }


        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //COMING FROM LOGIN PAGE
            if(parameters.Count == 5)
            {
                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.user_.ID_ = parameters.GetValue<UserViewModel>("user_").ID_;
                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Fullname_ = parameters.GetValue<UserViewModel>("user_").Fullname_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;
                this.user_.Bio_ = parameters.GetValue<UserViewModel>("user_").Bio_;
                this.user_.Picture_ = parameters.GetValue<UserViewModel>("user_").Picture_;

                this.client_Connection_ = parameters.GetValue<ClientConnection>("client_Connection_");
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;
                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;

                this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
                this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;
                this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;
                this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;

                this.client_Connection_.CheckConnection();

                this.color_Scheme_.SetColors();
                this.GetChannels();
                this.GetUsers();
                this.GetUserChats();
            }
            //COMING FROM SETTINGS
            if (parameters.Count == 4)
            {
                Console.WriteLine("SHOULD BE RUNNING THIS BITCH");
                this.l_Eng_.Is_English_Selected_ = parameters.GetValue<LanguageEnglish>("l_Eng_").Is_English_Selected_;
                this.l_Jap_.Is_Japanese_Selected_ = parameters.GetValue<LanguageJapanese>("l_Jap_").Is_Japanese_Selected_;

                this.client_Connection_.Local_Address_ = parameters.GetValue<ClientConnection>("client_Connection_").Local_Address_;
                this.client_Connection_.Port_ = parameters.GetValue<ClientConnection>("client_Connection_").Port_;

                this.color_Scheme_.Is_Light_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Light_Selected_;
                this.color_Scheme_.Is_Dark_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Dark_Selected_;
                this.color_Scheme_.Is_Halloween_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Halloween_Selected_;
                this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;

                this.color_Scheme_.SetColors();

                for (int i = 0; i < this.Channel_.Count; ++i)
                {
                    this.Channel_[i].Text_Color_ = this.color_Scheme_.Home_Text_;
                }

                for (int i = 0; i < this.User_Messages_.Count; ++i)
                {
                    this.User_Messages_[i].Text_Color_ = this.color_Scheme_.Home_Text_;
                }
            }
            //COMING FROM PROFILE EDIT
            if (parameters.Count == 1)
            {
                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Fullname_ = parameters.GetValue<UserViewModel>("user_").Fullname_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;
                this.user_.Bio_ = parameters.GetValue<UserViewModel>("user_").Bio_;
                this.user_.Picture_ = parameters.GetValue<UserViewModel>("user_").Picture_;
            }

            this.SetLanguage();
        }



        private void SetLanguage()
        {
            //SET UI VARIABLES BASED ON THE CURRENTLY ACTIVE LANGUAGE
            if (this.l_Eng_.Is_English_Selected_)
            {
                this.Hub_Frame_Label_ = this.l_Eng_.Word[ENG_WORD.HUB_FRAME_LABEL];
                this.Hub_Channel_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_BUTTON];
                this.Hub_Profile_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_BUTTON];
                this.Hub_Profile_Edit_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_EDIT_BUTTON];
                this.Hub_Profile_Logout_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_LOGOUT_BUTTON];
                this.Hub_Profile_Fullname_Label_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_FULLNAME_LABEL];
                this.Hub_Profile_Bio_Label_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_BIO_LABEL];
                this.Hub_Channel_Event_Enter_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_EVENT_ENTER];
                this.Hub_Channel_Event_Cancel_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_EVENT_CANCEL];
                this.Hub_DM_Event_Chat_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_CHAT];
                this.Hub_DM_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_BUTTON];
                this.Hub_DM_Event_Profile_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_PROFILE];
                this.Hub_DM_Event_Delete_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_DELETE];
                this.Hub_DM_Event_Cancel_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_CANCEL];
                this.Hub_Users_Label_ = this.l_Eng_.Word[ENG_WORD.HUB_USER_LABEL];
                this.Hub_Users_Event_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_USER_EVENT_BUTTON];
                this.Hub_Users_Event_Add_ = this.l_Eng_.Word[ENG_WORD.HUB_USER_EVENT_ADD];
                this.Hub_Users_Event_Profile_ = this.l_Eng_.Word[ENG_WORD.HUB_USER_EVENT_VIEW_PROFILE];
            }
            else if (this.l_Jap_.Is_Japanese_Selected_)
            {
                this.Hub_Frame_Label_ = this.l_Jap_.Word[JAP_WORD.HUB_FRAME_LABEL];
                this.Hub_Channel_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_BUTTON];
                this.Hub_Profile_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_BUTTON];
                this.Hub_Profile_Edit_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_EDIT_BUTTON];
                this.Hub_Profile_Logout_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_LOGOUT_BUTTON];
                this.Hub_Profile_Fullname_Label_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_FULLNAME_LABEL];
                this.Hub_Profile_Bio_Label_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_BIO_LABEL];
                this.Hub_Channel_Event_Enter_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_EVENT_ENTER];
                this.Hub_Channel_Event_Cancel_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_EVENT_CANCEL];
                this.Hub_DM_Event_Chat_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_CHAT];
                this.Hub_DM_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_BUTTON];
                this.Hub_DM_Event_Profile_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_PROFILE];
                this.Hub_DM_Event_Delete_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_DELETE];
                this.Hub_DM_Event_Cancel_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_CANCEL];
                this.Hub_Users_Label_ = this.l_Jap_.Word[JAP_WORD.HUB_USER_LABEL];
                this.Hub_Users_Event_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_USER_EVENT_BUTTON];
                this.Hub_Users_Event_Add_ = this.l_Jap_.Word[JAP_WORD.HUB_USER_EVENT_ADD];
                this.Hub_Users_Event_Profile_ = this.l_Jap_.Word[JAP_WORD.HUB_USER_EVENT_VIEW_PROFILE];
            }
        }

    }
}
