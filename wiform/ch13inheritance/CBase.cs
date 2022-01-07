using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; // Pen 사용위해

namespace ch13inheritance
{
    class CBase
    {
        public string strName;
        protected Pen _Pen; ////클래스 내부에서 사용, protect는 상속가능, private는 상속불가

        public CBase()
        {
            _Pen = new Pen(Color.Aqua);
        }
    }
}
