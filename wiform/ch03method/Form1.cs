using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch03method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA =0,  iNumB = 0;
            if (int.TryParse(tboxNum1.Text.ToString(), out iNumA) && int.TryParse(tboxNum2.Text.ToString(), out iNumB))
            {
                tboxResult.Text = fPlus(iNumA, iNumB).ToString();
            }
            else
            {
                MessageBox.Show("Please check input!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = 0, iNumB = 0;
            if (int.TryParse(tboxNum1.Text.ToString(), out iNumA) && int.TryParse(tboxNum2.Text.ToString(), out iNumB))
            {
                tboxResult.Text = fMinus(iNumA, iNumB).ToString();
            }
            else
            {
                MessageBox.Show("Please check input!");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iNumA = 0, iNumB = 0;
            if (int.TryParse(tboxNum1.Text.ToString(), out iNumA) && int.TryParse(tboxNum2.Text.ToString(), out iNumB))
            {
                tboxResult.Text = fMulti(iNumA, iNumB).ToString();
            }
            else
            {
                MessageBox.Show("Please check input!");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iNumA = 0, iNumB = 0;
            if (int.TryParse(tboxNum1.Text.ToString(), out iNumA) && int.TryParse(tboxNum2.Text.ToString(), out iNumB))
            {
                tboxResult.Text = fDivide(iNumA, iNumB).ToString();
            }
            else
            {
                MessageBox.Show("Please check input!");
            }
        }

        private int fPlus(int iA, int iB)
        {
            return iA + iB;
        }

        private int fMinus(int iA, int iB)
        {
            return iA - iB;
        }

        private int fMulti(int iA, int iB)
        {
            return iA * iB;
        }

        private int fDivide(int iA, int iB)
        {
            return iA / iB;
        }
    }
}
