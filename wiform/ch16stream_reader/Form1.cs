using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // 추가

namespace ch16stream_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n"; //\n is Unix, \r is Mac, \r\n is Windows.

            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();

            sb.Append(strText + strEnter);
            sb.Append(bChecked.ToString() + strEnter);
            sb.Append(iNumber.ToString() + strEnter);

            tboxConfigData.Text = sb.ToString();
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);// 문자열 안에있는 '\r\n'을 기준으로 split 시킴

            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath; // 초기 디렉토리 = 프로그램이 시작되는 경로(exe 파일이 있는 위치)
            SFDialog.FileName = "*.txt"; // 파일 다이얼로그를 열었을 때 디펄트 파일이름
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (tboxConfigData.Text != string.Empty)
            {
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = SFDialog.FileName;
                    File.WriteAllText(strFilePath, tboxConfigData.Text); // 경로에 문자를 읽어서, tbox에 쓴다.
                }
            }
            else
            {
                MessageBox.Show("Empty Config Data");
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                sb.Append(File.ReadAllText(strFilePath));
                tboxConfigData.Text = sb.ToString();
            }
        }
    }
}
