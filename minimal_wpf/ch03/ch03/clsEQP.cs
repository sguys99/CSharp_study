using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace ch03
{
    class clsEQP
    {
        public ObservableCollection<clsDevice> DEV = new ObservableCollection<clsDevice>();
        public clsEQP()
        { 
        
        }

        public void ADD(string type)
        {
            if (type == "PLC")
            {
                this.DEV.Add(new clsPLC());
            }
            else if (type == "MOUSE")
            {
                this.DEV.Add(new clsMOUSE());
            }
        }
    }
}
