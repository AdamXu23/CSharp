
namespace XML_TEST
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Product_name = new System.Windows.Forms.TextBox();
            this.Find_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Revise_button = new System.Windows.Forms.Button();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Selling_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Find_Result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(516, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(538, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product name";
            // 
            // Product_name
            // 
            this.Product_name.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Product_name.Location = new System.Drawing.Point(751, 12);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(321, 38);
            this.Product_name.TabIndex = 2;
            // 
            // Find_button
            // 
            this.Find_button.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Find_button.Location = new System.Drawing.Point(1078, 12);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(207, 38);
            this.Find_button.TabIndex = 3;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = true;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Add_button.Location = new System.Drawing.Point(1078, 56);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(207, 38);
            this.Add_button.TabIndex = 6;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Quantity.Location = new System.Drawing.Point(751, 56);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(321, 38);
            this.Quantity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(538, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // Revise_button
            // 
            this.Revise_button.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Revise_button.Location = new System.Drawing.Point(1078, 100);
            this.Revise_button.Name = "Revise_button";
            this.Revise_button.Size = new System.Drawing.Size(207, 38);
            this.Revise_button.TabIndex = 9;
            this.Revise_button.Text = "Revise";
            this.Revise_button.UseVisualStyleBackColor = true;
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Cost.Location = new System.Drawing.Point(751, 100);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(321, 38);
            this.Cost.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(538, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cost";
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Delete_button.Location = new System.Drawing.Point(1078, 144);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(207, 38);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Selling_price
            // 
            this.Selling_price.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Selling_price.Location = new System.Drawing.Point(751, 144);
            this.Selling_price.Name = "Selling_price";
            this.Selling_price.Size = new System.Drawing.Size(321, 38);
            this.Selling_price.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(538, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selling price";
            // 
            // Find_Result
            // 
            this.Find_Result.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold);
            this.Find_Result.Location = new System.Drawing.Point(543, 188);
            this.Find_Result.Multiline = true;
            this.Find_Result.Name = "Find_Result";
            this.Find_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Find_Result.Size = new System.Drawing.Size(742, 250);
            this.Find_Result.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.Find_Result);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Selling_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Revise_button);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Product_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Product_name;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Revise_button;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox Selling_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Find_Result;
    }
}

