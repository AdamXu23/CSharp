namespace TCP_Socket_Server
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
            System.Windows.Forms.Button Send_Butter;
            this.Listener_Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.IPPort_Text = new System.Windows.Forms.TextBox();
            this.Send_textBox = new System.Windows.Forms.TextBox();
            this.Grab_server_IP = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Answer_list_added = new System.Windows.Forms.Button();
            this.Answer_List_Deletion = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.Answer_List = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Answer_List_EN = new System.Windows.Forms.CheckBox();
            this.Return_list = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Return_text = new System.Windows.Forms.TextBox();
            this.IPAddress_Text = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            Send_Butter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send_Butter
            // 
            Send_Butter.Location = new System.Drawing.Point(354, 623);
            Send_Butter.Name = "Send_Butter";
            Send_Butter.Size = new System.Drawing.Size(78, 21);
            Send_Butter.TabIndex = 5;
            Send_Butter.Text = "Send";
            Send_Butter.UseVisualStyleBackColor = true;
            Send_Butter.Click += new System.EventHandler(this.Send_Butter_Click);
            // 
            // Listener_Button
            // 
            this.Listener_Button.Location = new System.Drawing.Point(288, 13);
            this.Listener_Button.Name = "Listener_Button";
            this.Listener_Button.Size = new System.Drawing.Size(151, 21);
            this.Listener_Button.TabIndex = 0;
            this.Listener_Button.Text = "Listener";
            this.Listener_Button.UseVisualStyleBackColor = true;
            this.Listener_Button.Click += new System.EventHandler(this.Listener_Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(445, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 604);
            this.listBox1.TabIndex = 1;
            // 
            // IPPort_Text
            // 
            this.IPPort_Text.Location = new System.Drawing.Point(89, 40);
            this.IPPort_Text.Name = "IPPort_Text";
            this.IPPort_Text.Size = new System.Drawing.Size(193, 21);
            this.IPPort_Text.TabIndex = 3;
            this.IPPort_Text.Text = "5000";
            // 
            // Send_textBox
            // 
            this.Send_textBox.Location = new System.Drawing.Point(14, 624);
            this.Send_textBox.Name = "Send_textBox";
            this.Send_textBox.Size = new System.Drawing.Size(334, 21);
            this.Send_textBox.TabIndex = 4;
            // 
            // Grab_server_IP
            // 
            this.Grab_server_IP.Location = new System.Drawing.Point(288, 40);
            this.Grab_server_IP.Name = "Grab_server_IP";
            this.Grab_server_IP.Size = new System.Drawing.Size(151, 21);
            this.Grab_server_IP.TabIndex = 6;
            this.Grab_server_IP.Text = "Grab server IP";
            this.Grab_server_IP.UseVisualStyleBackColor = true;
            this.Grab_server_IP.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Client port selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(445, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "history record";
            // 
            // Answer_list_added
            // 
            this.Answer_list_added.Location = new System.Drawing.Point(246, 568);
            this.Answer_list_added.Name = "Answer_list_added";
            this.Answer_list_added.Size = new System.Drawing.Size(186, 21);
            this.Answer_list_added.TabIndex = 12;
            this.Answer_list_added.Text = "Answer list added";
            this.Answer_list_added.UseVisualStyleBackColor = true;
            this.Answer_list_added.Click += new System.EventHandler(this.Answer_list_added_Click);
            // 
            // Answer_List_Deletion
            // 
            this.Answer_List_Deletion.Location = new System.Drawing.Point(246, 597);
            this.Answer_List_Deletion.Name = "Answer_List_Deletion";
            this.Answer_List_Deletion.Size = new System.Drawing.Size(186, 21);
            this.Answer_List_Deletion.TabIndex = 13;
            this.Answer_List_Deletion.Text = "Answer list deletion";
            this.Answer_List_Deletion.UseVisualStyleBackColor = true;
            this.Answer_List_Deletion.Click += new System.EventHandler(this.Answer_List_Deletion_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(391, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Keywords";
            // 
            // KeyWord
            // 
            this.KeyWord.Location = new System.Drawing.Point(71, 568);
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(169, 21);
            this.KeyWord.TabIndex = 16;
            // 
            // Answer_List
            // 
            this.Answer_List.FormattingEnabled = true;
            this.Answer_List.ItemHeight = 12;
            this.Answer_List.Location = new System.Drawing.Point(12, 150);
            this.Answer_List.Name = "Answer_List";
            this.Answer_List.Size = new System.Drawing.Size(207, 376);
            this.Answer_List.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(175, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Answer list";
            // 
            // Answer_List_EN
            // 
            this.Answer_List_EN.AutoSize = true;
            this.Answer_List_EN.Location = new System.Drawing.Point(288, 101);
            this.Answer_List_EN.Name = "Answer_List_EN";
            this.Answer_List_EN.Size = new System.Drawing.Size(60, 16);
            this.Answer_List_EN.TabIndex = 19;
            this.Answer_List_EN.Text = "Enable";
            this.Answer_List_EN.UseVisualStyleBackColor = true;
            // 
            // Return_list
            // 
            this.Return_list.FormattingEnabled = true;
            this.Return_list.ItemHeight = 12;
            this.Return_list.Location = new System.Drawing.Point(225, 150);
            this.Return_list.Name = "Return_list";
            this.Return_list.Size = new System.Drawing.Size(207, 376);
            this.Return_list.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "Return";
            // 
            // Return_text
            // 
            this.Return_text.Location = new System.Drawing.Point(71, 597);
            this.Return_text.Name = "Return_text";
            this.Return_text.Size = new System.Drawing.Size(169, 21);
            this.Return_text.TabIndex = 22;
            // 
            // IPAddress_Text
            // 
            this.IPAddress_Text.FormattingEnabled = true;
            this.IPAddress_Text.Location = new System.Drawing.Point(89, 13);
            this.IPAddress_Text.Name = "IPAddress_Text";
            this.IPAddress_Text.Size = new System.Drawing.Size(193, 20);
            this.IPAddress_Text.TabIndex = 23;
            this.IPAddress_Text.SelectedIndexChanged += new System.EventHandler(this.IPAddress_Text_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rcv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 21);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IPAddress_Text);
            this.Controls.Add(this.Return_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Return_list);
            this.Controls.Add(this.Answer_List_EN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Answer_List);
            this.Controls.Add(this.KeyWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Answer_List_Deletion);
            this.Controls.Add(this.Answer_list_added);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Grab_server_IP);
            this.Controls.Add(Send_Butter);
            this.Controls.Add(this.Send_textBox);
            this.Controls.Add(this.IPPort_Text);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Listener_Button);
            this.Name = "Form1";
            this.Text = "TCP_Socket_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Listener_Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox IPPort_Text;
        private System.Windows.Forms.TextBox Send_textBox;
        private System.Windows.Forms.Button Grab_server_IP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Answer_list_added;
        private System.Windows.Forms.Button Answer_List_Deletion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.ListBox Answer_List;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Answer_List_EN;
        private System.Windows.Forms.ListBox Return_list;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Return_text;
        private System.Windows.Forms.ComboBox IPAddress_Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

