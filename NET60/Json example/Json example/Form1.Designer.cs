namespace Json_example
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
            this.SuspendLayout();
            // 
            // Send_BT
            // 
            this.Send_BT.Location = new System.Drawing.Point(479, 88);
            this.Send_BT.Name = "Send_BT";
            this.Send_BT.Size = new System.Drawing.Size(75, 23);
            this.Send_BT.TabIndex = 0;
            this.Send_BT.Text = "Send";
            this.Send_BT.UseVisualStyleBackColor = true;
            this.Send_BT.Click += new System.EventHandler(this.Send_BT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Send_BT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Send_BT;
    }
}