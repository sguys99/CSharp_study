using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch01string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strText = lblText.Text.ToString();

            lblContain.Text = strText.Contains("Text").ToString();// 문자열이 아니므로 ToString 필요, True/ False
            lblEqual.Text = strText.Equals("Test").ToString(); // 문자열이 Test와 같은지, True/ False
            lblLength.Text = strText.Length.ToString(); //길이
            lblReplace.Text = strText.Replace("Test", "I Can").ToString();

            string[] strSplit = strText.Split(','); // , 로 나누어 배열에 저장
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            lblSubstring.Text = strText.Substring(3, 5).ToString(); // 4, 5, 6번째 문자 출력
            lblToLower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper().ToString();
            lblTrim.Text = strText.Trim().ToString(); //공백삭제

            lblString.Text = lblText.ToString();
            lblStringText.Text = lblText.Text.ToString();
        }
    }
}
