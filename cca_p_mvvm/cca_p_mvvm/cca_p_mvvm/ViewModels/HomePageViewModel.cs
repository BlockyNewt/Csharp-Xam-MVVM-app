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
            this.profile_Display_ = false;

            this.english_Selected_ = true;
            this.japanese_Selected_ = false;

            this.user_ = new UserViewModel();

            this.channel_ = new ObservableCollection<Channel>();
            this.GetChannels();


            this.direct_Message_ = new ObservableCollection<DirectMessage>();
            this.GetDirectMessages();

            this.SetLanguage();
        }

        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //UI VARIABLES
        private string hub_Frame_Label_;
        private string hub_Channel_Button_;
        private string hub_DM_Button_;
        private string hub_Profile_Button_;
        private string hub_Channel_Label_;
        private string hub_Profile_Edit_Button_;
        private string hub_Profile_Logout_Button_;
        private string hub_Channel_Event_Enter_;
        private string hub_Channel_Event_Cancel_;
        private string hub_DM_Event_Chat_;
        private string hub_DM_Event_Profile_;
        private string hub_DM_Event_Delete_;
        private string hub_DM_Event_Cancel_;

        private bool channel_Display_;
        private bool dm_Display_;
        private bool profile_Display_;

        private bool english_Selected_;
        private bool japanese_Selected_;

        private IList<Channel> channel_;
        private IList<DirectMessage> direct_Message_;

        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }
        public UserViewModel u_View_Model_ { get; private set; }
        public UserViewModel user_ { get; private set; }

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
                this.hub_Frame_Label_ = value;
                this.OnPropertyChanged("Hub_Frame_Label_");
                this.SetProperty(ref this.hub_Frame_Label_, value);
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
                this.hub_Channel_Button_ = value;
                this.RaisePropertyChanged("Hub_Channel_Button_");
                this.SetProperty(ref this.hub_Channel_Button_, value);
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
                this.hub_DM_Button_ = value;
                this.OnPropertyChanged("Hub_DM_Button_");
                this.SetProperty(ref this.hub_DM_Button_, value);
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
                this.hub_Profile_Button_ = value;
                this.OnPropertyChanged("Hub_Profile_Button_");
                this.SetProperty(ref this.hub_Profile_Button_, value);
            }
        }

        public string Hub_Channel_Label_
        {
            get
            {
                if (string.IsNullOrEmpty(this.hub_Channel_Label_))
                {
                    return "Empty string";
                }

                return this.hub_Channel_Label_;
            }

            set
            {
                this.hub_Channel_Label_ = value;
                this.OnPropertyChanged("Hub_Channel_Label_");
                this.SetProperty(ref this.hub_Channel_Button_, value);
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
                this.hub_Profile_Edit_Button_ = value;
                this.OnPropertyChanged("Hub_Profile_Edit_Button_");
                this.SetProperty(ref this.hub_Profile_Edit_Button_, value);
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
                this.hub_Profile_Logout_Button_ = value;
                this.OnPropertyChanged("Hub_Profile_Logout_Button_");
                this.SetProperty(ref this.hub_Profile_Logout_Button_, value);
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
                this.hub_DM_Event_Chat_ = value;
                this.OnPropertyChanged("Hub_DM_Event_Chat_");
                this.SetProperty(ref this.hub_DM_Event_Chat_, value);
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
                this.hub_DM_Event_Profile_ = value;
                this.OnPropertyChanged("Hub_DM_Event_Profile_");
                this.SetProperty(ref this.hub_DM_Event_Profile_, value);
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
                this.hub_DM_Event_Delete_ = value;
                this.OnPropertyChanged("Hub_DM_Event_Delete_");
                this.SetProperty(ref this.hub_DM_Event_Delete_, value);
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
                this.hub_DM_Event_Cancel_ = value;
                this.OnPropertyChanged("Hub_DM_Event_Cancel_");
                this.SetProperty(ref this.hub_DM_Event_Cancel_, value);
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
                this.hub_Channel_Event_Enter_ = value;
                this.OnPropertyChanged("Hub_Channel_Event_Enter_");
                this.SetProperty(ref this.hub_Channel_Event_Enter_, value);
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
                this.hub_Channel_Event_Cancel_ = value;
                this.OnPropertyChanged("Hub_Channel_Event_Cancel_");
                this.SetProperty(ref this.hub_Channel_Event_Cancel_, value);
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
                this.channel_Display_ = value;
                this.OnPropertyChanged("Channel_Display_");
                this.SetProperty(ref this.channel_Display_, value);
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
                this.dm_Display_ = value;
                this.OnPropertyChanged("DM_Display_");
                this.SetProperty(ref this.dm_Display_, value);
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
                this.profile_Display_ = value;
                this.OnPropertyChanged("Profile_Display_");
                this.SetProperty(ref this.profile_Display_, value);
            }
        }

        public bool English_Selected_
        {
            get
            {
                return this.english_Selected_;
            }

            set
            {
                this.english_Selected_ = value;
                this.OnPropertyChanged("English_Selected_");
                this.SetProperty(ref this.english_Selected_, value);
            }
        }

        public bool Japanese_Selected_
        {
            get
            {
                return this.japanese_Selected_;
            }

            set
            {
                this.japanese_Selected_ = value;
                this.OnPropertyChanged("Japanese_Selected_");
                this.SetProperty(ref this.japanese_Selected_, value);
            }
        }



        public IList<Channel> Channel_
        {
            get
            {
                return this.channel_;
            }
        }

        public IList<DirectMessage> Direct_Messages_
        {
            get
            {
                return this.direct_Message_;
            }

            set
            {
                Console.WriteLine("Updateing setter");
                this.direct_Message_ = value;

                //this.SetProperty(ref this.direct_Message_, value);
                this.OnPropertyChanged("Direct_Message_");
            }
        }
        

        private async void GetChannels()
        {
            //COLLECTS ALL CHANNELS FROM JSON FILE

            //SHOULD ALSO MAKE A CHECK CONNECTION FOR HOME PAGE AS WELL

            WebServiceClient client = new WebServiceClient();
            var result = await client.Get<Channel>("https://my-json-server.typicode.com/BlockyNewt/test/channels");

            if(result != null)
            {
                for(int i = 0; i < result.Count(); ++i)
                {
                    Channel channel = new Channel();
                    channel.Name_ = result[i].Name_;

                    this.Channel_.Add(channel);
                }
            }
        }

        private async void GetDirectMessages()
        {
            //COLLECTS ALL DMS
            
            //WE WILL WANT TO MAKE USER SPECIFIED DMS LATER BUT FOR NOW THIS WILL DO

            WebServiceClient client = new WebServiceClient();
            var result = await client.Get<DirectMessage>("https://my-json-server.typicode.com/BlockyNewt/test/direct_messages");

            if(result != null)
            {
                for(int i = 0; i < result.Count(); ++i)
                {
                    DirectMessage dm = new DirectMessage();
                    dm.First_Name_ = result[i].First_Name_;
                    dm.Last_Name_ = result[i].Last_Name_;

                    this.Direct_Messages_.Add(dm);
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

            if (action == this.Hub_Channel_Event_Enter_)
            {
                Console.WriteLine("Entering room");
            }
        }

        private DirectMessage selected_Messages_ { get; set; }
        public DirectMessage Selected_Messages_
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

            if (action == this.Hub_DM_Event_Chat_)
            {
                Console.WriteLine("Entering chat room with: " + this.selected_Messages_.First_Name_);
            }
            else if (action == this.Hub_DM_Event_Profile_)
            {
                //VIEW PROFILE
            }
            else if (action == this.Hub_DM_Event_Delete_)
            {
                this.Direct_Messages_.Remove(this.selected_Messages_);
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
                this.Channel_Display_ = true;
            }
        }


        private DelegateCommand dm_Button_Command_;
        public DelegateCommand DM_Button_Command_ => this.dm_Button_Command_ ?? (this.dm_Button_Command_ = new DelegateCommand(this.DMButton));
        private void DMButton()
        {
            //IF CLICKED IT WILL DISPLAY DMS
            if (!this.DM_Display_)
            {
                this.Channel_Display_ = false;
                this.Profile_Display_ = false;
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
                this.Profile_Display_ = true;
            }
        }

        private DelegateCommand setting_Button_Command_;
        public DelegateCommand Setting_Button_Command_ => this.setting_Button_Command_ ?? (this.setting_Button_Command_ = new DelegateCommand(this.SettingButton));
        private async void SettingButton()
        {
            //IF CLICKED IT WILL TAKE YOU TO THE SETTINGS PAGE 
            var p = new NavigationParameters();

            p.Add("english_Selected_", this.english_Selected_);
            p.Add("japanese_Selected_", this.japanese_Selected_);

            await this.navigation_Service_.NavigateAsync("SettingPage", p);
        }

        private DelegateCommand profile_Edit_Button_Command_;
        public DelegateCommand Profile_Edit_Button_Command_ => this.profile_Edit_Button_Command_ ?? (this.profile_Edit_Button_Command_ = new DelegateCommand(this.ProfileEditButton));
        private void ProfileEditButton()
        {
            //IF CLICKED IT WILL TAKE YOU TO THE PROFILE EDIT PAGE
            var p = new NavigationParameters();

            p.Add("user_", this.user_);
            p.Add("english_Selected_", this.english_Selected_);
            p.Add("japanese_Selected_", this.japanese_Selected_);

            this.navigation_Service_.NavigateAsync("ProfileEditPage", p);
        }

        private DelegateCommand profile_Logout_Button_Command_;
        public DelegateCommand Profile_Logout_Button_Command_ => this.profile_Logout_Button_Command_ ?? (this.profile_Logout_Button_Command_ = new DelegateCommand(this.ProfileLogoutButton));
        private async void ProfileLogoutButton()
        {
            //THIS WILL LOG THE CURRENT USER OUT
            var p = new NavigationParameters();

            p.Add("english_Selected_", this.english_Selected_);
            p.Add("japanese_Selected_", this.japanese_Selected_);

            await this.navigation_Service_.GoBackAsync(p);
        }


        private void SetLanguage()
        {
            if(this.english_Selected_)
            {
                this.Hub_Frame_Label_ = this.l_Eng_.Word[ENG_WORD.HUB_FRAME_LABEL];
                this.Hub_Channel_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_BUTTON];
                this.Hub_DM_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_BUTTON];
                this.Hub_Profile_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_BUTTON];
                this.Hub_Channel_Label_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_LABEL];
                this.Hub_Profile_Edit_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_EDIT_BUTTON];
                this.Hub_Profile_Logout_Button_ = this.l_Eng_.Word[ENG_WORD.HUB_PROFILE_LOGOUT_BUTTON];
                this.Hub_Channel_Event_Enter_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_EVENT_ENTER];
                this.Hub_Channel_Event_Cancel_ = this.l_Eng_.Word[ENG_WORD.HUB_CHANNEL_EVENT_CANCEL];
                this.Hub_DM_Event_Chat_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_CHAT];
                this.Hub_DM_Event_Profile_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_PROFILE];
                this.Hub_DM_Event_Delete_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_DELETE];
                this.Hub_DM_Event_Cancel_ = this.l_Eng_.Word[ENG_WORD.HUB_DM_EVENT_CANCEL];
            }
            else if(this.japanese_Selected_)
            {
                this.Hub_Frame_Label_ = this.l_Jap_.Word[JAP_WORD.HUB_FRAME_LABEL];
                this.Hub_Channel_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_BUTTON];
                this.Hub_DM_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_BUTTON];
                this.Hub_Profile_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_BUTTON];
                this.Hub_Channel_Label_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_LABEL];
                this.Hub_Profile_Edit_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_EDIT_BUTTON];
                this.Hub_Profile_Logout_Button_ = this.l_Jap_.Word[JAP_WORD.HUB_PROFILE_LOGOUT_BUTTON];
                this.Hub_Channel_Event_Enter_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_EVENT_ENTER];
                this.Hub_Channel_Event_Cancel_ = this.l_Jap_.Word[JAP_WORD.HUB_CHANNEL_EVENT_CANCEL];
                this.Hub_DM_Event_Chat_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_CHAT];
                this.Hub_DM_Event_Profile_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_PROFILE];
                this.Hub_DM_Event_Delete_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_DELETE];
                this.Hub_DM_Event_Cancel_ = this.l_Jap_.Word[JAP_WORD.HUB_DM_EVENT_CANCEL];
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //WHEN PASSING CLASS PARAMETERS YOU MUST SET EACH AND EVERY VARIABLE AGAIN FOR IT TO UPDATE THE VIEW
            //CANNOT DO: this.u_View_Model = parameters.GetValue<UserViewModel>("u_View_Model_");

            //IN ORDER FOR LANGUAGE TO CHANGE YOU MUST CHECK THE COUNT OF PARAMETERS BEING PASSED

            if(parameters.Count == 3)
            {
                this.English_Selected_ = parameters.GetValue<bool>("english_Selected_");
                this.Japanese_Selected_ = parameters.GetValue<bool>("japanese_Selected_");

                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;
            }
            if(parameters.Count == 2)
            {
               
                this.English_Selected_ = parameters.GetValue<bool>("english_Selected_");
                this.Japanese_Selected_ = parameters.GetValue<bool>("japanese_Selected_");
            }
            if(parameters.Count == 1)
            {
                Console.WriteLine("Count is 0");
                this.user_.First_Name_ = parameters.GetValue<UserViewModel>("user_").First_Name_;
                this.user_.Last_Name_ = parameters.GetValue<UserViewModel>("user_").Last_Name_;
                this.user_.Username_ = parameters.GetValue<UserViewModel>("user_").Username_;
                this.user_.Password_ = parameters.GetValue<UserViewModel>("user_").Password_;
            }
            

            this.SetLanguage();
        }
    }
}
