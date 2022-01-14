namespace ChatClient
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rt_Message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ServerIP = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.txt_Port);
            this.panel1.Controls.Add(this.txt_ServerIP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Send);
            this.panel2.Controls.Add(this.txt_message);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 55);
            this.panel2.TabIndex = 1;
            // 
            // rt_Message
            // 
            this.rt_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_Message.Location = new System.Drawing.Point(0, 100);
            this.rt_Message.Name = "rt_Message";
            this.rt_Message.Size = new System.Drawing.Size(689, 253);
            this.rt_Message.TabIndex = 2;
            this.rt_Message.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "서버IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자명";
            // 
            // txt_ServerIP
            // 
            this.txt_ServerIP.Location = new System.Drawing.Point(82, 21);
            this.txt_ServerIP.Name = "txt_ServerIP";
            this.txt_ServerIP.Size = new System.Drawing.Size(100, 20);
            this.txt_ServerIP.TabIndex = 4;
            this.txt_ServerIP.Text = "127.0.0.1";
            this.txt_ServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(82, 55);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 4;
            this.txt_user.Text = "1234";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "포트";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(280, 21);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 20);
            this.txt_Port.TabIndex = 4;
            this.txt_Port.Text = "1004";
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(411, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 58);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(549, 19);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(110, 58);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "종료";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "사용자명";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(82, 18);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(447, 20);
            this.txt_message.TabIndex = 4;
            this.txt_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_message_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(549, 10);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(110, 34);
            this.btn_Send.TabIndex = 5;
            this.btn_Send.Text = "보내기";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 408);
            this.Controls.Add(this.rt_Message);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_ServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rt_Message;
    }
}

