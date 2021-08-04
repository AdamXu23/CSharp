
namespace ADO_SQLExoress_TEST
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_button = new System.Windows.Forms.Button();
            this.SQL_LOG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Open_button
            // 
            this.Open_button.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Open_button.Location = new System.Drawing.Point(12, 12);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(193, 39);
            this.Open_button.TabIndex = 0;
            this.Open_button.Text = "Open";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // SQL_LOG
            // 
            this.SQL_LOG.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQL_LOG.Location = new System.Drawing.Point(12, 57);
            this.SQL_LOG.Multiline = true;
            this.SQL_LOG.Name = "SQL_LOG";
            this.SQL_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQL_LOG.Size = new System.Drawing.Size(1018, 381);
            this.SQL_LOG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.SQL_LOG);
            this.Controls.Add(this.Open_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.TextBox SQL_LOG;
    }
}

