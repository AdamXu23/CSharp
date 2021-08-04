using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;//引用ADO.NET基礎物件
//using System.Data.OleDb;//引用OLE DB資料來源物件
using System.Data.SqlClient;//引用SQL Server 資料來源物件

namespace ADO_SQLExoress_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //建立SqlConnection物件
        SqlConnection cn = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = 
        }

        private void Open_button_Click(object sender, EventArgs e)
        {

        }
    }
}
