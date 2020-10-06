using System;
using System.Collections.Generic;
using System.Text;

namespace cca_p_mvvm
{
    public class Channel
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
    }
}
