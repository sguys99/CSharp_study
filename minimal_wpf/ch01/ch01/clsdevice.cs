using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch01
{
    class clsdevice
    {
        private string NAME_ = "TEST";
        public string NAME
        {
            get 
            {
                return NAME_;
            }

            set 
            {
                NAME_ = value;
            }
        }
    }
}
