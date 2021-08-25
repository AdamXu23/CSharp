
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
            this.SQL_SELECT_button = new System.Windows.Forms.Button();
            this.SQL_DATA = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SQL_IN_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.SQL_DATA)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open_button
            // 
            this.Open_button.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Open_button.Location = new System.Drawing.Point(571, 13);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(148, 57);
            this.Open_button.TabIndex = 0;
            this.Open_button.Text = "Open";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // SQL_LOG
            // 
            this.SQL_LOG.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQL_LOG.Location = new System.Drawing.Point(12, 720);
            this.SQL_LOG.Multiline = true;
            this.SQL_LOG.Name = "SQL_LOG";
            this.SQL_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQL_LOG.Size = new System.Drawing.Size(1018, 165);
            this.SQL_LOG.TabIndex = 1;
            // 
            // SQL_SELECT_button
            // 
            this.SQL_SELECT_button.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SQL_SELECT_button.Location = new System.Drawing.Point(3, 7);
            this.SQL_SELECT_button.Name = "SQL_SELECT_button";
            this.SQL_SELECT_button.Size = new System.Drawing.Size(148, 57);
            this.SQL_SELECT_button.TabIndex = 2;
            this.SQL_SELECT_button.Text = "SQL SELECT";
            this.SQL_SELECT_button.UseVisualStyleBackColor = true;
            this.SQL_SELECT_button.Click += new System.EventHandler(this.Read_All_button_Click);
            // 
            // SQL_DATA
            // 
            this.SQL_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQL_DATA.Location = new System.Drawing.Point(12, 13);
            this.SQL_DATA.Name = "SQL_DATA";
            this.SQL_DATA.RowTemplate.Height = 23;
            this.SQL_DATA.Size = new System.Drawing.Size(553, 701);
            this.SQL_DATA.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(571, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 635);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SQL_IN_button);
            this.tabPage1.Controls.Add(this.SQL_SELECT_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SQL_IN_button
            // 
            this.SQL_IN_button.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SQL_IN_button.Location = new System.Drawing.Point(3, 70);
            this.SQL_IN_button.Name = "SQL_IN_button";
            this.SQL_IN_button.Size = new System.Drawing.Size(148, 57);
            this.SQL_IN_button.TabIndex = 3;
            this.SQL_IN_button.Text = "SQL IN";
            this.SQL_IN_button.UseVisualStyleBackColor = true;
            this.SQL_IN_button.Click += new System.EventHandler(this.SQL_IN_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(451, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 899);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Open_button);
            this.Controls.Add(this.SQL_DATA);
            this.Controls.Add(this.SQL_LOG);
            this.Name = "Form1";
            this.Text = "44444444444444444t";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SQL_DATA)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.TextBox SQL_LOG;
        private System.Windows.Forms.Button SQL_SELECT_button;
        private System.Windows.Forms.DataGridView SQL_DATA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SQL_IN_button;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

