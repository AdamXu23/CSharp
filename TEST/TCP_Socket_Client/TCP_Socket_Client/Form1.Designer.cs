namespace TCP_Socket_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Connection = new System.Windows.Forms.Button();
            this.IPAddress_TEXT = new System.Windows.Forms.TextBox();
            this.IPPort_TEXT = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Send_textBox1 = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HCON = new System.Windows.Forms.TextBox();
            this.HCOF = new System.Windows.Forms.TextBox();
            this.HC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LCT1 = new System.Windows.Forms.TextBox();
            this.LCT2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LCF1 = new System.Windows.Forms.TextBox();
            this.LCF2 = new System.Windows.Forms.TextBox();
            this.LC = new System.Windows.Forms.Button();
            this.OCMS = new System.Windows.Forms.Button();
            this.CMON = new System.Windows.Forms.Button();
            this.OCMOF = new System.Windows.Forms.Button();
            this.Disconnected = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(196, 10);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(135, 23);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "連綫";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // IPAddress_TEXT
            // 
            this.IPAddress_TEXT.Location = new System.Drawing.Point(53, 11);
            this.IPAddress_TEXT.Name = "IPAddress_TEXT";
            this.IPAddress_TEXT.Size = new System.Drawing.Size(137, 21);
            this.IPAddress_TEXT.TabIndex = 1;
            this.IPAddress_TEXT.Text = "192.168.1.100";
            // 
            // IPPort_TEXT
            // 
            this.IPPort_TEXT.Location = new System.Drawing.Point(53, 38);
            this.IPPort_TEXT.Name = "IPPort_TEXT";
            this.IPPort_TEXT.Size = new System.Drawing.Size(137, 21);
            this.IPPort_TEXT.TabIndex = 2;
            this.IPPort_TEXT.Text = "500";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(367, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 460);
            this.listBox1.TabIndex = 3;
            // 
            // Send_textBox1
            // 
            this.Send_textBox1.Location = new System.Drawing.Point(29, 401);
            this.Send_textBox1.Name = "Send_textBox1";
            this.Send_textBox1.Size = new System.Drawing.Size(281, 21);
            this.Send_textBox1.TabIndex = 4;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(175, 428);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(135, 23);
            this.Send_Button.TabIndex = 5;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(106, 80);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(58, 21);
            this.Port.TabIndex = 6;
            this.Port.Text = "1";
            this.Port.TextChanged += new System.EventHandler(this.Port_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "抽氣打開時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "抽氣關閉時間";
            // 
            // HCON
            // 
            this.HCON.Location = new System.Drawing.Point(26, 174);
            this.HCON.Name = "HCON";
            this.HCON.Size = new System.Drawing.Size(137, 21);
            this.HCON.TabIndex = 10;
            this.HCON.Text = "00180";
            // 
            // HCOF
            // 
            this.HCOF.Location = new System.Drawing.Point(174, 174);
            this.HCOF.Name = "HCOF";
            this.HCOF.Size = new System.Drawing.Size(137, 21);
            this.HCOF.TabIndex = 11;
            this.HCOF.Text = "00060";
            // 
            // HC
            // 
            this.HC.Location = new System.Drawing.Point(27, 201);
            this.HC.Name = "HC";
            this.HC.Size = new System.Drawing.Size(283, 23);
            this.HC.TabIndex = 12;
            this.HC.Text = "高點矯正開啓";
            this.HC.UseVisualStyleBackColor = true;
            this.HC.Click += new System.EventHandler(this.HC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "高流量充氣時間";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "低流量矫正延遲時間";
            // 
            // LCT1
            // 
            this.LCT1.Location = new System.Drawing.Point(26, 266);
            this.LCT1.Name = "LCT1";
            this.LCT1.Size = new System.Drawing.Size(137, 21);
            this.LCT1.TabIndex = 15;
            this.LCT1.Text = "00300";
            // 
            // LCT2
            // 
            this.LCT2.Location = new System.Drawing.Point(174, 266);
            this.LCT2.Name = "LCT2";
            this.LCT2.Size = new System.Drawing.Size(137, 21);
            this.LCT2.TabIndex = 16;
            this.LCT2.Text = "00060";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "高流量設定值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "低流量設定值";
            // 
            // LCF1
            // 
            this.LCF1.Location = new System.Drawing.Point(26, 305);
            this.LCF1.Name = "LCF1";
            this.LCF1.Size = new System.Drawing.Size(137, 21);
            this.LCF1.TabIndex = 19;
            this.LCF1.Text = "00035";
            // 
            // LCF2
            // 
            this.LCF2.Location = new System.Drawing.Point(174, 305);
            this.LCF2.Name = "LCF2";
            this.LCF2.Size = new System.Drawing.Size(137, 21);
            this.LCF2.TabIndex = 20;
            this.LCF2.Text = "00008";
            // 
            // LC
            // 
            this.LC.Location = new System.Drawing.Point(25, 332);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(285, 23);
            this.LC.TabIndex = 12;
            this.LC.Text = "低點矯正開啓";
            this.LC.UseVisualStyleBackColor = true;
            this.LC.Click += new System.EventHandler(this.LC_Click);
            // 
            // OCMS
            // 
            this.OCMS.Location = new System.Drawing.Point(25, 361);
            this.OCMS.Name = "OCMS";
            this.OCMS.Size = new System.Drawing.Size(285, 23);
            this.OCMS.TabIndex = 21;
            this.OCMS.Text = "矯正值寫入";
            this.OCMS.UseVisualStyleBackColor = true;
            this.OCMS.Click += new System.EventHandler(this.OCMS_Click);
            // 
            // CMON
            // 
            this.CMON.Location = new System.Drawing.Point(25, 108);
            this.CMON.Name = "CMON";
            this.CMON.Size = new System.Drawing.Size(139, 23);
            this.CMON.TabIndex = 22;
            this.CMON.Text = "O2 矯正開啓";
            this.CMON.UseVisualStyleBackColor = true;
            this.CMON.Click += new System.EventHandler(this.CMON_Click_1);
            // 
            // OCMOF
            // 
            this.OCMOF.Location = new System.Drawing.Point(175, 108);
            this.OCMOF.Name = "OCMOF";
            this.OCMOF.Size = new System.Drawing.Size(135, 23);
            this.OCMOF.TabIndex = 23;
            this.OCMOF.Text = "O2 矯正關閉";
            this.OCMOF.UseVisualStyleBackColor = true;
            this.OCMOF.Click += new System.EventHandler(this.OCMOF_Click);
            // 
            // Disconnected
            // 
            this.Disconnected.Location = new System.Drawing.Point(196, 37);
            this.Disconnected.Name = "Disconnected";
            this.Disconnected.Size = new System.Drawing.Size(135, 23);
            this.Disconnected.TabIndex = 24;
            this.Disconnected.Text = "斷綫";
            this.Disconnected.UseVisualStyleBackColor = true;
            this.Disconnected.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "中文";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "English";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(21, 15);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(17, 12);
            this.IP.TabIndex = 27;
            this.IP.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Disconnected);
            this.Controls.Add(this.OCMOF);
            this.Controls.Add(this.CMON);
            this.Controls.Add(this.OCMS);
            this.Controls.Add(this.LCF2);
            this.Controls.Add(this.LCF1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LCT2);
            this.Controls.Add(this.LCT1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LC);
            this.Controls.Add(this.HC);
            this.Controls.Add(this.HCOF);
            this.Controls.Add(this.HCON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Send_textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.IPPort_TEXT);
            this.Controls.Add(this.IPAddress_TEXT);
            this.Controls.Add(this.Connection);
            this.Name = "Form1";
            this.Text = "客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.TextBox IPAddress_TEXT;
        private System.Windows.Forms.TextBox IPPort_TEXT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Send_textBox1;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HCON;
        private System.Windows.Forms.TextBox HCOF;
        private System.Windows.Forms.Button HC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LCT1;
        private System.Windows.Forms.TextBox LCT2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LCF1;
        private System.Windows.Forms.TextBox LCF2;
        private System.Windows.Forms.Button LC;
        private System.Windows.Forms.Button OCMS;
        private System.Windows.Forms.Button CMON;
        private System.Windows.Forms.Button OCMOF;
        private System.Windows.Forms.Button Disconnected;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label label8;
    }
}

