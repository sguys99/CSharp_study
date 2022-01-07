using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch13inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC; //1. 전역으로 선언
        CCycle _cC; //10
        CCar _cCar;//24

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발자전거"); //2
            _cC = new CCycle("자전거"); //11
            _cCar = new CCar("자동차"); //25
        }

        private void btnOneCycle_Click(object sender, EventArgs e)//5. 외발자전거 그리기
        {
            //Graphics g = pMain.CreateGraphics(); //판넬에 그림판을 생성
            //Pen p = new Pen(Color.Aqua);
            //g.DrawRectangle(p, 50, 50, 100, 150);
            //COneCycle cOC = new COneCycle("외발 자전거"); // 1. 그런데 버튼을 누를때마다 클래스를 생성할 필요는 없다. form load할 때 생성하는것으로 빼자

            fClearPanel();
            fOneCycleDraw();

        }

        private void fClearPanel()//3 그림 삭제 구현
        {
            pMain.Invalidate();
            Refresh(); //그림 지우기
        }

        private void fOneCycleDraw()// 4. 그리기 함수화
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = _cOC.fPenInfo();

            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }

        private void btnCycle_Click(object sender, EventArgs e)//12
        {
            fClearPanel();
            fCyCleDraw();
        }

        private void fCyCleDraw()//13
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = _cC.fPenInfo();

            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        private void btnCar_Click(object sender, EventArgs e)//26
        {
            fClearPanel();
            fCarDraw();
        }

        private void fCarDraw()//27
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = _cCar.fPenInfo();

            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }

        private void btnLeft_Click(object sender, EventArgs e)//7
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발자전거":
                    _cOC.fMove(-5);
                    fOneCycleDraw();
                    break;
                case "자전거"://14
                    _cC.fMove(-5);
                    fCyCleDraw();
                    break;
                case "자동차"://28
                    _cCar.fMove(-5);
                    fCarDraw();
                    break;

                default:
                    break;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)//8
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발자전거":
                    _cOC.fMove(5);
                    fOneCycleDraw();
                    break;
                case "자전거"://14
                    _cC.fMove(5);
                    fCyCleDraw();
                    break;
                case "자동차"://29
                    _cCar.fMove(5);
                    fCarDraw();
                    break;

                default:
                    break;
            }
        }

       
    }
}
