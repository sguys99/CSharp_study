using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CPL = _12_Class;

namespace ch12class2
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int iCount;

            public int iSun;
            public int iMoon;
            public int iStar;

            public int iCardSum;
        }

        Random _rd = new Random();

        structPlayer _sp1; //Player1 생성
        structPlayer _sp2;

        CPL.CPlayer _clPlayer = new CPL.CPlayer(); // 수식 및 결과 계산용

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                //_clPlayer1.iSun = iNumber;
                _sp1.iSun = iNumber;   // 구조체가 선택 된 Card의 값을 넣어 줌 (이하 같은 항목의 경우도 동일)

            }
            else
            {
                //_clPlayer2.iSun = iNumber;
                _sp2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _sp1.iMoon = iNumber;
            }
            else
            {
                _sp2.iMoon = iNumber;
            }

            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                _sp1.iStar = iNumber;
            }
            else
            {
                _sp2.iStar = iNumber;
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
                _sp1.iCount++;  // Player에 대한 진행 횟수를 증가

                _sp1.iCardSum = _clPlayer.CardSum(_sp1.iSun, _sp1.iMoon, _sp1.iStar);  // Player Class에서 해, 달, 별의 값을 더하는 함수를 호출, 계산 후 결과를 Player 1 CardSum에 넣어 줌

                strResult = _clPlayer.ResultText(_sp1.iCount, _sp1.iSun, _sp1.iMoon, _sp1.iStar, _sp1.iCardSum);  // Player Class에서 결과 값을 string 형태로 변환하는 함수를 호출

                lboxResult1.Items.Add(strResult);  // 결과 값을 listbox에 등록
            }
            else
            {
                _sp2.iCount++;

                _sp2.iCardSum = _clPlayer.CardSum(_sp2.iSun, _sp2.iMoon, _sp2.iStar);

                strResult = _clPlayer.ResultText(_sp2.iCount, _sp2.iSun, _sp2.iMoon, _sp2.iStar, _sp2.iCardSum);

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();  // 다음 Player 선택

            // 결과를 체크 Player1과 Player2의 진행 횟수가 같을 경우 ( => 게임의 한턴이 진행 되었을 경우)
            if (_sp1.iCount == _sp2.iCount)
            {
                lboxNow.Items.Add(_clPlayer.PlayerPair(_sp2.iCount, _sp1.iCardSum, _sp2.iCardSum));   // Player Class에서 두 Player의 Card 합을 비교하는 함수를 호출 후 결과를 List Box에 넣어 줌

                if (_sp2.iCount >= 5)   // 게임 횟수가 5턴이 마무리 되었을 경우 ( => 위에서 Player 1과 Player 2의 횟수가 같을 경우만 체크 함으로 Player1의 횟수나 2의 횟수 중 아무 횟수나 확인 해도 상관 없음)
                {
                    lboxNow.Items.Add(_clPlayer.PlayerResult(_sp1.iCardSum, _sp2.iCardSum));  // Player Class에서 게임 결과를 가져오는 함수를 호출 후 List Box에 넣어줌
                }
            }
        }

        private void iCheckedChange()
        {
            //어떤 Player가 선택 되어 있는지 확인
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;   // 선택 되어 있지 않은 Player를 선택 하도록 함
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }
    }
}
