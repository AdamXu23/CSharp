namespace test
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
            this.INSERT_button = new System.Windows.Forms.Button();
            this.SERIAL_NUMBER_textBox = new System.Windows.Forms.TextBox();
            this.SERIAL_NUMBER_label = new System.Windows.Forms.Label();
            this.JOB_NUMBER_textBox = new System.Windows.Forms.TextBox();
            this.JOB_NUMBER_label = new System.Windows.Forms.Label();
            this.FACTORY_ComboBox = new System.Windows.Forms.ComboBox();
            this.FACTORY_label = new System.Windows.Forms.Label();
            this.Event_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.USER_ID = new System.Windows.Forms.Label();
            this.USER_ID_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INSERT_button
            // 
            this.INSERT_button.Location = new System.Drawing.Point(675, 77);
            this.INSERT_button.Name = "INSERT_button";
            this.INSERT_button.Size = new System.Drawing.Size(75, 23);
            this.INSERT_button.TabIndex = 25;
            this.INSERT_button.Text = "INSERT";
            this.INSERT_button.UseVisualStyleBackColor = true;
            // 
            // SERIAL_NUMBER_textBox
            // 
            this.SERIAL_NUMBER_textBox.Location = new System.Drawing.Point(476, 78);
            this.SERIAL_NUMBER_textBox.Name = "SERIAL_NUMBER_textBox";
            this.SERIAL_NUMBER_textBox.Size = new System.Drawing.Size(100, 21);
            this.SERIAL_NUMBER_textBox.TabIndex = 24;
            // 
            // SERIAL_NUMBER_label
            // 
            this.SERIAL_NUMBER_label.AutoSize = true;
            this.SERIAL_NUMBER_label.Location = new System.Drawing.Point(387, 81);
            this.SERIAL_NUMBER_label.Name = "SERIAL_NUMBER_label";
            this.SERIAL_NUMBER_label.Size = new System.Drawing.Size(83, 12);
            this.SERIAL_NUMBER_label.TabIndex = 23;
            this.SERIAL_NUMBER_label.Text = "出廠流水號： ";
            // 
            // JOB_NUMBER_textBox
            // 
            this.JOB_NUMBER_textBox.Location = new System.Drawing.Point(281, 78);
            this.JOB_NUMBER_textBox.Name = "JOB_NUMBER_textBox";
            this.JOB_NUMBER_textBox.Size = new System.Drawing.Size(100, 21);
            this.JOB_NUMBER_textBox.TabIndex = 22;
            // 
            // JOB_NUMBER_label
            // 
            this.JOB_NUMBER_label.AutoSize = true;
            this.JOB_NUMBER_label.Location = new System.Drawing.Point(210, 82);
            this.JOB_NUMBER_label.Name = "JOB_NUMBER_label";
            this.JOB_NUMBER_label.Size = new System.Drawing.Size(65, 12);
            this.JOB_NUMBER_label.TabIndex = 21;
            this.JOB_NUMBER_label.Text = "專案工號：";
            // 
            // FACTORY_ComboBox
            // 
            this.FACTORY_ComboBox.FormattingEnabled = true;
            this.FACTORY_ComboBox.Items.AddRange(new object[] {
            "F04",
            "F06",
            "F10",
            "F11",
            "F15",
            "F16"});
            this.FACTORY_ComboBox.Location = new System.Drawing.Point(83, 79);
            this.FACTORY_ComboBox.Name = "FACTORY_ComboBox";
            this.FACTORY_ComboBox.Size = new System.Drawing.Size(121, 20);
            this.FACTORY_ComboBox.TabIndex = 20;
            // 
            // FACTORY_label
            // 
            this.FACTORY_label.AutoSize = true;
            this.FACTORY_label.Location = new System.Drawing.Point(12, 82);
            this.FACTORY_label.Name = "FACTORY_label";
            this.FACTORY_label.Size = new System.Drawing.Size(65, 12);
            this.FACTORY_label.TabIndex = 19;
            this.FACTORY_label.Text = "適用廠區：";
            // 
            // Event_label
            // 
            this.Event_label.AutoSize = true;
            this.Event_label.Location = new System.Drawing.Point(18, 428);
            this.Event_label.Name = "Event_label";
            this.Event_label.Size = new System.Drawing.Size(35, 12);
            this.Event_label.TabIndex = 18;
            this.Event_label.Text = "Event";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(71, 39);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(598, 21);
            this.Password_textBox.TabIndex = 17;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 42);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 12);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // USER_ID
            // 
            this.USER_ID.AutoSize = true;
            this.USER_ID.Location = new System.Drawing.Point(12, 16);
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.Size = new System.Drawing.Size(47, 12);
            this.USER_ID.TabIndex = 15;
            this.USER_ID.Text = "USER ID";
            // 
            // USER_ID_textBox
            // 
            this.USER_ID_textBox.Location = new System.Drawing.Point(71, 12);
            this.USER_ID_textBox.Name = "USER_ID_textBox";
            this.USER_ID_textBox.Size = new System.Drawing.Size(598, 21);
            this.USER_ID_textBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "SQL_Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INSERT_button);
            this.Controls.Add(this.SERIAL_NUMBER_textBox);
            this.Controls.Add(this.SERIAL_NUMBER_label);
            this.Controls.Add(this.JOB_NUMBER_textBox);
            this.Controls.Add(this.JOB_NUMBER_label);
            this.Controls.Add(this.FACTORY_ComboBox);
            this.Controls.Add(this.FACTORY_label);
            this.Controls.Add(this.Event_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.USER_ID);
            this.Controls.Add(this.USER_ID_textBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button INSERT_button;
        private System.Windows.Forms.TextBox SERIAL_NUMBER_textBox;
        private System.Windows.Forms.Label SERIAL_NUMBER_label;
        private System.Windows.Forms.TextBox JOB_NUMBER_textBox;
        private System.Windows.Forms.Label JOB_NUMBER_label;
        private System.Windows.Forms.ComboBox FACTORY_ComboBox;
        private System.Windows.Forms.Label FACTORY_label;
        private System.Windows.Forms.Label Event_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label USER_ID;
        private System.Windows.Forms.TextBox USER_ID_textBox;
        private System.Windows.Forms.Button button1;
    }
}

