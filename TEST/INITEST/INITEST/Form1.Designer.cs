namespace INITEST
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_section = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Value = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_section
            // 
            this.textBox_section.Location = new System.Drawing.Point(33, 67);
            this.textBox_section.Name = "textBox_section";
            this.textBox_section.Size = new System.Drawing.Size(106, 21);
            this.textBox_section.TabIndex = 1;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(33, 110);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(106, 21);
            this.textBox_key.TabIndex = 2;
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(175, 110);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(106, 21);
            this.textBox_Value.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Value
            // 
            this.label_Value.AutoSize = true;
            this.label_Value.Location = new System.Drawing.Point(327, 113);
            this.label_Value.Name = "label_Value";
            this.label_Value.Size = new System.Drawing.Size(41, 12);
            this.label_Value.TabIndex = 7;
            this.label_Value.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_Value);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Value);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_section);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_section;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Value;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

