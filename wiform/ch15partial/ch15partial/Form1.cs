using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch15partial
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cboxItem.Items.Add(EnumItem.계란.ToString());
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));
            foreach (EnumItem oitem in ei)
            {
                cboxItem.Items.Add(oitem.ToString());
            }

            foreach (EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(oitem.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataResult(); //변수 초기화

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);// 문자 형태로 가지고 있는 Enum 값을 int 형태로 변환 시킴 (Enum을 많이 쓰시면 자주 사용 됩니다.)
            _Data.ICount = (int)numCount.Value;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))   // Error Data가 있을 경우 tboxErrorMsg에 Error 내용을 보여주고 종료
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }

            //Error가 없을 경우 아래 할인 가격을 계산하는 Logic을 수행 후 ListBox에 값을 뿌려줌.

            double dPrice = _Data.fItemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tboxResult.Text = _Data.DTotalPrice.ToString() + "원";
        }
    }
}
