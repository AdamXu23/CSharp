namespace Oracle_WindowsFormsApp
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
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label_User_Id = new System.Windows.Forms.Label();
            this.User_Id_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Oracle_Version = new System.Windows.Forms.Label();
            this.richTextBox_Even = new System.Windows.Forms.RichTextBox();
            this.Select_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.員工編號 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.狀態 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.記錄時間 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.備注 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PERSONNEL_NUMBER = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.STATUS = new System.Windows.Forms.TextBox();
            this.ANNOTATION = new System.Windows.Forms.TextBox();
            this.Insert_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(611, 61);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(177, 48);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // label_User_Id
            // 
            this.label_User_Id.AutoSize = true;
            this.label_User_Id.Location = new System.Drawing.Point(12, 64);
            this.label_User_Id.Name = "label_User_Id";
            this.label_User_Id.Size = new System.Drawing.Size(47, 12);
            this.label_User_Id.TabIndex = 1;
            this.label_User_Id.Text = "User Id";
            // 
            // User_Id_TextBox
            // 
            this.User_Id_TextBox.Location = new System.Drawing.Point(71, 61);
            this.User_Id_TextBox.Name = "User_Id_TextBox";
            this.User_Id_TextBox.Size = new System.Drawing.Size(534, 21);
            this.User_Id_TextBox.TabIndex = 2;
            this.User_Id_TextBox.Text = "c";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(71, 88);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(534, 21);
            this.Password_TextBox.TabIndex = 3;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 91);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 12);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // label_Oracle_Version
            // 
            this.label_Oracle_Version.AutoSize = true;
            this.label_Oracle_Version.Location = new System.Drawing.Point(12, 118);
            this.label_Oracle_Version.Name = "label_Oracle_Version";
            this.label_Oracle_Version.Size = new System.Drawing.Size(89, 12);
            this.label_Oracle_Version.TabIndex = 5;
            this.label_Oracle_Version.Text = "Oracle Version";
            // 
            // richTextBox_Even
            // 
            this.richTextBox_Even.Location = new System.Drawing.Point(12, 419);
            this.richTextBox_Even.Name = "richTextBox_Even";
            this.richTextBox_Even.Size = new System.Drawing.Size(776, 59);
            this.richTextBox_Even.TabIndex = 7;
            this.richTextBox_Even.Text = "";
            // 
            // Select_button
            // 
            this.Select_button.Location = new System.Drawing.Point(713, 151);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(75, 23);
            this.Select_button.TabIndex = 8;
            this.Select_button.Text = "Select ";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.員工編號,
            this.姓名,
            this.狀態,
            this.記錄時間,
            this.備注});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 233);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // 員工編號
            // 
            this.員工編號.Text = "員工編號";
            this.員工編號.Width = 123;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            this.姓名.Width = 107;
            // 
            // 狀態
            // 
            this.狀態.Text = "狀態";
            this.狀態.Width = 109;
            // 
            // 記錄時間
            // 
            this.記錄時間.Text = "記錄時間";
            this.記錄時間.Width = 92;
            // 
            // 備注
            // 
            this.備注.Text = "備注";
            this.備注.Width = 93;
            // 
            // PERSONNEL_NUMBER
            // 
            this.PERSONNEL_NUMBER.Location = new System.Drawing.Point(14, 133);
            this.PERSONNEL_NUMBER.Name = "PERSONNEL_NUMBER";
            this.PERSONNEL_NUMBER.Size = new System.Drawing.Size(100, 21);
            this.PERSONNEL_NUMBER.TabIndex = 11;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(120, 133);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(100, 21);
            this.NAME.TabIndex = 12;
            // 
            // STATUS
            // 
            this.STATUS.Location = new System.Drawing.Point(226, 133);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(100, 21);
            this.STATUS.TabIndex = 13;
            // 
            // ANNOTATION
            // 
            this.ANNOTATION.Location = new System.Drawing.Point(332, 133);
            this.ANNOTATION.Name = "ANNOTATION";
            this.ANNOTATION.Size = new System.Drawing.Size(100, 21);
            this.ANNOTATION.TabIndex = 14;
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(438, 133);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(75, 23);
            this.Insert_button.TabIndex = 15;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1246, 490);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.ANNOTATION);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.PERSONNEL_NUMBER);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.richTextBox_Even);
            this.Controls.Add(this.label_Oracle_Version);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.User_Id_TextBox);
            this.Controls.Add(this.label_User_Id);
            this.Controls.Add(this.Connect_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label_User_Id;
        private System.Windows.Forms.TextBox User_Id_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Oracle_Version;
        private System.Windows.Forms.RichTextBox richTextBox_Even;
        private System.Windows.Forms.Button Select_button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 員工編號;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 狀態;
        private System.Windows.Forms.ColumnHeader 記錄時間;
        private System.Windows.Forms.ColumnHeader 備注;
        private System.Windows.Forms.TextBox PERSONNEL_NUMBER;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox STATUS;
        private System.Windows.Forms.TextBox ANNOTATION;
        private System.Windows.Forms.Button Insert_button;
    }
}

