using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ch13inheritance
{
    class CCar : CCycle
    {
        // 상속 받았으니 생략
        //public Rectangle _rtCircle1; //바퀴
        //public Rectangle _rtCircle2; //바퀴
        //public Rectangle _rtSquare1; // 몸통
        public Rectangle _rtSquare2; //몸통

        public CCar(string sName) : base(sName) //보모 클래스인 CCycle의 생성자를 호출하여 값을 초기화
        {
            strName = sName;
            _Pen = new Pen(Color.Blue, 3);

            _rtCircle1 = new Rectangle(60, 180, 90, 90);
            _rtCircle2 = new Rectangle(210, 180, 90, 90);
            _rtSquare1 = new Rectangle(90, 30, 180, 90);
            _rtSquare2 = new Rectangle(30, 120, 300, 60);
        }

        public new void fMove(int iMove)//22. 부모에 동일한 함수가 있어서 경고 발생, new 추가
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);

            fSquare2Move(iMove);
        }

        protected void fSquare2Move(int iMove)// 23. 상속 받은 함수 외 추가
        {
            Point oPoint = _rtSquare2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare2.Location = oPoint;
        }
    }
}
