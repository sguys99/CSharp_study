namespace Server
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ServerPort = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.txt_ServerPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "접속대기 포트";
            // 
            // txt_ServerPort
            // 
            this.txt_ServerPort.Location = new System.Drawing.Point(105, 17);
            this.txt_ServerPort.Name = "txt_ServerPort";
            this.txt_ServerPort.Size = new System.Drawing.Size(84, 20);
            this.txt_ServerPort.TabIndex = 1;
            this.txt_ServerPort.Text = "1004";
            this.txt_ServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(206, 16);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(110, 26);
            this.button.TabIndex = 2;
            this.button.Text = "연결대기";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Message.Location = new System.Drawing.Point(0, 55);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(585, 284);
            this.txt_Message.TabIndex = 1;
            this.txt_Message.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 339);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox txt_ServerPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_Message;
    }
}

