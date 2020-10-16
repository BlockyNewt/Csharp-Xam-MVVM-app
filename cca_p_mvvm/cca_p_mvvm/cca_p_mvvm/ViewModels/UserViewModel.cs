using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace cca_p_mvvm.ViewModels
{
    public class UserViewModel : BindableBase
    {
        private int id_;
        private string first_Name_;
        private string last_Name_;
        private string fullname_;
        private string username_;
        private string password_;
        private string bio_;
        private string picture_;

        public int ID_
        {
            get
            {
                return this.id_;
            }

            set
            {
                this.SetProperty(ref this.id_, value);
                this.RaisePropertyChanged("ID_");
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

        public string Fullname_
        {
            get
            {
                if(string.IsNullOrEmpty(this.fullname_))
                {
                    return "Empty string";
                }

                return this.fullname_;
            }

            set
            {
                this.SetProperty(ref this.fullname_, value);
                this.RaisePropertyChanged("Fullname_");
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

        public string Bio_
        {
            get
            {
                if(string.IsNullOrEmpty(this.bio_))
                {
                    return "Empty";
                }

                return this.bio_;
            }

            set
            {
                this.SetProperty(ref this.bio_, value);
                this.RaisePropertyChanged("Bio_");
            }
        }

        public string Picture_
        {
            get
            {
                if (string.IsNullOrEmpty(this.picture_))
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

        private Color text_Color_;

        public Color Text_Color_
        {
            get
            {
                return this.text_Color_;
            }

            set
            {
                this.SetProperty(ref this.text_Color_, value);
                this.RaisePropertyChanged("Text_Color_");
            }
        }
    }
}
