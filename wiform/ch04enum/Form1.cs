using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch04enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)// 초기화, form 더블클릭하면 자동생성
        {
            //방법1
            //lboxDay.Items.Add(enumDay.Monday.ToString());//ToString 생략가능
            //lboxDay.Items.Add(enumDay.Monday.ToString());//ToString 생략가능
            //lboxDay.Items.Add(enumDay.Tuesday);
            //lboxDay.Items.Add(enumDay.Wednesday);
            //lboxDay.Items.Add(enumDay.Thursday);
            //lboxDay.Items.Add(enumDay.Friday);
            //lboxDay.Items.Add(enumDay.Saturday);
            //lboxDay.Items.Add(enumDay.Sunday);

            //lboxTime.Items.Add(enumTime.Morning);
            //lboxTime.Items.Add(enumTime.Afternoon);
            //lboxTime.Items.Add(enumTime.Evening);

            // 방법2
            //int count = Enum.GetValues(typeof(enumDay)).Length;

            //for (int i = 0; i < count; i++)
            //{
            //    lboxDay.Items.Add(Enum.GetName(typeof(enumDay), i));
            //}

            // 방법3. 추천
            foreach (enumDay day in Enum.GetValues(typeof(enumDay)))
            {
                lboxDay.Items.Add(day.ToString());
            }

            foreach (enumTime time in Enum.GetValues(typeof(enumTime)))
            {
                lboxTime.Items.Add(time.ToString());
            }


        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //준호와 monday(요일) Afternoon에 보기로 했습니다.
            //string strResult = tboxName.Text + "와 " + lboxDay.SelectedItem.ToString() + "(요일) " + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";
            //tboxResult.Text = strResult;

            if (!string.IsNullOrEmpty(tboxName.Text) && lboxDay.SelectedIndex != -1 && lboxTime.SelectedIndex != -1)
            {
                string strResult = tboxName.Text + "와 " + lboxDay.SelectedItem.ToString() + "(요일) " + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";
                tboxResult.Text = strResult;
            }
            else
            {
                MessageBox.Show("Check Missing values or items");
            }
        }

        private void btnResultStringFormat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxName.Text) && lboxDay.SelectedIndex != -1 && lboxTime.SelectedIndex != -1)
            {
                string strResult = String.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
                tboxResult.Text = strResult;
            }
            else
            {
                MessageBox.Show("Check Missing values or items");
            }
        }
    }
}
