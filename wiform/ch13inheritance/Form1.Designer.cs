namespace ch13inheritance
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
            this.pMain = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOneCycle = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.DarkGray;
            this.pMain.Location = new System.Drawing.Point(13, 13);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(775, 353);
            this.pMain.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Gray;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(13, 373);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 34);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "-";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOneCycle
            // 
            this.btnOneCycle.Location = new System.Drawing.Point(162, 373);
            this.btnOneCycle.Name = "btnOneCycle";
            this.btnOneCycle.Size = new System.Drawing.Size(122, 34);
            this.btnOneCycle.TabIndex = 2;
            this.btnOneCycle.Text = "1단계 : 외발 자전거";
            this.btnOneCycle.UseVisualStyleBackColor = true;
            this.btnOneCycle.Click += new System.EventHandler(this.btnOneCycle_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(290, 372);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(122, 34);
            this.btnCycle.TabIndex = 2;
            this.btnCycle.Text = "2단계 : 자전거";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(418, 372);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(122, 34);
            this.btnCar.TabIndex = 2;
            this.btnCar.Text = "3단계 : 자동차";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(225, 429);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(122, 51);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<--";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(353, 429);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(122, 51);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "-->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnOneCycle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOneCycle;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}

