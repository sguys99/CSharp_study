using System;
using System.Collections.Generic;//List가 포함
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;//ArrayList 사용위해

namespace ch21array_list
{
    public partial class Form1 : Form
    {

        List<string> _strList = new List<string>(); // 타입 선언필요, 클릭한 이미지의 텍스트를 저장
        ArrayList _arList = new ArrayList(); // 값 입력 시 타입 지정

        public Form1()
        {
            InitializeComponent();

            dgViewList.Columns.Add("dgValue", "Value");// 컬럼명, 텍스트
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = (PictureBox)sender;
            //PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = "cake";
                    break;
                case "pbox2":
                    strSelectText = "burger";
                    break;
                case "pbox3":
                    strSelectText = "pizza";
                    break;
                case "pbox4":
                    strSelectText = "ice";
                    break;
            }

            _strList.Add(strSelectText);

            fUIDisplay();
            fDataGridViewDisplay();
        }

        private void fUIDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza = 0;
            int iIce = 0;

            foreach (string oitem in _strList)
            {
                switch (oitem)
                {
                    case "cake":
                        iCake++;
                        break;
                    case "burger":
                        iBurger++;
                        break;
                    case "pizza":
                        iPizza++;
                        break;
                    case "ice":
                        iIce++;
                        break;
                }
            }

            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();

            lblTotalCount.Text = _strList.Count.ToString();
        }

        private void fDataGridViewDisplay()
        {
            dgViewList.Rows.Clear();

            foreach (string oitem in _strList)
            {
                dgViewList.Rows.Add(oitem);
            }

            foreach (DataGridViewRow oRow in dgViewList.Rows)//?
            {
               oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders); //??
        }
    }
}
