using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_ODP_TEST_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aTTENDANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aTTENDANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.ATTENDANCE”中。您可以根据需要移动或删除它。
            this.aTTENDANCETableAdapter.Fill(this.dataSet1.ATTENDANCE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.aTTENDANCETableAdapter.Update();
        }
    }
}
