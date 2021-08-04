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
            //讀取整體XML文件
            XML_Read_All();

            //Find 功能 設定
            // 并且設定item類別中的Product_name為主鍵
            dc = ds.Tables["item"].Columns["Product_name"];
            //設定主鍵名稱為PK_Product_name
            ds.Tables["item"].Constraints.Add("PK_Product_name", dc, true);
        }

        //讀取整體XML文件
        private void XML_Read_All()
        {
            //清空DataSet物件
            ds.Clear();
            //讀取XML_TEST.xml文件
            ds.ReadXml("XML_TEST.xml");
            //在dataGridView1上顯示XML_TEST中item類別的項目
            dataGridView1.DataSource = ds.Tables["item"];
        }

        //Find按鈕事件觸發
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

        private void Add_button_Click(object sender, EventArgs e)
        {
            //利用DataRowCollection的Find方法搜尋主鍵為Product_name.Text的資料
            DataRow dr = ds.Tables["item"].Rows.Find(Product_name.Text);
            //判斷是否有查找到資料，資料沒有查找到 dr==null
            if (dr == null)
            {
                //輸出查找不到的結果,添加記錄
                //新增一個MyRow 為 DataRow物件，格式為item
                DataRow MyRow = ds.Tables["item"].NewRow();
                // 填寫MyRow内部資料
                MyRow["Product_name"] = Product_name.Text;
                MyRow["Quantity"] = Quantity.Text;
                MyRow["Cost"] = Cost.Text;
                MyRow["Selling_price"] = Selling_price.Text;
                //把MyRow添加到原來的ds資料中
                ds.Tables["item"].Rows.Add(MyRow);
                //刷新顯示資料
                dataGridView1.DataSource = ds.Tables["item"];
            }
            else
            {
                //有相同資料結果輸出
                MessageBox.Show(Product_name.Text + "Product name has been duplicated!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Revise_button_Click(object sender, EventArgs e)
        {
            //利用DataRowCollection的Find方法搜尋主鍵為Product_name.Text的資料
            DataRow dr = ds.Tables["item"].Rows.Find(Product_name.Text);
            //判斷是否有查找到資料，資料沒有查找到 dr==null
            if (dr == null)
            {
                //輸出查找不到的結果,添加記錄
                MessageBox.Show(Product_name.Text + "Product name does not exist!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //有相同資料結果
                // 填寫dr内部資料
                dr["Quantity"] = Quantity.Text;
                dr["Cost"] = Cost.Text;
                dr["Selling_price"] = Selling_price.Text;
                //刷新顯示資料
                dataGridView1.DataSource = ds.Tables["item"];
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            //利用DataRowCollection的Find方法搜尋主鍵為Product_name.Text的資料
            DataRow dr = ds.Tables["item"].Rows.Find(Product_name.Text);
            //判斷是否有查找到資料，資料沒有查找到 dr==null
            if (dr == null)
            {
                //輸出查找不到的結果,添加記錄
                MessageBox.Show(Product_name.Text + "Product name does not exist!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //有相同資料結果
                //删除记录
                ds.Tables["item"].Rows.Remove(dr);
                //刷新顯示資料
                dataGridView1.DataSource = ds.Tables["item"];
            }
        }

        private void UpData_button_Click(object sender, EventArgs e)
        {
            ds.WriteXml("XML_TEST.xml");
            MessageBox.Show("已经跟新到XML！");
        }
    }

}
