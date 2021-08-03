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
        //創建 dc 屬於DataColumn物件，
        DataColumn dc = new DataColumn();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //清空DataSet物件
            ds.Clear();
            //讀取XML_TEST.xml文件
            ds.ReadXml("XML_TEST.xml");
            //在dataGridView1上顯示XML_TEST中item類別的項目
            dataGridView1.DataSource = ds.Tables["item"];

            //Find
            // 并且設定item類別中的Product_name為主鍵
            dc = ds.Tables["item"].Columns["Product_name"];
            //設定主鍵名稱為PK_Product_name
            ds.Tables["item"].Constraints.Add("PK_Product_name", dc, true);
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            //清空Find_Result的顯示
            Find_Result.Text = string.Empty;
            //創建 ds 屬於DataSet物件
            ds.Clear();
            //讀取XML_TEST.xml文件
            ds.ReadXml("XML_TEST.xml");
            //利用DataRowCollection的Find方法搜尋主鍵為Product_name.Text的資料
            DataRow dr = ds.Tables["item"].Rows.Find(Product_name.Text);
            //判斷是否有查找到資料，資料沒有查找到 dr==null
            if (dr == null)
            {
                //輸出查找不到的結果
                Find_Result.Text = "Product name without " + Product_name.Text;
            }
            else
            {
                //輸出查找結果
                Find_Result.AppendText("Product name:" + dr["Product_name"] + "\r\n");
                Find_Result.AppendText("Quantity:" + dr["Quantity"] + "\r\n");
                Find_Result.AppendText("Cost:" + dr["Cost"] + "\r\n");
                Find_Result.AppendText("Selling price:" + dr["Selling_price"] + "\r\n");

            }
        }
    }

}
