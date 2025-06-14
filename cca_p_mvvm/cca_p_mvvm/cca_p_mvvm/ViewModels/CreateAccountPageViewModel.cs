﻿using Android.Icu.Util;
using Android.Speech.Tts;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace cca_p_mvvm.ViewModels
{
    public class CreateAccountPageViewModel : ViewModelBase, INavigationAware
    {
        public CreateAccountPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.navigation_Service_ = navigationService;

            this.l_Eng_ = new LanguageEnglish();
            this.l_Jap_ = new LanguageJapanese();

            this.client_Connection_ = new ClientConnection();

            this.color_Scheme_ = new ColorScheme();

            this.name_Section_ = true;
            this.username_Section_ = false;
            this.password_Section_ = false;
            this.email_Section_ = false;
            this.picture_Section_ = false;
            this.bio_Section_ = false;

            this.next_Button_Visibility_ = true;
            this.confirm_Button_Visibility_ = false;

            this.progress_Bar_Value_ = 0.0f;
            this.progress_Current_ = 0;
            this.progress_Max_ = 5;
        }
        
        //NAVIGATION SERVICE
        private readonly INavigationService navigation_Service_;

        //LANGUAGES
        public LanguageEnglish l_Eng_ { get; private set; }
        public LanguageJapanese l_Jap_ { get; private set; }

        //CONNECTION TO THE SERVER
        public ClientConnection client_Connection_ { get; private set; }

        //COLOR-SCHEMES
        public ColorScheme color_Scheme_ { get; private set; }

        private string first_Name_Label_Text_;
        private string first_Name_Text_Changed_;
        private string first_Name_Placeholder_Text_;
        private string last_Name_Label_Text_;
        private string last_Name_Text_Changed_;
        private string last_Name_Placeholder_Text_;
        private string username_Label_Text_;
        private string username_Placeholder_Text_;
        private string username_Text_Changed_;
        private string password_Label_Text_;
        private string password_Text_Changed_;
        private string password_Placeholder_Text_;
        private string password_Confirm_Text_Changed_;
        private string email_Label_Text_;
        private string email_Text_Changed_;
        private string email_Placeholder_Text_;
        private string profile_Picture_Label_Text_;
        private string profile_Picture_Placeholder_Text_;
        private string profile_Picture_Text_Changed_;
        private string bio_Label_Text_;
        private string bio_Text_Changed_;
        private string bio_Text_Placeholder_;

        private string back_Button_;
        private string next_Button_;
        private string confirm_Button_;
        private string clear_Button_;
        private string cancel_Button_;

        private string error_Password_Title_;
        private string error_Password_Message_;
        private string error_Password_Button_;
        private string error_Fields_Title_;
        private string error_Fields_Message_;
        private string error_Fields_Button_;
        private string error_Username_Title_;
        private string error_Username_Message_;
        private string error_Username_Button_;
        private string error_Email_Title_;
        private string error_Email_Message_;
        private string error_Email_Button_;

        private bool username_Section_;
        private bool password_Section_;
        private bool email_Section_;
        private bool name_Section_;
        private bool picture_Section_;
        private bool bio_Section_;

        private bool confirm_Button_Visibility_;
        private bool next_Button_Visibility_;

        private float progress_Bar_Value_;
        private string progress_Text_;
        private string progress_Text_Language_String_;
        private int progress_Current_;
        private int progress_Max_;

        public string First_Name_Label_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.first_Name_Label_Text_))
                {
                    return "Empty";
                }

                return this.first_Name_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.first_Name_Label_Text_, value);
                this.RaisePropertyChanged("First_Name_Label_Text_");
            }
        }

        public string First_Name_Text_Changed_
        {
            get
            {
                return this.first_Name_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.first_Name_Text_Changed_, value);
                this.RaisePropertyChanged("First_Name_Text_Changed_");
            }
        }

        public string First_Name_Placeholder_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.first_Name_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.first_Name_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.first_Name_Placeholder_Text_, value);
                this.RaisePropertyChanged("First_Name_Placeholder_Text_");
            }
        }

        public string Last_Name_Label_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.last_Name_Label_Text_))
                {
                    return "Empty";
                }

                return this.last_Name_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.last_Name_Label_Text_, value);
                this.RaisePropertyChanged("Last_Name_Label_Text_");
            }
        }

        public string Last_Name_Text_Changed_
        {
            get
            {
                return last_Name_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.last_Name_Text_Changed_, value);
                this.RaisePropertyChanged("Last_Name_Text_Changed_");
            }
        }

        public string Last_Name_Placeholder_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.last_Name_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.last_Name_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.last_Name_Placeholder_Text_, value);
                this.RaisePropertyChanged("Last_Name_Placeholder_Text_");
            }
        }

        public string Username_Label_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.username_Label_Text_))
                {
                    return "Empty";
                }

                return this.username_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.username_Label_Text_, value);
                this.RaisePropertyChanged("Username_Label_Text_");
            }
        }

        public string Username_Placeholder_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.username_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.username_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.username_Placeholder_Text_, value);
                this.RaisePropertyChanged("Username_Placeholder_Text_");
            }
        }

        public string Username_Text_Changed_
        {
            get
            {
                return this.username_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.username_Text_Changed_, value);
                this.RaisePropertyChanged("Username_Text_Changed_");
            }
        }

        public string Password_Label_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.password_Label_Text_))
                {
                    return "Empty";
                }

                return this.password_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.password_Label_Text_, value);
                this.RaisePropertyChanged("Password_Label_Text_");
            }
        }

        public string Password_Text_Changed_
        {
            get
            {
                return this.password_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.password_Text_Changed_, value);
                this.RaisePropertyChanged("Password_Text_Changed_");
            }
        }

        public string Password_Confirm_Text_Changed_
        {
            get
            {
                return this.password_Confirm_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.password_Confirm_Text_Changed_, value);
                this.RaisePropertyChanged("Password_Confirm_Text_Changed_");
            }
        }

        public string Password_Placeholder_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.password_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.password_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.password_Placeholder_Text_, value);
                this.RaisePropertyChanged("Password_Placeholder_Text_");
            }
        }

        public string Email_Label_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.email_Label_Text_))
                {
                    return "Empty string";
                }

                return this.email_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.email_Label_Text_, value);
                this.RaisePropertyChanged("Email_Label_Text_");
            }
        }

        public string Email_Text_Changed_
        {
            get
            {
                return this.email_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.email_Text_Changed_, value);
                this.RaisePropertyChanged("Email_Text_Changed_");
            }
        }

        public string Email_Placeholder_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.email_Placeholder_Text_))
                {
                    return "Empty string";
                }

                return this.email_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.email_Placeholder_Text_, value);
                this.RaisePropertyChanged("Email_Placeholder_Text_");
            }
        }

        public string Profile_Picture_Label_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(profile_Picture_Label_Text_))
                {
                    return "Empty";
                }

                return this.profile_Picture_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.profile_Picture_Label_Text_, value);
                this.RaisePropertyChanged("Profile_Picture_Label_Text_");
            }
        }

        public string Profile_Picture_Placeholder_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.profile_Picture_Placeholder_Text_))
                {
                    return "Empty";
                }

                return this.profile_Picture_Placeholder_Text_;
            }

            set
            {
                this.SetProperty(ref this.profile_Picture_Placeholder_Text_, value);
                this.RaisePropertyChanged("Profile_Picture_Placeholder_Text_");
            }
        }

        public string Profile_Picture_Text_Changed_
        {
            get
            {
                return this.profile_Picture_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.profile_Picture_Text_Changed_, value);
                this.RaisePropertyChanged("Profile_Picture_Text_Changed_");
            }
        }

        public string Bio_Label_Text_
        {
            get
            {
                if (string.IsNullOrEmpty(this.bio_Label_Text_))
                {
                    return "Empty string";
                }

                return this.bio_Label_Text_;
            }

            set
            {
                this.SetProperty(ref this.bio_Label_Text_, value);
                this.RaisePropertyChanged("Bio_Label_Text_");
            }
        }

        public string Bio_Text_Changed_
        {
            get
            {
                return this.bio_Text_Changed_;
            }

            set
            {
                this.SetProperty(ref this.bio_Text_Changed_, value);
                this.RaisePropertyChanged("Bio_Text_Changed_");
            }
        }

        public string Bio_Text_Placeholder_
        {
            get
            {
                if(string.IsNullOrEmpty(this.bio_Text_Placeholder_))
                {
                    return "Empty";
                }

                return this.bio_Text_Placeholder_;
            }

            set
            {
                this.SetProperty(ref this.bio_Text_Placeholder_, value);
                this.RaisePropertyChanged("Bio_Text_Placeholder_");
            }
        }

        public string Back_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(back_Button_))
                {
                    return "Empty string";
                }

                return this.back_Button_;
            }

            set
            {
                this.SetProperty(ref this.back_Button_, value);
                this.RaisePropertyChanged("Back_Button_");
            }
        }

        public string Next_Button_
        {
            get
            {
                if (string.IsNullOrEmpty(next_Button_))
                {
                    return "Empty string";
                }

                return this.next_Button_;
            }

            set
            {
                this.SetProperty(ref this.next_Button_, value);
                this.RaisePropertyChanged("Next_Button_");
            }
        }

        public string Clear_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.clear_Button_))
                {
                    return "Empty";
                }

                return this.clear_Button_;
            }

            set
            {
                this.SetProperty(ref this.clear_Button_, value);
                this.RaisePropertyChanged("Clear_Button_");
            }
        }

        public string Confirm_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.confirm_Button_))
                {
                    return "Empty";
                }

                return this.confirm_Button_;
            }

            set
            {
                this.SetProperty(ref this.confirm_Button_, value);
                this.RaisePropertyChanged("Confirm_Button_");
            }
        }

        public string Error_Password_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Password_Title_))
                {
                    return "Empty";
                }

                return this.error_Password_Title_;
            }

            set
            {
                this.SetProperty(ref this.error_Password_Title_, value);
                this.RaisePropertyChanged("Error_Title_");
            }
        }

        public string Error_Password_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Password_Message_))
                {
                    return "Empty";
                }

                return this.error_Password_Message_;
            }

            set
            {
                this.SetProperty(ref this.error_Password_Message_, value);
                this.RaisePropertyChanged("Error_Messsage_");
            }
        }

        public string Error_Password_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Password_Button_))
                {
                    return "Empty";
                }

                return this.error_Password_Button_;
            }

            set
            {
                this.SetProperty(ref this.error_Password_Button_, value);
                this.RaisePropertyChanged("Error_Button_");
            }
        }

        public string Error_Fields_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Fields_Title_))
                {
                    return "Empty string";
                }

                return this.error_Fields_Title_;
            }

            set
            {
                this.SetProperty(ref this.error_Fields_Title_, value);
                this.RaisePropertyChanged("Error_Fields_Title_");
            }
        }

        public string Error_Fields_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Fields_Message_))
                {
                    return "Empty string";
                }

                return this.error_Fields_Message_;
            }

            set
            {
                this.SetProperty(ref this.error_Fields_Message_, value);
                this.RaisePropertyChanged("Error_Fields_Message_");
            }
        }

        public string Error_Fields_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Fields_Button_))
                {
                    return "Empty string";
                }

                return this.error_Fields_Button_;
            }

            set
            {
                this.SetProperty(ref this.error_Fields_Button_, value);
                this.RaisePropertyChanged("Error_Fields_Button_");
            }
        }

        public string Error_Username_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Username_Title_))
                {
                    return "Empty string";
                }

                return this.error_Username_Title_;
            }

            set
            {
                this.SetProperty(ref this.error_Username_Title_, value);
                this.RaisePropertyChanged("Error_Username_Title_");
            }
        }

        public string Error_Username_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Username_Message_))
                {
                    return "Empty string";
                }

                return this.error_Username_Message_;
            }

            set
            {
                this.SetProperty(ref this.error_Username_Message_, value);
                this.RaisePropertyChanged("Error_Username_Message_");
            }
        }

        public string Error_Username_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Username_Button_))
                {
                    return "Empty string";
                }

                return this.error_Username_Button_;
            }

            set
            {
                this.SetProperty(ref this.error_Username_Button_, value);
                this.RaisePropertyChanged("Error_Username_Button_");
            }
        }

        public string Error_Email_Title_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Email_Title_))
                {
                    return "Empty string";
                }

                return this.error_Email_Title_;
            }

            set
            {
                this.SetProperty(ref this.error_Email_Title_, value);
                this.RaisePropertyChanged("Error_Email_Title_");  
            }
        }

        public string Error_Email_Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Email_Message_))
                {
                    return "Empty string";
                }

                return this.error_Email_Message_;
            }

            set
            {
                this.SetProperty(ref this.error_Email_Message_, value);
                this.RaisePropertyChanged("Error_Email_Message_");
            }
        }

        public string Error_Email_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.error_Email_Button_))
                {
                    return "Empty string";
                }

                return this.error_Email_Button_;
            }

            set
            {
                this.SetProperty(ref this.error_Email_Button_, value);
                this.RaisePropertyChanged("Error_Email_Button_");
            }
        }

        public string Cancel_Button_
        {
            get
            {
                if(string.IsNullOrEmpty(this.cancel_Button_))
                {
                    return "Empty";
                }

                return cancel_Button_;
            }

            set
            {
                this.SetProperty(ref this.cancel_Button_, value);
                this.RaisePropertyChanged("Cancel_Button_");
            }
        }

        public bool Name_Section_
        {
            get
            {
                return this.name_Section_;
            }

            set
            {
                this.SetProperty(ref this.name_Section_, value);
                this.RaisePropertyChanged("Name_Section_");
            }
        }

        public bool Username_Section_
        {
            get
            {
                return this.username_Section_;
            }

            set
            {
                this.SetProperty(ref this.username_Section_, value);
                this.RaisePropertyChanged("Username_Section_");
            }
        }

        public bool Password_Section_
        {
            get
            {
                return this.password_Section_;
            }

            set
            {
                this.SetProperty(ref this.password_Section_, value);
                this.RaisePropertyChanged("Password_Section_");
            }
        }

        public bool Email_Section_
        {
            get
            {
                return this.email_Section_;
            }

            set
            {
                this.SetProperty(ref this.email_Section_, value);
                this.RaisePropertyChanged("Email_Section_");
            }
        }

        public bool Picture_Section_
        {
            get
            {
                return this.picture_Section_;
            }

            set
            {
                this.SetProperty(ref this.picture_Section_, value);
                this.RaisePropertyChanged("Picture_Section_");
            }
        }

        public bool Bio_Section_
        {
            get
            {
                return this.bio_Section_;
            }

            set
            {
                this.SetProperty(ref this.bio_Section_, value);
                this.RaisePropertyChanged("Bio_Section_");
            }
        }

        public bool Confirm_Button_Visibility_
        {
            get
            {
                return this.confirm_Button_Visibility_;
            }

            set
            {
                this.SetProperty(ref this.confirm_Button_Visibility_, value);
                this.RaisePropertyChanged("Confirm_Button_Visibility_");
            }
        }

        public bool Next_Button_Visibility_
        {
            get
            {
                return this.next_Button_Visibility_;
            }

            set
            {
                this.SetProperty(ref this.next_Button_Visibility_, value);
                this.RaisePropertyChanged("Next_Button_Visibility_");
            }
        }

        public float Progress_Bar_Value_
        {
            get
            {
                return this.progress_Bar_Value_;
            }

            set
            {
                this.SetProperty(ref this.progress_Bar_Value_, value);
                this.RaisePropertyChanged("Progress_Bar_Value_");
            }
        }

        public string Progress_Text_
        {
            get
            {
                if(string.IsNullOrEmpty(this.progress_Text_))
                {
                    return "Empty string";
                }

                return this.progress_Text_;
            }

            set
            {
                this.SetProperty(ref this.progress_Text_, value);
                this.RaisePropertyChanged("Progress_Text_");
            }
        }



        private DelegateCommand clear_Button_Command_;
        public DelegateCommand Clear_Button_Command_ => this.clear_Button_Command_ ?? (this.clear_Button_Command_ = new DelegateCommand(this.ClearButton));
        private void ClearButton()
        {
            //CLEAR FIELDS BASED ON THE STEP YOU ARE ON
            if(this.Name_Section_)
            {
                //CLEAR NAME ENTRY FIELDS 
                this.First_Name_Text_Changed_ = string.Empty;
                this.Last_Name_Text_Changed_ = string.Empty;
            }
            else if(this.Username_Section_)
            {
                //CLEAR USERNAME ENTRY FIELDS 
                this.Username_Text_Changed_ = string.Empty;
            }
            else if(this.Password_Section_)
            {
                //CLEAR PASSWORD ENTRY FIELDS
                this.Password_Text_Changed_ = string.Empty;
                this.Password_Confirm_Text_Changed_ = string.Empty;
            }
            else if (this.Email_Section_)
            {
                this.Email_Text_Changed_ = string.Empty;
            }
            else if(this.Picture_Section_)
            {
                //CLEAR PROFILE ENTRY FIELD
                this.Profile_Picture_Text_Changed_ = string.Empty;
            }
            else if(this.Bio_Section_)
            {
                //CLEAR BIO ENTRY FIELD
                this.Bio_Text_Changed_ = string.Empty;
            }
        }



        private DelegateCommand confirm_Button_Command_;
        public DelegateCommand Confirm_Button_Command_ => this.confirm_Button_Command_ ?? (this.confirm_Button_Command_ = new DelegateCommand(this.ConfirmButton));
        private async void ConfirmButton()
        {
            //CREATE USER AND PUSH BACK 
            if( !string.IsNullOrEmpty(this.First_Name_Text_Changed_) && 
                !string.IsNullOrEmpty(this.Last_Name_Text_Changed_) &&
                !string.IsNullOrEmpty(this.Password_Text_Changed_) && 
                !string.IsNullOrEmpty(this.Password_Confirm_Text_Changed_) && 
                !string.IsNullOrEmpty(this.Username_Text_Changed_) && 
                this.Progress_Bar_Value_ == 1.0f)
            {
                if(this.Password_Confirm_Text_Changed_ == this.Password_Text_Changed_)
                {
                    //SEND NEW ACCOUNT INFORMATION TO SERVER AND ADD IT TO THE D.B
                    this.client_Connection_.CreateAccount(this.First_Name_Text_Changed_, this.Last_Name_Text_Changed_, this.Username_Text_Changed_, this.Password_Confirm_Text_Changed_, this.Bio_Text_Changed_, this.Profile_Picture_Text_Changed_);

                    //GO BACK TO LOGIN PAGE
                    await this.navigation_Service_.GoBackAsync();
                }
                else
                {
                    //IF PASSWORDS DO NOT MATCH SHOW AN ERROR
                    await Application.Current.MainPage.DisplayAlert(this.Error_Password_Title_, this.Error_Password_Message_, this.Error_Password_Button_);
                }
            }
            else
            {
                //IF ALL FIELDS ARE NOT FILLED THEN SHOW AN ERROR
                await Application.Current.MainPage.DisplayAlert(this.Error_Fields_Title_, this.Error_Fields_Message_, this.Error_Fields_Button_);
            }
        }



        private DelegateCommand cancel_Button_Command_;
        public DelegateCommand Cancel_Button_Command_ => this.cancel_Button_Command_ ?? (this.cancel_Button_Command_ = new DelegateCommand(this.CancelButton));
        private async void CancelButton()
        {
            //GO BACK TO LOGIN SCREEN
            await this.navigation_Service_.GoBackAsync();
        }



        private DelegateCommand next_Button_Command_;
        public DelegateCommand Next_Button_Command_ => this.next_Button_Command_ ?? (this.next_Button_Command_ = new DelegateCommand(this.NextButton));
        private async void NextButton()
        {
            //SHOW INFORMATION RELATED TO SECTION
            if (this.Name_Section_)
            {
                //CHANGE THE VISIBILITY OF CURRENT ITEM SINCE WE WILL GO TO NEXT SECTION
                this.Name_Section_ = false;
                this.Username_Section_ = true;

                //INCREASE PROGRESS BAR
                this.Progress_Bar_Value_ += 0.2f;
                this.progress_Current_++;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE VISIBILITY OF CONFIRM AND NEXT BUTTON IF NEEDED (ONLY ON LAST SECTION DO WE SWITCH THEM)
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
            else if(this.Username_Section_)
            {
                //CHECK IF THE TYPED USERNAME IS ALREADY OR TAKEN OR NOT
                if(this.client_Connection_.CheckIfUsernameIsTaken(this.Username_Text_Changed_) != "EMPTY")
                {
                    //CHANGE WHICH SECTION IS TO BE DISPLAYED
                    this.Username_Section_ = false;
                    this.Password_Section_ = true;

                    //INCREASE PROGRESS BAR
                    this.Progress_Bar_Value_ += 0.2f;
                    this.progress_Current_++;
                    this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                    //CHANGE WHICH BUTTONS ARE VISIBLE
                    this.Confirm_Button_Visibility_ = false;
                    this.Next_Button_Visibility_ = true;
                }
                else
                {
                    //IF USERNAME IS ALREADY TAKEN THE SHOW AN ERROR
                    await Application.Current.MainPage.DisplayAlert(this.Error_Username_Title_, this.Error_Username_Message_, this.Error_Username_Button_);
                }
            }
            else if(this.Password_Section_)
            {
                //CHANGE WHICH SECTION IS TO BE DISPLAYED
                this.Password_Section_ = false;
                this.Email_Section_ = true;

                //INCREASE PROGRESS BAR
                this.Progress_Bar_Value_ += 0.2f;
                this.progress_Current_++;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
            else if (this.Email_Section_)
            {
                //CHECK IF EMAIL IS ALREADY TAKEN
                if(this.client_Connection_.CheckIfEmailIsTaken(this.Email_Text_Changed_) != "EMPTY")
                {
                    this.Email_Section_ = false;
                    this.Picture_Section_ = true;

                    //INCREASE PROGRESS BAR
                    this.Progress_Bar_Value_ += 0.2f;
                    this.progress_Current_++;
                    this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                    //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                    this.Confirm_Button_Visibility_ = false;
                    this.Next_Button_Visibility_ = true;
                }
                else
                {
                    //DISPLAY ERROR
                    await Application.Current.MainPage.DisplayAlert(this.Error_Email_Title_, this.Error_Email_Message_, this.Error_Email_Button_);
                }
            }
            else if(this.Picture_Section_)
            {
                //SHOW WHICH SECTION IS TO BE DISPLAYED
                this.Picture_Section_ = false;
                this.Bio_Section_ = true;

                //INCREASE PROGRESS BAR
                this.Progress_Bar_Value_ += 0.2f;
                this.progress_Current_++;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                this.Next_Button_Visibility_ = false;
                this.Confirm_Button_Visibility_ = true;
            }
        }



        private DelegateCommand back_Button_Command_;
        public DelegateCommand Back_Button_Command_ => this.back_Button_Command_ ?? (this.back_Button_Command_ = new DelegateCommand(this.BackButton));
        private void BackButton()
        {
            //GOING BACK A SECTION

            if(this.Name_Section_)
            {
                //IF ON THE FIRST PAGE THEN IT WILL JUST TAKE YOU BACK TO LOGIN
                this.navigation_Service_.GoBackAsync();
            }
            else if(this.Username_Section_)
            {
                //CHANGE THE VISIBILITY OF CURRENT ITEM SINCE WE WILL GO TO NEXT SECTION
                this.Username_Section_ = false;
                this.Name_Section_ = true;

                //INCREASE PROGRESS BAR
                this.Progress_Bar_Value_ -= 0.2f;
                this.progress_Current_--;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE VISIBILITY OF CONFIRM AND NEXT BUTTON IF NEEDED (ONLY ON LAST SECTION DO WE SWITCH THEM)
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
            else if(this.Password_Section_)
            {
                //CHANGE WHICH SECTION IS TO BE DISPLAYED
                this.Password_Section_ = false;
                this.Username_Section_ = true;

                //DECREASE PROGRESS BAR
                this.Progress_Bar_Value_ -= 0.2f;
                this.progress_Current_--;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
            else if (this.Email_Section_)
            {
                this.Email_Section_ = false;
                this.Password_Section_ = true;

                //DECREASE PROGRESS BAR
                this.Progress_Bar_Value_ -= 0.2f;
                this.progress_Current_--;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
            else if(this.Picture_Section_)
            {
                //CHANGE WHICH SECTION IS TO BE DISPLAYED
                this.Picture_Section_ = false;
                this.Email_Section_ = true;

                //DECREASE PROGRESS BAR
                this.Progress_Bar_Value_ -= 0.2f;
                this.progress_Current_--;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
            else if(this.Bio_Section_)
            {
                //CHANGE WHICH SECTION IS TO BE DISPLAYED
                this.Bio_Section_ = false;
                this.Picture_Section_ = true;

                //DECREASE PROGRESS BAR
                this.Progress_Bar_Value_ -= 0.2f;
                this.progress_Current_--;
                this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

                //CHANGE WHICH BUTTONS ARE TO BE DISPLAYED
                this.Confirm_Button_Visibility_ = false;
                this.Next_Button_Visibility_ = true;
            }
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
            this.color_Scheme_.Is_Christmas_Selected_ = parameters.GetValue<ColorScheme>("color_Scheme_").Is_Christmas_Selected_;

            this.SetLanguage();

            this.Progress_Text_ = this.progress_Text_Language_String_ + this.progress_Current_.ToString() + "/" + this.progress_Max_.ToString();

            this.color_Scheme_.SetColors();
        }


        private void SetLanguage()
        {
            //SET LANGUAGE BASED ON WHICH ONE IS TRUE
            if (this.l_Eng_.Is_English_Selected_)
            {
                this.First_Name_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL];  
                this.First_Name_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER];  
                this.Last_Name_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL];
                this.Last_Name_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER];
                this.Username_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_LABEL];
                this.Username_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER];
                this.Password_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_LABEL];
                this.Password_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER];
                this.Email_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_EMAIL_LABEL];
                this.Email_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_EMAIL_PLACEHOLDER];
                this.Profile_Picture_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_LABEL];
                this.Profile_Picture_Placeholder_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER];
                this.Bio_Label_Text_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROFILE_BIO_LABEL];
                this.Bio_Text_Placeholder_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROFILE_BIO_PLACEHOLDER];
                this.Back_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_BACK_BUTTON];
                this.Next_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_NEXT_BUTTON];
                this.Confirm_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON];
                this.Clear_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_CLEAR_BUTTON];
                this.Cancel_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_CANCEL_BUTTON];
                this.progress_Text_Language_String_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PROGRESS_BAR_TEXT];
                this.Error_Password_Title_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_TITLE];
                this.Error_Password_Message_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_MESSAGE];
                this.Error_Password_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_BUTTON];
                this.Error_Fields_Title_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIELDS_ERROR_TITLE];
                this.Error_Fields_Message_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIELDS_ERROR_MESSAGE];
                this.Error_Fields_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_FIELDS_ERROR_BUTTON];
                this.Error_Username_Title_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_ERROR_TITLE];
                this.Error_Username_Message_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_ERROR_MESSAGE];
                this.Error_Username_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_USERNAME_ERROR_BUTTON];
                this.Error_Email_Title_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_EMAIL_ERROR_TITLE];
                this.Error_Email_Message_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_EMAIL_ERROR_MESSAGE];
                this.Error_Email_Button_ = this.l_Eng_.Word[ENG_WORD.CREATE_ACCOUNT_EMAIL_ERROR_BUTTON];

            }
            else if (this.l_Jap_.Is_Japanese_Selected_)
            {
                this.First_Name_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIRST_NAME_LABEL];
                this.First_Name_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIRST_NAME_PLACEHOLDER];
                this.Last_Name_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_LAST_NAME_LABEL];
                this.Last_Name_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_LAST_NAME_PLACEHOLDER];
                this.Username_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_LABEL];
                this.Username_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_PLACEHOLDER];
                this.Password_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_LABEL];
                this.Password_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_PLACEHOLDER];
                this.Email_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_EMAIL_LABEL];
                this.Email_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_EMAIL_PLACEHOLDER];
                this.Profile_Picture_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_LABEL];
                this.Profile_Picture_Placeholder_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROFILE_PICTURE_PLACEHOLDER];
                this.Bio_Label_Text_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROFILE_BIO_LABEL];
                this.Bio_Text_Changed_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROFILE_BIO_PLACEHOLDER];
                this.Back_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_BACK_BUTTON];
                this.Next_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_NEXT_BUTTON];
                this.Confirm_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_CONFIRM_BUTTON];
                this.Clear_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_CLEAR_BUTTON];
                this.Cancel_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_CANCEL_BUTTON];
                this.progress_Text_Language_String_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PROGRESS_BAR_TEXT];
                this.Error_Password_Title_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_TITLE];
                this.Error_Password_Message_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_MESSAGE];
                this.Error_Password_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_PASSWORD_ERROR_BUTTON];
                this.Error_Fields_Title_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIELDS_ERROR_TITLE];
                this.Error_Fields_Message_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIELDS_ERROR_MESSAGE];
                this.Error_Fields_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_FIELDS_ERROR_BUTTON];
                this.Error_Username_Title_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_ERROR_TITLE];
                this.Error_Username_Message_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_ERROR_MESSAGE];
                this.Error_Username_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_USERNAME_ERROR_BUTTON];
                this.Error_Email_Title_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_EMAIL_ERROR_TITLE];
                this.Error_Email_Message_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_EMAIL_ERROR_MESSAGE];
                this.Error_Email_Button_ = this.l_Jap_.Word[JAP_WORD.CREATE_ACCOUNT_EMAIL_ERROR_BUTTON];
            }
        }

    }
}
