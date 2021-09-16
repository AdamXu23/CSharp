namespace TCP_client_socket_Test
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
            this.Server_IP = new System.Windows.Forms.TextBox();
            this.Server_IP_label = new System.Windows.Forms.Label();
            this.Server_Port = new System.Windows.Forms.TextBox();
            this.Server_Port_label = new System.Windows.Forms.Label();
            this.Connection = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Send_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server_IP
            // 
            this.Server_IP.Location = new System.Drawing.Point(75, 12);
            this.Server_IP.Name = "Server_IP";
            this.Server_IP.Size = new System.Drawing.Size(160, 21);
            this.Server_IP.TabIndex = 0;
            this.Server_IP.Tag = "";
            this.Server_IP.Text = "192.168.250.123";
            // 
            // Server_IP_label
            // 
            this.Server_IP_label.AutoSize = true;
            this.Server_IP_label.Location = new System.Drawing.Point(10, 15);
            this.Server_IP_label.Name = "Server_IP_label";
            this.Server_IP_label.Size = new System.Drawing.Size(59, 12);
            this.Server_IP_label.TabIndex = 1;
            this.Server_IP_label.Text = "Server_IP";
            // 
            // Server_Port
            // 
            this.Server_Port.Location = new System.Drawing.Point(87, 39);
            this.Server_Port.Name = "Server_Port";
            this.Server_Port.Size = new System.Drawing.Size(148, 21);
            this.Server_Port.TabIndex = 2;
            this.Server_Port.Text = "5000";
            // 
            // Server_Port_label
            // 
            this.Server_Port_label.AutoSize = true;
            this.Server_Port_label.Location = new System.Drawing.Point(10, 42);
            this.Server_Port_label.Name = "Server_Port_label";
            this.Server_Port_label.Size = new System.Drawing.Size(71, 12);
            this.Server_Port_label.TabIndex = 3;
            this.Server_Port_label.Text = "Server_Port";
            // 
            // Connection
            // 
            this.Connection.Location = new System.Drawing.Point(241, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(166, 48);
            this.Connection.TabIndex = 4;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(413, 27);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(192, 21);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // Send_1
            // 
            this.Send_1.Location = new System.Drawing.Point(12, 78);
            this.Send_1.Name = "Send_1";
            this.Send_1.Size = new System.Drawing.Size(177, 21);
            this.Send_1.TabIndex = 7;
            this.Send_1.Text = "EC_ErrorRest";
            this.Send_1.UseVisualStyleBackColor = true;
            this.Send_1.Click += new System.EventHandler(this.Send_1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Server_Enable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "Server_Disable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 21);
            this.button3.TabIndex = 10;
            this.button3.Text = "MC_Reverse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 21);
            this.button4.TabIndex = 11;
            this.button4.Text = "MC_Axis000_Jog";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 21);
            this.button5.TabIndex = 12;
            this.button5.Text = "MC_Axis001_Jog";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Send_1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.Server_Port_label);
            this.Controls.Add(this.Server_Port);
            this.Controls.Add(this.Server_IP_label);
            this.Controls.Add(this.Server_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Server_IP;
        private System.Windows.Forms.Label Server_IP_label;
        private System.Windows.Forms.TextBox Server_Port;
        private System.Windows.Forms.Label Server_Port_label;
        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Send_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

