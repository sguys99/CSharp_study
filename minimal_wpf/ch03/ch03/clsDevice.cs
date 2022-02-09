using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    public enum enumIO { ON, OFF }
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


    class clsPLC : clsDevice
    {
        public enumIO IO { get; set; } //enum 변수 생성
        public clsPLC()
        {
            this.NAME = "PLC1";
        }

        public override void Read()
        {
            Console.WriteLine(this.NAME);
        }

        public override void Write()
        {
            //Console.WriteLine("PLC WRITE");
        }
    }


    class clsMOUSE : clsDevice
    {
        public int X { get; set; }
        public int Y { get; set; }

        public clsMOUSE()
        {
            this.NAME = "MOUSE1";
            this.X = 10;
            this.Y = 20;
        }

        public override void Read()
        {
            Console.WriteLine(this.NAME);
        }

        public override void Write()
        {
            //this.NAME = "MOUSE1";
        }
    }
}
