namespace TCP_Server
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
            this.tb_writeline = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(13, 13);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.ReadOnly = true;
            this.tb_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_receive.Size = new System.Drawing.Size(322, 373);
            this.tb_receive.TabIndex = 0;
            // 
            // tb_writeline
            // 
            this.tb_writeline.Location = new System.Drawing.Point(13, 413);
            this.tb_writeline.Name = "tb_writeline";
            this.tb_writeline.Size = new System.Drawing.Size(322, 20);
            this.tb_writeline.TabIndex = 1;
            // 
            // bt_send
            // 
            this.bt_send.Enabled = false;
            this.bt_send.Location = new System.Drawing.Point(358, 409);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(95, 23);
            this.bt_send.TabIndex = 2;
            this.bt_send.Text = "전송";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(396, 137);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(119, 34);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "Open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(396, 17);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(119, 20);
            this.tb_ip.TabIndex = 4;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(396, 48);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(119, 20);
            this.tb_port.TabIndex = 4;
            this.tb_port.Text = "5000";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(396, 84);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(119, 20);
            this.tb_ID.TabIndex = 4;
            this.tb_ID.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 454);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_writeline);
            this.Controls.Add(this.tb_receive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_receive;
        private System.Windows.Forms.TextBox tb_writeline;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ID;
    }
}

