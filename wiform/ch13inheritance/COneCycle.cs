using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ch13inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1; //바퀴
        public Rectangle _rtSquare1; //몸통

        public COneCycle(string sName) //strName, _Pen은 베이스에 선언
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3); //브러시, 굵기

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPenInfo()
        {
            return _Pen;
        }

        public void fMove(int iMove) //5
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        protected void fCircle1Move(int iMove)//5
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }

        protected void fSquare1Move(int iMove)//6
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }
    }
}
