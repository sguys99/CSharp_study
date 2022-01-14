namespace ch18timer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTickPoint = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn1add = new System.Windows.Forms.Button();
            this.btn3add = new System.Windows.Forms.Button();
            this.btn50add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblTickPoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "점수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIck Point : ";
            // 
            // lblTickPoint
            // 
            this.lblTickPoint.BackColor = System.Drawing.Color.White;
            this.lblTickPoint.Location = new System.Drawing.Point(78, 29);
            this.lblTickPoint.Name = "lblTickPoint";
            this.lblTickPoint.Size = new System.Drawing.Size(351, 21);
            this.lblTickPoint.TabIndex = 0;
            this.lblTickPoint.Text = "0";
            this.lblTickPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.DarkGray;
            this.lblTotal.Location = new System.Drawing.Point(10, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(419, 123);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1add
            // 
            this.btn1add.Location = new System.Drawing.Point(13, 233);
            this.btn1add.Name = "btn1add";
            this.btn1add.Size = new System.Drawing.Size(213, 41);
            this.btn1add.TabIndex = 1;
            this.btn1add.Text = "+1";
            this.btn1add.UseVisualStyleBackColor = true;
            this.btn1add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn3add
            // 
            this.btn3add.Location = new System.Drawing.Point(12, 289);
            this.btn3add.Name = "btn3add";
            this.btn3add.Size = new System.Drawing.Size(213, 41);
            this.btn3add.TabIndex = 1;
            this.btn3add.Text = "+3";
            this.btn3add.UseVisualStyleBackColor = true;
            this.btn3add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn50add
            // 
            this.btn50add.Location = new System.Drawing.Point(13, 345);
            this.btn50add.Name = "btn50add";
            this.btn50add.Size = new System.Drawing.Size(213, 41);
            this.btn50add.TabIndex = 1;
            this.btn50add.Text = "+50";
            this.btn50add.UseVisualStyleBackColor = true;
            this.btn50add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "(100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "(500)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "(5000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 396);
            this.Controls.Add(this.btn50add);
            this.Controls.Add(this.btn3add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn1add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTickPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1add;
        private System.Windows.Forms.Button btn3add;
        private System.Windows.Forms.Button btn50add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

