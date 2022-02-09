using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02
{
    abstract class clsDevice
    {
        private string NAME_ = "DEVICE";

        public string NAME
        {
            get 
            {
                return this.NAME_;
            }

            set 
            {
                this.NAME_ = value;
            }
        }

        public abstract void Read();

        public abstract void Write();
    }


    class clasPLC : clsDevice
    {
        public clasPLC()
        { 
        
        }

        public override void Read()
        {
            Console.WriteLine(this.NAME);
        }

        public override void Write()
        {
            Console.WriteLine("PLC WRITE");
        }
    }


    class clsMOUSE : clsDevice
    {
        public clsMOUSE()
        { 
        
        }

        public override void Read()
        {
            Console.WriteLine(this.NAME);
        }

        public override void Write()
        {
            this.NAME = "MOUSE1";
        }
    }
}
