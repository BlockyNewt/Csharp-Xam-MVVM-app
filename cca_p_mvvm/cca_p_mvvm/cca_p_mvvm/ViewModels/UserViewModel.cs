using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cca_p_mvvm.ViewModels
{
    public class UserViewModel : BindableBase
    {
        private int id_;
        private string first_Name_;
        private string last_Name_;
        private string username_;
        private string password_;
        private string picture_;

        public int ID_
        {
            get
            {
                return this.id_;
            }

            set
            {
                this.id_ = value;
                this.OnPropertyChanged("ID_");
                this.SetProperty(ref this.id_, value);
            }
        }

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
                this.SetProperty(ref this.first_Name_, value);
                this.RaisePropertyChanged("First_Name_");
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
                this.SetProperty(ref this.last_Name_, value);
                this.RaisePropertyChanged("Last_Name_");
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
                this.SetProperty(ref this.username_, value);
                this.RaisePropertyChanged("Username_");
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
                this.SetProperty(ref this.password_, value);
                this.RaisePropertyChanged("Password_");
            }
        }

        public string Picture_
        {
            get
            {
                if(string.IsNullOrEmpty(this.picture_))
                {
                    return "Empty string";
                }

                return this.picture_;
            }

            set
            {
                this.SetProperty(ref this.picture_, value);
                this.RaisePropertyChanged("Picture_");
            }
        }
    }
}
