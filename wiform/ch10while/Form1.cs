using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwhileResult_Click(object sender, EventArgs e)
        {
            int[] iArray = new int[6]; // 0으로 자동 초기화됨
            int iCount = 0;

            StringBuilder sb = new StringBuilder();// 길이를 알수없는 문자열을 관리할 때 유용. 짧은 것은 string이 유용
            Random rd = new Random();

            while (Array.IndexOf(iArray, 0) != -1)//Array.IndexOf 함수 : iArray에 0이 검색되면 처음 검색된것의 index를, 없으면 -1을 리턴
            {
                int iNumber = rd.Next(1, 46);// 해당 범위 내의 임의의 수를 리턴

                if (Array.IndexOf(iArray, iNumber) == -1) // 중복이 없을 때만 저장
                {
                    iArray[iCount] = iNumber;
                    iCount++;
                }
            }

            Array.Sort(iArray); //배열을 정렬

            foreach (int iNum in iArray)
            {
                sb.Append(string.Format("{0}, ", iNum));
            }

            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }

        private void btndowhileResult_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iNumber;

            if (int.TryParse(tboxNumber.Text, out iNumber))
            {
                if (iNumber < 1 || iNumber > 100)
                {
                    MessageBox.Show("범위를 초과하였습니다.");
                }

                int iCheckNumber = 0;
                int iCount = 0;

                do
                {
                    iCheckNumber = rd.Next(1, 101);
                    iCount++;
                } while (iNumber != iCheckNumber);

                lbldowhileResult.Text = string.Format("- 뽑은 숫자 {0}을 {1}회만에 찾았습니다.", iNumber, iCount);
                  
            }
            else
            {
                MessageBox.Show("Enter the Number");
            }
        }
    }
}
