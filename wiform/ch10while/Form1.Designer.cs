namespace ch10while
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblwhileResult = new System.Windows.Forms.Label();
            this.lboxwhileResult = new System.Windows.Forms.ListBox();
            this.btnwhileResult = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxResult = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.btndowhileResult = new System.Windows.Forms.Button();
            this.lbldowhileResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblwhileResult
            // 
            this.lblwhileResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblwhileResult.ForeColor = System.Drawing.Color.White;
            this.lblwhileResult.Location = new System.Drawing.Point(16, 13);
            this.lblwhileResult.Name = "lblwhileResult";
            this.lblwhileResult.Size = new System.Drawing.Size(330, 35);
            this.lblwhileResult.TabIndex = 0;
            this.lblwhileResult.Text = "0, 0, 0, 0, 0, 0";
            this.lblwhileResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxwhileResult
            // 
            this.lboxwhileResult.FormattingEnabled = true;
            this.lboxwhileResult.Location = new System.Drawing.Point(16, 56);
            this.lboxwhileResult.Name = "lboxwhileResult";
            this.lboxwhileResult.Size = new System.Drawing.Size(330, 199);
            this.lboxwhileResult.TabIndex = 1;
            // 
            // btnwhileResult
            // 
            this.btnwhileResult.Location = new System.Drawing.Point(352, 12);
            this.btnwhileResult.Name = "btnwhileResult";
            this.btnwhileResult.Size = new System.Drawing.Size(102, 36);
            this.btnwhileResult.TabIndex = 2;
            this.btnwhileResult.Text = "로또 번호";
            this.btnwhileResult.UseVisualStyleBackColor = true;
            this.btnwhileResult.Click += new System.EventHandler(this.btnwhileResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(16, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 10);
            this.panel1.TabIndex = 3;
            // 
            // tboxResult
            // 
            this.tboxResult.AutoSize = true;
            this.tboxResult.Location = new System.Drawing.Point(16, 286);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(157, 13);
            this.tboxResult.TabIndex = 4;
            this.tboxResult.Text = "1~100 안의 숫자를 선택하세요";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(16, 314);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(83, 20);
            this.tboxNumber.TabIndex = 5;
            this.tboxNumber.Text = "1";
            // 
            // btndowhileResult
            // 
            this.btndowhileResult.Location = new System.Drawing.Point(138, 310);
            this.btndowhileResult.Name = "btndowhileResult";
            this.btndowhileResult.Size = new System.Drawing.Size(154, 23);
            this.btndowhileResult.TabIndex = 6;
            this.btndowhileResult.Text = "선택 번호 뽑기";
            this.btndowhileResult.UseVisualStyleBackColor = true;
            this.btndowhileResult.Click += new System.EventHandler(this.btndowhileResult_Click);
            // 
            // lbldowhileResult
            // 
            this.lbldowhileResult.AutoSize = true;
            this.lbldowhileResult.Location = new System.Drawing.Point(16, 358);
            this.lbldowhileResult.Name = "lbldowhileResult";
            this.lbldowhileResult.Size = new System.Drawing.Size(10, 13);
            this.lbldowhileResult.TabIndex = 4;
            this.lbldowhileResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 409);
            this.Controls.Add(this.btndowhileResult);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.lbldowhileResult);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnwhileResult);
            this.Controls.Add(this.lboxwhileResult);
            this.Controls.Add(this.lblwhileResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwhileResult;
        private System.Windows.Forms.ListBox lboxwhileResult;
        private System.Windows.Forms.Button btnwhileResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tboxResult;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button btndowhileResult;
        private System.Windows.Forms.Label lbldowhileResult;
    }
}

