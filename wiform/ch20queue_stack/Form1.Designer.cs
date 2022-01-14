namespace ch20queue_stack
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQueue1 = new System.Windows.Forms.Label();
            this.lblQueue2 = new System.Windows.Forms.Label();
            this.lblQueue3 = new System.Windows.Forms.Label();
            this.lblQueue4 = new System.Windows.Forms.Label();
            this.lblQueue5 = new System.Windows.Forms.Label();
            this.lblQueue6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStack1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblStack2 = new System.Windows.Forms.Label();
            this.lblStack3 = new System.Windows.Forms.Label();
            this.lblStack4 = new System.Windows.Forms.Label();
            this.lblStack5 = new System.Windows.Forms.Label();
            this.lblStack6 = new System.Windows.Forms.Label();
            this.btnDataIn = new System.Windows.Forms.Button();
            this.btnAutoDataOut = new System.Windows.Forms.Button();
            this.btnDataOut = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblQueue1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueue6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblQueue1
            // 
            this.lblQueue1.AutoSize = true;
            this.lblQueue1.BackColor = System.Drawing.Color.White;
            this.lblQueue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue1.Location = new System.Drawing.Point(513, 3);
            this.lblQueue1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblQueue1.Name = "lblQueue1";
            this.lblQueue1.Size = new System.Drawing.Size(103, 42);
            this.lblQueue1.TabIndex = 9;
            this.lblQueue1.Text = "-";
            this.lblQueue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue2
            // 
            this.lblQueue2.AutoSize = true;
            this.lblQueue2.BackColor = System.Drawing.Color.White;
            this.lblQueue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue2.Location = new System.Drawing.Point(411, 3);
            this.lblQueue2.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue2.Name = "lblQueue2";
            this.lblQueue2.Size = new System.Drawing.Size(96, 42);
            this.lblQueue2.TabIndex = 8;
            this.lblQueue2.Text = "-";
            this.lblQueue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue3
            // 
            this.lblQueue3.AutoSize = true;
            this.lblQueue3.BackColor = System.Drawing.Color.White;
            this.lblQueue3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue3.Location = new System.Drawing.Point(309, 3);
            this.lblQueue3.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue3.Name = "lblQueue3";
            this.lblQueue3.Size = new System.Drawing.Size(96, 42);
            this.lblQueue3.TabIndex = 7;
            this.lblQueue3.Text = "-";
            this.lblQueue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue4
            // 
            this.lblQueue4.AutoSize = true;
            this.lblQueue4.BackColor = System.Drawing.Color.White;
            this.lblQueue4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue4.Location = new System.Drawing.Point(207, 3);
            this.lblQueue4.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue4.Name = "lblQueue4";
            this.lblQueue4.Size = new System.Drawing.Size(96, 42);
            this.lblQueue4.TabIndex = 6;
            this.lblQueue4.Text = "-";
            this.lblQueue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue5
            // 
            this.lblQueue5.AutoSize = true;
            this.lblQueue5.BackColor = System.Drawing.Color.White;
            this.lblQueue5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue5.Location = new System.Drawing.Point(105, 3);
            this.lblQueue5.Margin = new System.Windows.Forms.Padding(3);
            this.lblQueue5.Name = "lblQueue5";
            this.lblQueue5.Size = new System.Drawing.Size(96, 42);
            this.lblQueue5.TabIndex = 5;
            this.lblQueue5.Text = "-";
            this.lblQueue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueue6
            // 
            this.lblQueue6.AutoSize = true;
            this.lblQueue6.BackColor = System.Drawing.Color.White;
            this.lblQueue6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueue6.Location = new System.Drawing.Point(0, 3);
            this.lblQueue6.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblQueue6.Name = "lblQueue6";
            this.lblQueue6.Size = new System.Drawing.Size(99, 42);
            this.lblQueue6.TabIndex = 3;
            this.lblQueue6.Text = "-";
            this.lblQueue6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "[5]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(102, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "[4]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(204, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "[3]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(306, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "[2]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(408, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "[1]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(510, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "[0]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queue";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblStack1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblStack2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStack3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStack4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblStack5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblStack6, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 235);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 218);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblStack1
            // 
            this.lblStack1.AutoSize = true;
            this.lblStack1.BackColor = System.Drawing.Color.White;
            this.lblStack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack1.Location = new System.Drawing.Point(3, 3);
            this.lblStack1.Margin = new System.Windows.Forms.Padding(3);
            this.lblStack1.Name = "lblStack1";
            this.lblStack1.Size = new System.Drawing.Size(154, 30);
            this.lblStack1.TabIndex = 4;
            this.lblStack1.Text = "-";
            this.lblStack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(160, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 36);
            this.label14.TabIndex = 4;
            this.label14.Text = "[0]";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(160, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 36);
            this.label15.TabIndex = 4;
            this.label15.Text = "[1]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(160, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 36);
            this.label16.TabIndex = 4;
            this.label16.Text = "[2]";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(160, 108);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 36);
            this.label17.TabIndex = 4;
            this.label17.Text = "[3]";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(160, 144);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 36);
            this.label18.TabIndex = 4;
            this.label18.Text = "[4]";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(160, 180);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 38);
            this.label19.TabIndex = 4;
            this.label19.Text = "[5]";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack2
            // 
            this.lblStack2.AutoSize = true;
            this.lblStack2.BackColor = System.Drawing.Color.White;
            this.lblStack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack2.Location = new System.Drawing.Point(3, 39);
            this.lblStack2.Margin = new System.Windows.Forms.Padding(3);
            this.lblStack2.Name = "lblStack2";
            this.lblStack2.Size = new System.Drawing.Size(154, 30);
            this.lblStack2.TabIndex = 4;
            this.lblStack2.Text = "-";
            this.lblStack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack3
            // 
            this.lblStack3.AutoSize = true;
            this.lblStack3.BackColor = System.Drawing.Color.White;
            this.lblStack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack3.Location = new System.Drawing.Point(3, 75);
            this.lblStack3.Margin = new System.Windows.Forms.Padding(3);
            this.lblStack3.Name = "lblStack3";
            this.lblStack3.Size = new System.Drawing.Size(154, 30);
            this.lblStack3.TabIndex = 4;
            this.lblStack3.Text = "-";
            this.lblStack3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack4
            // 
            this.lblStack4.AutoSize = true;
            this.lblStack4.BackColor = System.Drawing.Color.White;
            this.lblStack4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack4.Location = new System.Drawing.Point(3, 111);
            this.lblStack4.Margin = new System.Windows.Forms.Padding(3);
            this.lblStack4.Name = "lblStack4";
            this.lblStack4.Size = new System.Drawing.Size(154, 30);
            this.lblStack4.TabIndex = 4;
            this.lblStack4.Text = "-";
            this.lblStack4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack5
            // 
            this.lblStack5.AutoSize = true;
            this.lblStack5.BackColor = System.Drawing.Color.White;
            this.lblStack5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack5.Location = new System.Drawing.Point(3, 147);
            this.lblStack5.Margin = new System.Windows.Forms.Padding(3);
            this.lblStack5.Name = "lblStack5";
            this.lblStack5.Size = new System.Drawing.Size(154, 30);
            this.lblStack5.TabIndex = 4;
            this.lblStack5.Text = "-";
            this.lblStack5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStack6
            // 
            this.lblStack6.AutoSize = true;
            this.lblStack6.BackColor = System.Drawing.Color.White;
            this.lblStack6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStack6.Location = new System.Drawing.Point(3, 183);
            this.lblStack6.Margin = new System.Windows.Forms.Padding(3);
            this.lblStack6.Name = "lblStack6";
            this.lblStack6.Size = new System.Drawing.Size(154, 32);
            this.lblStack6.TabIndex = 4;
            this.lblStack6.Text = "-";
            this.lblStack6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDataIn
            // 
            this.btnDataIn.Location = new System.Drawing.Point(62, 158);
            this.btnDataIn.Name = "btnDataIn";
            this.btnDataIn.Size = new System.Drawing.Size(130, 40);
            this.btnDataIn.TabIndex = 3;
            this.btnDataIn.Text = "In";
            this.btnDataIn.UseVisualStyleBackColor = true;
            this.btnDataIn.Click += new System.EventHandler(this.btnDataIn_Click);
            // 
            // btnAutoDataOut
            // 
            this.btnAutoDataOut.Location = new System.Drawing.Point(321, 158);
            this.btnAutoDataOut.Name = "btnAutoDataOut";
            this.btnAutoDataOut.Size = new System.Drawing.Size(130, 40);
            this.btnAutoDataOut.TabIndex = 3;
            this.btnAutoDataOut.Text = "Auto Out off";
            this.btnAutoDataOut.UseVisualStyleBackColor = true;
            this.btnAutoDataOut.Click += new System.EventHandler(this.btnAutoDataOut_Click);
            // 
            // btnDataOut
            // 
            this.btnDataOut.Location = new System.Drawing.Point(486, 158);
            this.btnDataOut.Name = "btnDataOut";
            this.btnDataOut.Size = new System.Drawing.Size(130, 40);
            this.btnDataOut.TabIndex = 3;
            this.btnDataOut.Text = "Out";
            this.btnDataOut.UseVisualStyleBackColor = true;
            this.btnDataOut.Click += new System.EventHandler(this.btnDataOut_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 415);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Stack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 465);
            this.Controls.Add(this.btnDataOut);
            this.Controls.Add(this.btnAutoDataOut);
            this.Controls.Add(this.btnDataIn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblQueue1;
        private System.Windows.Forms.Label lblQueue2;
        private System.Windows.Forms.Label lblQueue3;
        private System.Windows.Forms.Label lblQueue4;
        private System.Windows.Forms.Label lblQueue5;
        private System.Windows.Forms.Label lblQueue6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStack1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblStack2;
        private System.Windows.Forms.Label lblStack3;
        private System.Windows.Forms.Label lblStack4;
        private System.Windows.Forms.Label lblStack5;
        private System.Windows.Forms.Label lblStack6;
        private System.Windows.Forms.Button btnDataIn;
        private System.Windows.Forms.Button btnAutoDataOut;
        private System.Windows.Forms.Button btnDataOut;
        private System.Windows.Forms.Label label20;
    }
}

