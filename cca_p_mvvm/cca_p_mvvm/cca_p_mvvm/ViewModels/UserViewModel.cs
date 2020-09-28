using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cca_p_mvvm.ViewModels
{
    public class UserViewModel : BindableBase
    {
        private string first_Name_;
        private string last_Name_;
        private string username_;
        private string password_;

        public string First_Name_
        {
            get
            {
                if (string.IsNullOrEmpty(this.first_Name_))
                {
                    return "Empty string";
                }

                return this.first_Name_;
            }

            set
            {
                this.first_Name_ = value;
                this.OnPropertyChanged("First_Name_");
                this.SetProperty(ref this.first_Name_, value);
            }
        }

        public string Last_Name_
        {
            get
            {
                if (string.IsNullOrEmpty(this.last_Name_))
                {
                    return "Empty string";
                }

                return this.last_Name_;
            }

            set
            {
                this.last_Name_ = value;
                this.OnPropertyChanged("Last_Name_");
                this.SetProperty(ref this.last_Name_, value);
            }
        }

        public string Username_
        {
            get
            {
                if (string.IsNullOrEmpty(this.username_))
                {
                    return "Empty string";
                }

                return this.username_;
            }

            set
            {
                this.username_ = value;
                this.OnPropertyChanged("Username_");
                this.SetProperty(ref this.username_, value);
            }
        }

        public string Password_
        {
            get
            {
                if (string.IsNullOrEmpty(this.password_))
                {
                    return "Empty string";
                }

                return this.password_;
            }

            set
            {
                this.password_ = value;
                this.OnPropertyChanged("Password_");
                this.SetProperty(ref this.password_, value);
            }
        }
    }
}
