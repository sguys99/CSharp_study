namespace TCP_Client
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
            this.tb_receive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_connect = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.tb_writeline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(13, 13);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.ReadOnly = true;
            this.tb_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_receive.Size = new System.Drawing.Size(324, 369);
            this.tb_receive.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP :";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(397, 16);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(115, 20);
            this.tb_ip.TabIndex = 2;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "PORT :";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(397, 58);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(115, 20);
            this.tb_port.TabIndex = 2;
            this.tb_port.Text = "5000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(397, 101);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(115, 20);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.Text = "Client";
            // 
            // tb_connect
            // 
            this.tb_connect.Location = new System.Drawing.Point(397, 150);
            this.tb_connect.Name = "tb_connect";
            this.tb_connect.Size = new System.Drawing.Size(114, 35);
            this.tb_connect.TabIndex = 3;
            this.tb_connect.Text = "접속";
            this.tb_connect.UseVisualStyleBackColor = true;
            this.tb_connect.Click += new System.EventHandler(this.tb_connect_Click);
            // 
            // bt_send
            // 
            this.bt_send.Enabled = false;
            this.bt_send.Location = new System.Drawing.Point(388, 417);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(114, 27);
            this.bt_send.TabIndex = 3;
            this.bt_send.Text = "전송";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tb_writeline
            // 
            this.tb_writeline.Location = new System.Drawing.Point(13, 419);
            this.tb_writeline.Name = "tb_writeline";
            this.tb_writeline.Size = new System.Drawing.Size(324, 20);
            this.tb_writeline.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 480);
            this.Controls.Add(this.tb_writeline);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_connect);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_receive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_receive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button tb_connect;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tb_writeline;
    }
}

