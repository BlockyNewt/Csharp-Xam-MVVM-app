using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace cca_p_mvvm
{
    public class Channel : BindableBase, INotifyPropertyChanged
    {
        private string name_;
        private int id_;

        public string Name_
        {
            get
            {
                if (string.IsNullOrEmpty(this.name_))
                {
                    return "Empty string";
                }

                return this.name_;
            }

            set
            {
                this.name_ = value;
            }
        }

        public int ID_
        {
            get
            {
                return this.id_;
            }

            set
            {
                this.id_ = value;
            }
        }


        ////USE THIS FOR NOW. ONLY FOR THE XAML 
        //private Color text_Color_;

        //public Color Text_Color_
        //{
        //    get
        //    {
        //        return this.text_Color_;
        //    }

        //    set
        //    {
        //        this.text_Color_ = value;
        //        this.OnPropertyChanged("Text_Color_");
        //        this.SetProperty(ref this.text_Color_, value);
        //    }
        //}
    }
}
