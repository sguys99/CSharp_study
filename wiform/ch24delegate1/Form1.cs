using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch24delegate1
{
    public partial class Form1 : Form
    {

        public delegate int delFuncDow_Edge(int i); //델리게이트 정의
        public delegate int delFuncTopping(string strOrder, int Ea);

        int _iTotalPrice = 0; // 전체가격

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFuncTopping delTopping = null; // 나중에 정의해도 됨

            // 델리게이트 사용
            int iDowOrder = 0;
            int iEdgeOrder = 0;

            if (rdoDow1.Checked)
            {
                iDowOrder = 1;
            }
            else if (rdoDow2.Checked)
            {
                iDowOrder = 2;
            }

            delDow(iDowOrder); // 델리게이트 사용

            if (rdoEdge1.Checked)
            {
                iEdgeOrder = 1;
            }
            else if(rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
            }

            delEdge(iEdgeOrder);

            if (cboxTopping1.Checked)
            {
                delTopping += fTopping1; // 델리게이트 체인
            }

            if (cboxTopping2.Checked) delTopping += fTopping2;
            if (cboxTopping3.Checked) delTopping += fTopping3;

            if (delTopping == null)
            {
                lboxOrder.Items.Add("토핑을 선택하지 않았습니다.");
            }
            else
            {
                delTopping("토핑", (int)numEa.Value); //체인을 구성할 때 함수의 인자가 같은 타입이어야 한다.
            }
            

            lboxOrder.Items.Add("--------------------------------------------");
            lboxOrder.Items.Add(string.Format("전체 주문 가격은 {0}원 입니다.", _iTotalPrice));
        }

        #region Function
        // 영역 묶어놓기

        /// <summary>
        /// 0: 선택안함, 1: 오리지널, 2: 씬
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }

            lboxOrder.Items.Add(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }


        /// <summary>
        /// 0: 선택안함, 1: 리치골드, 2: 치즈크러스터
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드를 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치즈크러스터를 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
            }

            lboxOrder.Items.Add(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        private int fTopping1(string Order, int iEA)
        {
            string strOrder = string.Empty;
            int iPrice = iEA * 500;

            strOrder = string.Format("소세지 {0} {1}개를 선택하였습니다. : ({2}원 (1ea 500원)", Order, iEA, iPrice);
            lboxOrder.Items.Add(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        private int fTopping2(string Order, int iEA)
        {
            string strOrder = string.Empty;
            int iPrice = iEA * 200;

            strOrder = string.Format("감자 {0} {1}개를 선택하였습니다. : ({2}원 (1ea 200원)", Order, iEA, iPrice);
            lboxOrder.Items.Add(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }

        private int fTopping3(string Order, int iEA)
        {
            string strOrder = string.Empty;
            int iPrice = iEA * 300;

            strOrder = string.Format("치즈 {0} {1}개를 선택하였습니다. : ({2}원 (1ea 300원)", Order, iEA, iPrice);
            lboxOrder.Items.Add(strOrder);

            return _iTotalPrice = _iTotalPrice + iPrice;
        }
        #endregion
    }
}
