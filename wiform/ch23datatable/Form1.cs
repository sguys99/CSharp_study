using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch23datatable
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckIstable = false; //dataset 안에 해당하는 데이터 테이블이 있는지 있으면 True

            if (ds.Tables.Contains(cboxRegClass.Text)) // 데이터셋 안에 해당하는 datatable(1반, 2반, ....) 이 있는지 확인
            {
                bCheckIstable = true;
            }

            //foreach (DataTable oTable in ds.Tables)// 데이터셋 안에 해당하는 datatable(1반, 2반, ....) 이 있는지 확인
            //{
            //    if (ds.Tables.Contains(cboxRegClass.Text)) 
            //    {
            //        bCheckIstable = true;
            //        break;
            //    }
            //}

            DataTable dt = null;

            if (!bCheckIstable) // 기존 테이블이 없을 경우 신규 생성
            {
                dt = new DataTable(cboxRegClass.Text); // cboxRegClass.Text를 이름으로 하여 클래스 생성

                // 컬럼 생성
                DataColumn colName = new DataColumn("Name", typeof(string));// 컬럼이름과 데이터 타입 지정  
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName); // 컬럼을 dt에 추가
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else // 기존에 테이블이 있을 경우, 기존 테이블을 가져온다.
            {
                dt = ds.Tables[cboxRegClass.Text];
            }

            // Row 생성
            DataRow row = dt.NewRow();
            row["Name"] = tboxRegName.Text;

            if (rdoRegSexFemale.Checked)
            {
                row["SEX"] = "여자";
            }
            else if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }

            row["REF"] = tboxRegRef.Text;

            //dt.Rows.Add(row);

            //ds.Tables.Add(dt);
            //if (bCheckIsTalble)
            //{
            //    ds.Tables.Remove(cboxRegClass.Text);
            //    ds.Tables.Add(dt);
            //}

            if (bCheckIstable) //이미 테이블이 있으면
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row); // 기존 테이블에 데이터 추가
            }
            else
            {
                dt.Rows.Add(row); // 신규로 작성한 테이블에 row 추가
                ds.Tables.Add(dt); // 등록한 datatable을 dataset에 추가
            }

            cboxViewClass_SelectedIndexChanged(this, null); // 이벤트 핸들러, 콤보박스가 바뀌면 실행됨

        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;  // 선택 한 Row 중에서 첫번째 Row번호를 가져온다
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);   // Table에서 선택한 Row를 삭제 한다

            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows) // row의 인덱스에 번호 표시
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

        }

        private void btnModify_Click(object sender, EventArgs e)// 같은 이름을 가지는 row를 찾아서 수정
        {
            if (!string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach (DataRow oitem in ds.Tables[cboxRegClass.Text].Rows)
                {
                    if (oitem["NAME"].Equals(tboxRegName.Text))
                    {
                        if (rdoRegSexFemale.Checked)
                        {
                            oitem["SEX"] = "여자";
                        }
                        else if (rdoRegSexMale.Checked)
                        {
                            oitem["SEX"] = "남자";
                        }

                        oitem["REF"] = tboxRegRef.Text;
                    }
                }

                cboxViewClass_SelectedIndexChanged(this, null);
            }
        }
    }
}
