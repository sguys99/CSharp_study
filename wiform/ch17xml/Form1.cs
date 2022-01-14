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

namespace ch17xml
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();

        Dictionary<string, string> _dData = new Dictionary<string, string>();

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
            //여기까지 기존과 동일

            //화면뒤 Dictionary에 데이터를 저장함
            _dData.Clear(); //초기화
            _dData.Add(CXMLControl._TEXT_DATA, strText);// 주의  : 클래서에서 _TEXT_DATA 등을 static으로 선언했으므로 인스턴스가 아니라 CXMLControl._TEXT_DATA 형태로 가져와야함
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());

        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            //string[] strConfig = tboxConfigData.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);// 문자열 안에있는 '\r\n'을 기준으로 split 시킴

            //tboxData.Text = strConfig[0];
            //cboxData.Checked = bool.Parse(strConfig[1]);
            //numData.Value = int.Parse(strConfig[2]);

            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;// 프로그램 시작경로
            SFDialog.FileName = "*.xml"; // xml 파일로 수정
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"; //xml 파일로 수정

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
                //File.WriteAllText(strFilePath, tboxConfigData.Text); 이것 대신 다른것 사용
                _XML.fXML_Writer(strFilePath, _dData);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.xml"; //수정
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";//수정

            StringBuilder sb = new StringBuilder();

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                sb.Append(File.ReadAllText(strFilePath));

                tboxConfigData.Text = sb.ToString();

                //추가
                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }
    }
}
