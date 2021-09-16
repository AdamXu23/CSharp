namespace IPC_Data_Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Save = new System.Windows.Forms.Button();
            this.Machine_number_textBox = new System.Windows.Forms.TextBox();
            this.SerialPort_comboBox = new System.Windows.Forms.ComboBox();
            this.Step_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Shipping_Date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_SN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(456, 57);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(114, 21);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Machine_number_textBox
            // 
            this.Machine_number_textBox.Location = new System.Drawing.Point(350, 101);
            this.Machine_number_textBox.Name = "Machine_number_textBox";
            this.Machine_number_textBox.Size = new System.Drawing.Size(220, 21);
            this.Machine_number_textBox.TabIndex = 1;
            this.Machine_number_textBox.Click += new System.EventHandler(this.Machine_number_textBox_Click);
            // 
            // SerialPort_comboBox
            // 
            this.SerialPort_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialPort_comboBox.FormattingEnabled = true;
            this.SerialPort_comboBox.Location = new System.Drawing.Point(350, 18);
            this.SerialPort_comboBox.Name = "SerialPort_comboBox";
            this.SerialPort_comboBox.Size = new System.Drawing.Size(220, 20);
            this.SerialPort_comboBox.TabIndex = 2;
            this.SerialPort_comboBox.DropDown += new System.EventHandler(this.SerialPort_comboBox_DropDown);
            this.SerialPort_comboBox.SelectedIndexChanged += new System.EventHandler(this.SerialPort_comboBox_SelectedIndexChanged);
            // 
            // Step_1
            // 
            this.Step_1.AutoSize = true;
            this.Step_1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Step_1.Location = new System.Drawing.Point(15, 9);
            this.Step_1.Name = "Step_1";
            this.Step_1.Size = new System.Drawing.Size(329, 29);
            this.Step_1.TabIndex = 3;
            this.Step_1.Text = "Step 1 選擇 COM Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step 2 出貨日期";
            // 
            // Shipping_Date
            // 
            this.Shipping_Date.Location = new System.Drawing.Point(350, 58);
            this.Shipping_Date.Name = "Shipping_Date";
            this.Shipping_Date.Size = new System.Drawing.Size(100, 21);
            this.Shipping_Date.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Step 3 掃描編號";
            // 
            // Save_SN
            // 
            this.Save_SN.Location = new System.Drawing.Point(576, 99);
            this.Save_SN.Name = "Save_SN";
            this.Save_SN.Size = new System.Drawing.Size(75, 23);
            this.Save_SN.TabIndex = 7;
            this.Save_SN.Text = "Save";
            this.Save_SN.UseVisualStyleBackColor = true;
            this.Save_SN.Click += new System.EventHandler(this.Save_SN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 133);
            this.Controls.Add(this.Save_SN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shipping_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Step_1);
            this.Controls.Add(this.SerialPort_comboBox);
            this.Controls.Add(this.Machine_number_textBox);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IPC Data Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Machine_number_textBox;
        private System.Windows.Forms.ComboBox SerialPort_comboBox;
        private System.Windows.Forms.Label Step_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Shipping_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save_SN;
    }
}

