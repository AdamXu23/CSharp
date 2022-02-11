namespace Geek_Plus_Json_Http
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Send_BT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Send_BT
            // 
            this.Send_BT.Location = new System.Drawing.Point(517, 144);
            this.Send_BT.Name = "Send_BT";
            this.Send_BT.Size = new System.Drawing.Size(157, 23);
            this.Send_BT.TabIndex = 0;
            this.Send_BT.Text = "Send 155-154 ";
            this.Send_BT.UseVisualStyleBackColor = true;
            this.Send_BT.Click += new System.EventHandler(this.Send_BT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send 154-155";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1313, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Send_BT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Send_BT;
        private Button button1;
        private TextBox textBox1;
    }
}