using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
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
                this.message_ = value;
                this.OnPropertyChanged("Message_");
                this.SetProperty(ref this.message_, value);
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
                this.sender_Name_ = value;
                this.OnPropertyChanged("Sender_Name_");
                this.SetProperty(ref this.sender_Name_, value);
            }
        }
       
    }
}
