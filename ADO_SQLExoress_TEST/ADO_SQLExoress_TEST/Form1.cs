using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;//引用運行環境時間
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

        //顯示連綫參數
        private void ShowConnection()
        {
            SQL_LOG.AppendText( DateTime.Now.ToString() + Environment.NewLine);
            SQL_LOG.AppendText("ConnectionString\t:" + cn.ConnectionString + Environment.NewLine);
            SQL_LOG.AppendText("ConnectionTimeout\t:" + cn.ConnectionTimeout + Environment.NewLine);
            SQL_LOG.AppendText("Database\t\t:" + cn.Database + Environment.NewLine);
            SQL_LOG.AppendText("DataSource\t\t:" + cn.DataSource + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //創建鏈接字串
            cn.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Administrator\\Documents\\GitHub\\CSharp\\ADO_SQLExoress_TEST\\ADO_SQLExoress_TEST\\MyDB.mdf; Integrated Security = True";
            //顯示鏈接參數
            ShowConnection();
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            //判斷資料路目前的狀態
            if(cn.State == ConnectionState.Closed)
            {
                //資料庫如果沒有連綫
                cn.Open();
                Open_button.Text = "Close";
                SQL_LOG.AppendText(DateTime.Now.ToString() + Environment.NewLine);
                SQL_LOG.AppendText("Event\t\t:Database is linked." + Environment.NewLine);
            }
            else
            {
                cn.Close();
                Open_button.Text = "Open";
                SQL_LOG.AppendText(DateTime.Now.ToString() + Environment.NewLine);
                SQL_LOG.AppendText("Event\t\t:Database disconnected." + Environment.NewLine);
            }
        }

        private void Read_All_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            SQL_LOG.AppendText(DateTime.Now.ToString() + Environment.NewLine);
            SQL_LOG.AppendText("CMD\t\t:" + cmd.CommandText + Environment.NewLine);
            //輸出欄位内容
            string Field_Content_Str = string.Empty;
            for(int i = 0; i < dr.FieldCount; i++)
            {
                Field_Content_Str += dr.GetName(i) + "\t";
            }
            SQL_LOG.AppendText( Field_Content_Str + Environment.NewLine + Environment.NewLine);
        }
    }
}
