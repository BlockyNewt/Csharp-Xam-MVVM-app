using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Xamarin.Essentials;

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
                if (string.IsNullOrEmpty(this.message_))
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
                if (string.IsNullOrEmpty(this.sender_Name_))
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


        private DelegateCommand tap_Command_;
        public DelegateCommand Tap_Command_ => this.tap_Command_ ?? (this.tap_Command_ = new DelegateCommand(OnTap));
        private async void OnTap()
        {
            string[] getUrl = this.message_.Split(' ');
            string urlOne = string.Empty;
            string urlTwo = string.Empty;
            string urlThree = string.Empty;
            for (int i = 0; i < getUrl.Length; ++i)
            {
                Console.WriteLine("WORD: " + getUrl[i]);

                if (getUrl[i].Contains("https://"))
                {
                    if(urlOne.Length == 0 && urlOne != getUrl[i])
                    {
                        urlOne = getUrl[i];
                        Console.Write("URL ONE: " + urlOne); 
                    }
                    else if(string.IsNullOrEmpty(urlTwo))
                    {
                        urlTwo = getUrl[i];
                        Console.Write("URL TWO: " + urlTwo);

                    }
                    else if (string.IsNullOrEmpty(urlThree))
                    {
                        urlThree = getUrl[i];
                        Console.Write("URL THREE: " + urlThree);
                    }
                }
            }

            if(!string.IsNullOrEmpty(urlOne))
            {
                string action = await Xamarin.Forms.Application.Current.MainPage.DisplayActionSheet("Link", "Close", null, urlOne, urlTwo, urlThree);

                if(action == urlOne)
                {
                    await Browser.OpenAsync(urlOne);
                }
                else if (action == urlTwo)
                {
                    await Browser.OpenAsync(urlTwo);
                }
                else if (action == urlThree)
                {
                    await Browser.OpenAsync(urlThree);
                }
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
