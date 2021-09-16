namespace OPC_UA_Sever_Test
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
            this.components = new System.ComponentModel.Container();
            this.Cycle_Time = new System.Windows.Forms.Timer(this.components);
            this.PC_TIME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cycle_Time
            // 
            this.Cycle_Time.Interval = 1000;
            this.Cycle_Time.Tick += new System.EventHandler(this.Cycle_Time_Tick);
            this.Cycle_Time.Enabled = true;
            // 
            // PC_TIME
            // 
            this.PC_TIME.AutoSize = true;
            this.PC_TIME.Location = new System.Drawing.Point(14, 15);
            this.PC_TIME.Name = "PC_TIME";
            this.PC_TIME.Size = new System.Drawing.Size(41, 12);
            this.PC_TIME.TabIndex = 0;
            this.PC_TIME.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PC_TIME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Cycle_Time;
        private System.Windows.Forms.Label PC_TIME;
    }
}

