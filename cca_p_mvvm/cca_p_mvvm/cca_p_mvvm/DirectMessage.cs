using System;
using System.Collections.Generic;
using System.Text;

namespace cca_p_mvvm
{
    public class DirectMessage
    {
        private string first_Name_;
        private string last_Name_;

        public string First_Name_
        {
            get
            {
                if(string.IsNullOrEmpty(this.first_Name_))
                {
                    return "Empty string";
                }

                return this.first_Name_;
            }

            set
            {
                this.first_Name_ = value;
            }
        }

        public string Last_Name_
        {
            get
            {
                if(string.IsNullOrEmpty(this.last_Name_))
                {
                    return "Empty string";
                }

                return this.last_Name_;
            }

            set
            {
                this.last_Name_ = value;
            }
        }
    }
}
