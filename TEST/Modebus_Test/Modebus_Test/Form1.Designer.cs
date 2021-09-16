namespace Modebus_Test
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
            this.SerialPort_comboBox = new System.Windows.Forms.ComboBox();
            this.RH1_textBox = new System.Windows.Forms.TextBox();
            this.RH2_textBox = new System.Windows.Forms.TextBox();
            this.RH3_textBox = new System.Windows.Forms.TextBox();
            this.RH4_textBox = new System.Windows.Forms.TextBox();
            this.Serial_RH1 = new System.Windows.Forms.Label();
            this.Serial_RH2 = new System.Windows.Forms.Label();
            this.Serial_RH3 = new System.Windows.Forms.Label();
            this.Serial_RH4 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AVEX_textBox4 = new System.Windows.Forms.TextBox();
            this.AVEX_textBox3 = new System.Windows.Forms.TextBox();
            this.AVEX_textBox2 = new System.Windows.Forms.TextBox();
            this.AVEX_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SerialPort_comboBox
            // 
            this.SerialPort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPort_comboBox.FormattingEnabled = true;
            this.SerialPort_comboBox.Location = new System.Drawing.Point(12, 12);
            this.SerialPort_comboBox.Name = "SerialPort_comboBox";
            this.SerialPort_comboBox.Size = new System.Drawing.Size(146, 20);
            this.SerialPort_comboBox.TabIndex = 3;
            this.SerialPort_comboBox.DropDown += new System.EventHandler(this.SerialPort_comboBox_DropDown);
            this.SerialPort_comboBox.SelectedIndexChanged += new System.EventHandler(this.SerialPort_comboBox_SelectedIndexChanged);
            // 
            // RH1_textBox
            // 
            this.RH1_textBox.Location = new System.Drawing.Point(83, 38);
            this.RH1_textBox.Name = "RH1_textBox";
            this.RH1_textBox.Size = new System.Drawing.Size(75, 21);
            this.RH1_textBox.TabIndex = 4;
            // 
            // RH2_textBox
            // 
            this.RH2_textBox.Location = new System.Drawing.Point(83, 65);
            this.RH2_textBox.Name = "RH2_textBox";
            this.RH2_textBox.Size = new System.Drawing.Size(75, 21);
            this.RH2_textBox.TabIndex = 5;
            // 
            // RH3_textBox
            // 
            this.RH3_textBox.Location = new System.Drawing.Point(83, 92);
            this.RH3_textBox.Name = "RH3_textBox";
            this.RH3_textBox.Size = new System.Drawing.Size(75, 21);
            this.RH3_textBox.TabIndex = 6;
            // 
            // RH4_textBox
            // 
            this.RH4_textBox.Location = new System.Drawing.Point(83, 119);
            this.RH4_textBox.Name = "RH4_textBox";
            this.RH4_textBox.Size = new System.Drawing.Size(75, 21);
            this.RH4_textBox.TabIndex = 7;
            // 
            // Serial_RH1
            // 
            this.Serial_RH1.AutoSize = true;
            this.Serial_RH1.Location = new System.Drawing.Point(12, 41);
            this.Serial_RH1.Name = "Serial_RH1";
            this.Serial_RH1.Size = new System.Drawing.Size(53, 12);
            this.Serial_RH1.TabIndex = 8;
            this.Serial_RH1.Text = "Serial_1";
            // 
            // Serial_RH2
            // 
            this.Serial_RH2.AutoSize = true;
            this.Serial_RH2.Location = new System.Drawing.Point(12, 68);
            this.Serial_RH2.Name = "Serial_RH2";
            this.Serial_RH2.Size = new System.Drawing.Size(53, 12);
            this.Serial_RH2.TabIndex = 9;
            this.Serial_RH2.Text = "Serial_2";
            // 
            // Serial_RH3
            // 
            this.Serial_RH3.AutoSize = true;
            this.Serial_RH3.Location = new System.Drawing.Point(12, 95);
            this.Serial_RH3.Name = "Serial_RH3";
            this.Serial_RH3.Size = new System.Drawing.Size(53, 12);
            this.Serial_RH3.TabIndex = 10;
            this.Serial_RH3.Text = "Serial_3";
            // 
            // Serial_RH4
            // 
            this.Serial_RH4.AutoSize = true;
            this.Serial_RH4.Location = new System.Drawing.Point(12, 122);
            this.Serial_RH4.Name = "Serial_RH4";
            this.Serial_RH4.Size = new System.Drawing.Size(53, 12);
            this.Serial_RH4.TabIndex = 11;
            this.Serial_RH4.Text = "Serial_4";
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(164, 12);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 12;
            this.Start_Button.Text = "開始";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(245, 12);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 23);
            this.Stop_button.TabIndex = 13;
            this.Stop_button.Text = "停止";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "AVEX_4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "AVEX_3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "AVEX_2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "AVEX_1";
            // 
            // AVEX_textBox4
            // 
            this.AVEX_textBox4.Location = new System.Drawing.Point(245, 122);
            this.AVEX_textBox4.Name = "AVEX_textBox4";
            this.AVEX_textBox4.Size = new System.Drawing.Size(75, 21);
            this.AVEX_textBox4.TabIndex = 17;
            // 
            // AVEX_textBox3
            // 
            this.AVEX_textBox3.Location = new System.Drawing.Point(245, 95);
            this.AVEX_textBox3.Name = "AVEX_textBox3";
            this.AVEX_textBox3.Size = new System.Drawing.Size(75, 21);
            this.AVEX_textBox3.TabIndex = 16;
            // 
            // AVEX_textBox2
            // 
            this.AVEX_textBox2.Location = new System.Drawing.Point(245, 68);
            this.AVEX_textBox2.Name = "AVEX_textBox2";
            this.AVEX_textBox2.Size = new System.Drawing.Size(75, 21);
            this.AVEX_textBox2.TabIndex = 15;
            // 
            // AVEX_textBox1
            // 
            this.AVEX_textBox1.Location = new System.Drawing.Point(245, 41);
            this.AVEX_textBox1.Name = "AVEX_textBox1";
            this.AVEX_textBox1.Size = new System.Drawing.Size(75, 21);
            this.AVEX_textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AVEX_textBox4);
            this.Controls.Add(this.AVEX_textBox3);
            this.Controls.Add(this.AVEX_textBox2);
            this.Controls.Add(this.AVEX_textBox1);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Serial_RH4);
            this.Controls.Add(this.Serial_RH3);
            this.Controls.Add(this.Serial_RH2);
            this.Controls.Add(this.Serial_RH1);
            this.Controls.Add(this.RH4_textBox);
            this.Controls.Add(this.RH3_textBox);
            this.Controls.Add(this.RH2_textBox);
            this.Controls.Add(this.RH1_textBox);
            this.Controls.Add(this.SerialPort_comboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SerialPort_comboBox;
        private System.Windows.Forms.TextBox RH1_textBox;
        private System.Windows.Forms.TextBox RH2_textBox;
        private System.Windows.Forms.TextBox RH3_textBox;
        private System.Windows.Forms.TextBox RH4_textBox;
        private System.Windows.Forms.Label Serial_RH1;
        private System.Windows.Forms.Label Serial_RH2;
        private System.Windows.Forms.Label Serial_RH3;
        private System.Windows.Forms.Label Serial_RH4;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AVEX_textBox4;
        private System.Windows.Forms.TextBox AVEX_textBox3;
        private System.Windows.Forms.TextBox AVEX_textBox2;
        private System.Windows.Forms.TextBox AVEX_textBox1;
    }
}

