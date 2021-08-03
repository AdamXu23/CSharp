using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace XML_TEST
{
    public partial class Form1 : Form
    {
        //創建 ds 屬於DataSet物件
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //讀取XML_TEST.xml文件
            ds.ReadXml("XML_TEST.xml");
            dataGridView1.DataSource = ds.Tables["item"];
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            Find_Result.Text = string.Empty;
            ds.ReadXml("XML_TEST.xml");
            DataColumn dc = ds.Tables["commodity"].Columns["Product_name"];
        }
    }

}
