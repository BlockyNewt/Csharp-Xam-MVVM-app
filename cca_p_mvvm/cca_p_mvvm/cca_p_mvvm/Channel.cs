using System;
using System.Collections.Generic;
using System.Text;

namespace cca_p_mvvm
{
    public class Channel
    {
        private string name_;

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
    }
}
