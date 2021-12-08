using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch02dataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tboxNumber.Text.ToString());

                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int iNumber = int.Parse(tboxNumber.Text.ToString());

                lblInt.Text = iNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double doubleNumber = double.Parse(tboxNumber.Text.ToString());

                lblDouble.Text = doubleNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnExe_Click(object sender, EventArgs e) // short로 안되면 int로, int가 안되면 double로
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;
            lblException.Text = "-";

            if (short.TryParse(tboxNumber.Text.ToString(), out sNumber))// 파싱 결과를 sNumer에 저장해야하므로 out으로 지정
            {
                lblShort.Text = sNumber.ToString();
            }
            else if (int.TryParse(tboxNumber.Text.ToString(), out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            }
            else if (double.TryParse(tboxNumber.Text.ToString(), out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환할 수 없음";
            }
        }
    }
}
