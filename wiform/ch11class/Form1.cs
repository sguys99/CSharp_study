using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch11class
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            // 구조체 인스턴스는 초기화 불가
            public int iCount; // Player가 몇회 진행 중인지
            public int iSun; //해에 대한 값
            public int iMoon; // 달에 대한 값
            public int iStar; //별에 대한 값

            public int iCardSum; // 해, 달, 별을 더한 값

            public int CardSum(int iSun, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string ResultText()
            {
                return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }
        }

        // 실제 사용은 하지 않고 멤버 초기화 가능하다는 것 보여주기 위해
        class classPlayer
        {
            // 멤버 초기화 가능
            public int iCount=0; // Player가 몇회 진행 중인지
            public int iSun=4; //해에 대한 값
            public int iMoon=3; // 달에 대한 값
            public int iStar; //별에 대한 값

            public int iCardSum; // 해, 달, 별을 더한 값

            public int CardSum(int iSun, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string ResultText()
            {
                return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }
        }

        structPlayer _stPlayer1;  //1번 Player
        structPlayer _stPlayer2;  //2번 Player

        Random _rd = new Random();  // 난수 발생용

        classPlayer _clPlayer1 = new classPlayer();  //Test 용 
        classPlayer _clPlayer2 = new classPlayer();  //Test 용 


        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)//선택되었으면 true
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)//선택되었으면 true
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }

            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)//선택되었으면 true
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();
        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            // 아무짓도 안하고 한턴을 넘긴다

            Result();
        }

        private void Result()
        {
            string strResult = string.Empty;

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;  // Player에 대한 진행 횟수를 증가

                _stPlayer1.iCardSum = _stPlayer1.CardSum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);  // 해, 달, 별의 값을 더해서 Player에 ICradSum에 넣어줌

                strResult = _stPlayer1.ResultText();  // 결과 값을 string 형태로 변환

                lboxResult1.Items.Add(strResult);  // 결과 값을 listbox에 등록
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = _stPlayer2.CardSum(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = _stPlayer2.ResultText();

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();  // 다음 Player 선택

            // 결과를 체크 (Player1과 2의 진행 횟수가 5회가 넘어갈 경우 각 Player의 iCard Sum 값을 비교해서 결과를 화면에 Popup 합니다.
            if (_stPlayer1.iCount >= 5 && _stPlayer2.iCount >= 5)
            {
                if (_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player1이 이겼습니다.");
                }
                else if (_stPlayer1.iCardSum < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player2가 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }

        private void iCheckedChange()
        {
            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }
    }
    
}
