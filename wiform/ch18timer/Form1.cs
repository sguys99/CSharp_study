using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch18timer
{
    public partial class Form1 : Form
    {
        private double iTick = 0; // 한 tick당 더할 값
        private double iTotal = 0; // 전체 값

        private int i1Add = 1; // 1* LEVEL 값
        private int i1Level = 1;

        private int i3Add = 3; // 3* LEVEL 값
        private int i3Level = 1;

        private int i50Add = 0; // 50* LEVEL 값
        private int i50Level = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer oTimer = new Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 100; //0.1초마다 호출
            oTimer.Tick += OTimer_Tick; //0.1초마다 이벤트 함수 호출
            oTimer.Start(); // 타이머 호출
        }

        private void OTimer_Tick(object sender, EventArgs e)
        {
            iTick = i1Add + i3Add + i50Add;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button; //sender에 버튼 오브젝트가 담겨 있는데 Button 클래스로 형변환

            // UI 작성 시 지정한 Name을 기준으로 Event가 발생 한 Button을 찾아서 프로그램 동작 수행
            switch (obtn.Name)
            {
                case "btn1add":
                    if (iTotal > 100)
                    {
                        iTotal = iTotal - 100;

                        i1Level++;
                        i1Add = 1 * i1Level;
                    }
                    break;
                case "btn3add":
                    if (iTotal > 300)
                    {
                        iTotal = iTotal - 300;

                        i3Level++;
                        i3Add = 3 * i3Level;
                    }
                    break;
                case "btn50add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 5000;

                        i50Level++;
                        i50Add = 50 * i50Level;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
