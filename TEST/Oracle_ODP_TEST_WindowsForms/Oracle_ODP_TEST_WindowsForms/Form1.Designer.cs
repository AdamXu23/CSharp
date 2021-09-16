namespace Oracle_ODP_TEST_WindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label pERSONNEL_NUMBERLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label rECORD_TIMELabel;
            System.Windows.Forms.Label aNNOTATIONLabel;
            this.aTTENDANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aTTENDANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aTTENDANCEDataGridView = new System.Windows.Forms.DataGridView();
            this.pERSONNEL_NUMBERTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.rECORD_TIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aNNOTATIONTextBox = new System.Windows.Forms.TextBox();
            this.aTTENDANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Oracle_ODP_TEST_WindowsForms.DataSet1();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTENDANCETableAdapter = new Oracle_ODP_TEST_WindowsForms.DataSet1TableAdapters.ATTENDANCETableAdapter();
            this.tableAdapterManager = new Oracle_ODP_TEST_WindowsForms.DataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            pERSONNEL_NUMBERLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            rECORD_TIMELabel = new System.Windows.Forms.Label();
            aNNOTATIONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingNavigator)).BeginInit();
            this.aTTENDANCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // aTTENDANCEBindingNavigator
            // 
            this.aTTENDANCEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aTTENDANCEBindingNavigator.BindingSource = this.aTTENDANCEBindingSource;
            this.aTTENDANCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aTTENDANCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aTTENDANCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aTTENDANCEBindingNavigatorSaveItem});
            this.aTTENDANCEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aTTENDANCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aTTENDANCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aTTENDANCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aTTENDANCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aTTENDANCEBindingNavigator.Name = "aTTENDANCEBindingNavigator";
            this.aTTENDANCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aTTENDANCEBindingNavigator.Size = new System.Drawing.Size(990, 25);
            this.aTTENDANCEBindingNavigator.TabIndex = 0;
            this.aTTENDANCEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // aTTENDANCEBindingNavigatorSaveItem
            // 
            this.aTTENDANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aTTENDANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aTTENDANCEBindingNavigatorSaveItem.Image")));
            this.aTTENDANCEBindingNavigatorSaveItem.Name = "aTTENDANCEBindingNavigatorSaveItem";
            this.aTTENDANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aTTENDANCEBindingNavigatorSaveItem.Text = "保存数据";
            this.aTTENDANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.aTTENDANCEBindingNavigatorSaveItem_Click);
            // 
            // aTTENDANCEDataGridView
            // 
            this.aTTENDANCEDataGridView.AutoGenerateColumns = false;
            this.aTTENDANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aTTENDANCEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aTTENDANCEDataGridView.DataSource = this.aTTENDANCEBindingSource;
            this.aTTENDANCEDataGridView.Location = new System.Drawing.Point(12, 28);
            this.aTTENDANCEDataGridView.Name = "aTTENDANCEDataGridView";
            this.aTTENDANCEDataGridView.RowTemplate.Height = 23;
            this.aTTENDANCEDataGridView.Size = new System.Drawing.Size(544, 410);
            this.aTTENDANCEDataGridView.TabIndex = 1;
            // 
            // pERSONNEL_NUMBERLabel
            // 
            pERSONNEL_NUMBERLabel.AutoSize = true;
            pERSONNEL_NUMBERLabel.Location = new System.Drawing.Point(562, 31);
            pERSONNEL_NUMBERLabel.Name = "pERSONNEL_NUMBERLabel";
            pERSONNEL_NUMBERLabel.Size = new System.Drawing.Size(107, 12);
            pERSONNEL_NUMBERLabel.TabIndex = 2;
            pERSONNEL_NUMBERLabel.Text = "PERSONNEL NUMBER:";
            // 
            // pERSONNEL_NUMBERTextBox
            // 
            this.pERSONNEL_NUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTTENDANCEBindingSource, "PERSONNEL_NUMBER", true));
            this.pERSONNEL_NUMBERTextBox.Location = new System.Drawing.Point(675, 28);
            this.pERSONNEL_NUMBERTextBox.Name = "pERSONNEL_NUMBERTextBox";
            this.pERSONNEL_NUMBERTextBox.Size = new System.Drawing.Size(200, 21);
            this.pERSONNEL_NUMBERTextBox.TabIndex = 3;
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(562, 58);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(35, 12);
            nAMELabel.TabIndex = 4;
            nAMELabel.Text = "NAME:";
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTTENDANCEBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(675, 55);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(200, 21);
            this.nAMETextBox.TabIndex = 5;
            // 
            // rECORD_TIMELabel
            // 
            rECORD_TIMELabel.AutoSize = true;
            rECORD_TIMELabel.Location = new System.Drawing.Point(562, 88);
            rECORD_TIMELabel.Name = "rECORD_TIMELabel";
            rECORD_TIMELabel.Size = new System.Drawing.Size(77, 12);
            rECORD_TIMELabel.TabIndex = 6;
            rECORD_TIMELabel.Text = "RECORD TIME:";
            // 
            // rECORD_TIMEDateTimePicker
            // 
            this.rECORD_TIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aTTENDANCEBindingSource, "RECORD_TIME", true));
            this.rECORD_TIMEDateTimePicker.Location = new System.Drawing.Point(675, 82);
            this.rECORD_TIMEDateTimePicker.Name = "rECORD_TIMEDateTimePicker";
            this.rECORD_TIMEDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.rECORD_TIMEDateTimePicker.TabIndex = 7;
            // 
            // aNNOTATIONLabel
            // 
            aNNOTATIONLabel.AutoSize = true;
            aNNOTATIONLabel.Location = new System.Drawing.Point(562, 112);
            aNNOTATIONLabel.Name = "aNNOTATIONLabel";
            aNNOTATIONLabel.Size = new System.Drawing.Size(71, 12);
            aNNOTATIONLabel.TabIndex = 8;
            aNNOTATIONLabel.Text = "ANNOTATION:";
            // 
            // aNNOTATIONTextBox
            // 
            this.aNNOTATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTTENDANCEBindingSource, "ANNOTATION", true));
            this.aNNOTATIONTextBox.Location = new System.Drawing.Point(675, 109);
            this.aNNOTATIONTextBox.Name = "aNNOTATIONTextBox";
            this.aNNOTATIONTextBox.Size = new System.Drawing.Size(200, 21);
            this.aNNOTATIONTextBox.TabIndex = 9;
            // 
            // aTTENDANCEBindingSource
            // 
            this.aTTENDANCEBindingSource.DataMember = "ATTENDANCE";
            this.aTTENDANCEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PERSONNEL_NUMBER";
            this.dataGridViewTextBoxColumn1.HeaderText = "PERSONNEL_NUMBER";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn3.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RECORD_TIME";
            this.dataGridViewTextBoxColumn4.HeaderText = "RECORD_TIME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ANNOTATION";
            this.dataGridViewTextBoxColumn5.HeaderText = "ANNOTATION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // aTTENDANCETableAdapter
            // 
            this.aTTENDANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATTENDANCETableAdapter = this.aTTENDANCETableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Oracle_ODP_TEST_WindowsForms.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(aNNOTATIONLabel);
            this.Controls.Add(this.aNNOTATIONTextBox);
            this.Controls.Add(rECORD_TIMELabel);
            this.Controls.Add(this.rECORD_TIMEDateTimePicker);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(pERSONNEL_NUMBERLabel);
            this.Controls.Add(this.pERSONNEL_NUMBERTextBox);
            this.Controls.Add(this.aTTENDANCEDataGridView);
            this.Controls.Add(this.aTTENDANCEBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingNavigator)).EndInit();
            this.aTTENDANCEBindingNavigator.ResumeLayout(false);
            this.aTTENDANCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aTTENDANCEBindingSource;
        private DataSet1TableAdapters.ATTENDANCETableAdapter aTTENDANCETableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aTTENDANCEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aTTENDANCEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aTTENDANCEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox pERSONNEL_NUMBERTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.DateTimePicker rECORD_TIMEDateTimePicker;
        private System.Windows.Forms.TextBox aNNOTATIONTextBox;
        private System.Windows.Forms.Button button1;
    }
}

