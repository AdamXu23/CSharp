
namespace XmlDocument_TEST
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DefaultDeviceID_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PortType_CB = new System.Windows.Forms.ComboBox();
            this.MultipleOpen_CB = new System.Windows.Forms.CheckBox();
            this.MonitorEnabled_CB = new System.Windows.Forms.CheckBox();
            this.AutoDevice_CB = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LinkTestTimer_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.RemoteIPPort_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LocalIPPort_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RemoteIPAddress_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LocalIPAddress_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConnectionMode_CB = new System.Windows.Forms.ComboBox();
            this.T8_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.T7_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.T6_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.T5_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T3_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDeviceID_numericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkTestTimer_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteIPPort_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalIPPort_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T8_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T7_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T6_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T5_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T3_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DefaultDeviceID_numericUpDown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PortType_CB);
            this.tabPage1.Controls.Add(this.MultipleOpen_CB);
            this.tabPage1.Controls.Add(this.MonitorEnabled_CB);
            this.tabPage1.Controls.Add(this.AutoDevice_CB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SECS_General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DefaultDeviceID_numericUpDown
            // 
            this.DefaultDeviceID_numericUpDown.Location = new System.Drawing.Point(98, 102);
            this.DefaultDeviceID_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.DefaultDeviceID_numericUpDown.Name = "DefaultDeviceID_numericUpDown";
            this.DefaultDeviceID_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DefaultDeviceID_numericUpDown.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DefaultDeviceID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PortType";
            // 
            // PortType_CB
            // 
            this.PortType_CB.FormattingEnabled = true;
            this.PortType_CB.Location = new System.Drawing.Point(98, 75);
            this.PortType_CB.Name = "PortType_CB";
            this.PortType_CB.Size = new System.Drawing.Size(121, 21);
            this.PortType_CB.TabIndex = 3;
            // 
            // MultipleOpen_CB
            // 
            this.MultipleOpen_CB.AutoSize = true;
            this.MultipleOpen_CB.Location = new System.Drawing.Point(6, 52);
            this.MultipleOpen_CB.Name = "MultipleOpen_CB";
            this.MultipleOpen_CB.Size = new System.Drawing.Size(88, 17);
            this.MultipleOpen_CB.TabIndex = 2;
            this.MultipleOpen_CB.Text = "MultipleOpen";
            this.MultipleOpen_CB.UseVisualStyleBackColor = true;
            // 
            // MonitorEnabled_CB
            // 
            this.MonitorEnabled_CB.AutoSize = true;
            this.MonitorEnabled_CB.Location = new System.Drawing.Point(6, 29);
            this.MonitorEnabled_CB.Name = "MonitorEnabled_CB";
            this.MonitorEnabled_CB.Size = new System.Drawing.Size(100, 17);
            this.MonitorEnabled_CB.TabIndex = 1;
            this.MonitorEnabled_CB.Text = "MonitorEnabled";
            this.MonitorEnabled_CB.UseVisualStyleBackColor = true;
            // 
            // AutoDevice_CB
            // 
            this.AutoDevice_CB.AutoSize = true;
            this.AutoDevice_CB.Location = new System.Drawing.Point(6, 6);
            this.AutoDevice_CB.Name = "AutoDevice_CB";
            this.AutoDevice_CB.Size = new System.Drawing.Size(82, 17);
            this.AutoDevice_CB.TabIndex = 0;
            this.AutoDevice_CB.Text = "AutoDevice";
            this.AutoDevice_CB.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LinkTestTimer_numericUpDown);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.RemoteIPPort_numericUpDown);
            this.tabPage2.Controls.Add(this.LocalIPPort_numericUpDown);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.RemoteIPAddress_textBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.LocalIPAddress_textBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ConnectionMode_CB);
            this.tabPage2.Controls.Add(this.T8_numericUpDown);
            this.tabPage2.Controls.Add(this.T7_numericUpDown);
            this.tabPage2.Controls.Add(this.T6_numericUpDown);
            this.tabPage2.Controls.Add(this.T5_numericUpDown);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.T3_numericUpDown);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SECS_HSMS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LinkTestTimer_numericUpDown
            // 
            this.LinkTestTimer_numericUpDown.Location = new System.Drawing.Point(101, 269);
            this.LinkTestTimer_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.LinkTestTimer_numericUpDown.Name = "LinkTestTimer_numericUpDown";
            this.LinkTestTimer_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LinkTestTimer_numericUpDown.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "LinkTestTimer";
            // 
            // RemoteIPPort_numericUpDown
            // 
            this.RemoteIPPort_numericUpDown.Location = new System.Drawing.Point(101, 243);
            this.RemoteIPPort_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.RemoteIPPort_numericUpDown.Name = "RemoteIPPort_numericUpDown";
            this.RemoteIPPort_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.RemoteIPPort_numericUpDown.TabIndex = 20;
            // 
            // LocalIPPort_numericUpDown
            // 
            this.LocalIPPort_numericUpDown.Location = new System.Drawing.Point(101, 217);
            this.LocalIPPort_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.LocalIPPort_numericUpDown.Name = "LocalIPPort_numericUpDown";
            this.LocalIPPort_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LocalIPPort_numericUpDown.TabIndex = 19;
            this.LocalIPPort_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "RemoteIPPort";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "LocalIPPort";
            // 
            // RemoteIPAddress_textBox
            // 
            this.RemoteIPAddress_textBox.Location = new System.Drawing.Point(100, 191);
            this.RemoteIPAddress_textBox.Name = "RemoteIPAddress_textBox";
            this.RemoteIPAddress_textBox.Size = new System.Drawing.Size(120, 20);
            this.RemoteIPAddress_textBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "RemoteIPAddress";
            // 
            // LocalIPAddress_textBox
            // 
            this.LocalIPAddress_textBox.Location = new System.Drawing.Point(101, 165);
            this.LocalIPAddress_textBox.Name = "LocalIPAddress_textBox";
            this.LocalIPAddress_textBox.Size = new System.Drawing.Size(120, 20);
            this.LocalIPAddress_textBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "LocalIPAddress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "ConnectionMode";
            // 
            // ConnectionMode_CB
            // 
            this.ConnectionMode_CB.FormattingEnabled = true;
            this.ConnectionMode_CB.Location = new System.Drawing.Point(100, 138);
            this.ConnectionMode_CB.Name = "ConnectionMode_CB";
            this.ConnectionMode_CB.Size = new System.Drawing.Size(121, 21);
            this.ConnectionMode_CB.TabIndex = 10;
            // 
            // T8_numericUpDown
            // 
            this.T8_numericUpDown.Location = new System.Drawing.Point(101, 112);
            this.T8_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.T8_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T8_numericUpDown.Name = "T8_numericUpDown";
            this.T8_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.T8_numericUpDown.TabIndex = 9;
            this.T8_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // T7_numericUpDown
            // 
            this.T7_numericUpDown.Location = new System.Drawing.Point(101, 86);
            this.T7_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.T7_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T7_numericUpDown.Name = "T7_numericUpDown";
            this.T7_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.T7_numericUpDown.TabIndex = 8;
            this.T7_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // T6_numericUpDown
            // 
            this.T6_numericUpDown.Location = new System.Drawing.Point(101, 60);
            this.T6_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.T6_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T6_numericUpDown.Name = "T6_numericUpDown";
            this.T6_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.T6_numericUpDown.TabIndex = 7;
            this.T6_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // T5_numericUpDown
            // 
            this.T5_numericUpDown.Location = new System.Drawing.Point(101, 34);
            this.T5_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.T5_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T5_numericUpDown.Name = "T5_numericUpDown";
            this.T5_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.T5_numericUpDown.TabIndex = 6;
            this.T5_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "T8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "T7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "T6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "T5";
            // 
            // T3_numericUpDown
            // 
            this.T3_numericUpDown.Location = new System.Drawing.Point(101, 8);
            this.T3_numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.T3_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T3_numericUpDown.Name = "T3_numericUpDown";
            this.T3_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.T3_numericUpDown.TabIndex = 1;
            this.T3_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "T3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultDeviceID_numericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkTestTimer_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteIPPort_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalIPPort_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T8_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T7_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T6_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T5_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T3_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox AutoDevice_CB;
        private System.Windows.Forms.CheckBox MonitorEnabled_CB;
        private System.Windows.Forms.CheckBox MultipleOpen_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortType_CB;
        private System.Windows.Forms.NumericUpDown DefaultDeviceID_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown T8_numericUpDown;
        private System.Windows.Forms.NumericUpDown T7_numericUpDown;
        private System.Windows.Forms.NumericUpDown T6_numericUpDown;
        private System.Windows.Forms.NumericUpDown T5_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown T3_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ConnectionMode_CB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LinkTestTimer_numericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown RemoteIPPort_numericUpDown;
        private System.Windows.Forms.NumericUpDown LocalIPPort_numericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RemoteIPAddress_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LocalIPAddress_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

