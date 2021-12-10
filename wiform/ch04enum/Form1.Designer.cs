namespace ch04enum
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
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnResultStringFormat = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.Location = new System.Drawing.Point(13, 44);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(161, 199);
            this.lboxDay.TabIndex = 0;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.Location = new System.Drawing.Point(191, 44);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(161, 199);
            this.lboxTime.TabIndex = 0;
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(13, 301);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(339, 93);
            this.tboxResult.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(13, 249);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(117, 39);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnResultStringFormat
            // 
            this.btnResultStringFormat.Location = new System.Drawing.Point(136, 249);
            this.btnResultStringFormat.Name = "btnResultStringFormat";
            this.btnResultStringFormat.Size = new System.Drawing.Size(117, 39);
            this.btnResultStringFormat.TabIndex = 2;
            this.btnResultStringFormat.Text = "String Format Test";
            this.btnResultStringFormat.UseVisualStyleBackColor = true;
            this.btnResultStringFormat.Click += new System.EventHandler(this.btnResultStringFormat_Click);
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(13, 13);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(117, 20);
            this.tboxName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 406);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnResultStringFormat);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnResultStringFormat;
        private System.Windows.Forms.TextBox tboxName;
    }
}

