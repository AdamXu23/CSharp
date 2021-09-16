using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess;

namespace Oracle_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class OracleHelper
        {
            private static string connStr = "User Id=C##ADAMXU;Password=XSZ19930323;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-ORACLE)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=orcl)))";
            #region 執行SQL語句,返回DataTable;只用來執行查詢結果比較少的情況
            public static DataTable ExecuteDataTable()
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "Select * From ATTENDANCE a Where PERSONNEL_NUMBER>0";
                        //cmd.Parameters.AddRange(new OracleParameter(":id", 0));
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        DataTable datatable = new DataTable();
                        adapter.Fill(datatable);
                        return datatable;
                    }
                }
            }
            #endregion
        }
        private void Connect_Button_Click(object sender, EventArgs e)
        { 
        }
        private void Select_button_Click(object sender, EventArgs e)
        {
        DataTable dt = OracleHelper.ExecuteDataTable();
        listView1.Items.Clear();
        foreach (DataRow row in dt.Rows)
            {
            int i;
            richTextBox_Even.Text = richTextBox_Even.Text + "\n";
            ListViewItem item = new ListViewItem();
            item.SubItems.Clear();
            i = 0;
            foreach (DataColumn column in dt.Columns)
                {
                if (i == 0)
                    {
                    item.SubItems[0].Text = row[column].ToString();
                    }
                else
                    {
                    item.SubItems.Add(row[column].ToString());
                    }
                richTextBox_Even.Text = richTextBox_Even.Text + "  " + row[column].ToString();
                i = i + 1;
                Console.WriteLine(row[column]);
                }
            listView1.Items.Add(item);
            }           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Insert_button_Click(object sender, EventArgs e)
        {

        }

        private void aTTENDANCEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}