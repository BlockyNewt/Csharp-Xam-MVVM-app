using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace cca_p_mvvm.ViewModels
{
    public class Message : BindableBase
    {
        private string message_;
        private string sender_Name_;

        public string Message_
        {
            get
            {
                if(string.IsNullOrEmpty(this.message_))
                {
                    return "Empty string";
                }

                return this.message_;
            }

            set
            {
                this.SetProperty(ref this.message_, value);
                this.RaisePropertyChanged("Message_");
            }
        }

        public string Sender_Name_
        {
            get
            {
                if(string.IsNullOrEmpty(this.sender_Name_))
                {
                    return "Empty string";
                }

                return this.sender_Name_;
            }

            set
            {
                this.SetProperty(ref this.sender_Name_, value);
                this.RaisePropertyChanged("Sender_Name_");
            }
        }


        //COLORS FOR APP THEME
        private Color text_Color_;
        private Color text_Secondary_Color_;
        private Color background_Color_;
        private Color button_Color_;

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

        public Color Text_Secondary_Color_
        {
            get
            {
                return this.text_Secondary_Color_;
            }

            set
            {
                this.SetProperty(ref this.text_Secondary_Color_, value);
                this.RaisePropertyChanged("Text_Secondary_Color_");
            }
        }

        public Color Background_Color_
        {
            get
            {
                return this.background_Color_;
            }

            set
            {
                this.SetProperty(ref this.background_Color_, value);
                this.RaisePropertyChanged("Background_Color_");
            }
        }

        public Color Button_Color_
        {
            get
            {
                return this.button_Color_;
            }

            set
            {
                this.SetProperty(ref this.button_Color_, value);
                this.RaisePropertyChanged("Button_Color_");
            }
        }
    }
}
