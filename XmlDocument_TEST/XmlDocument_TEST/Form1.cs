using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlDocument_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //插入節點
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("bookstore.xml");
            XmlNode root = xmlDoc.SelectSingleNode("bookstore");//查詢
            XmlElement xe1 = xmlDoc.CreateElement("book");//建立一個節點
            xe1.SetAttribute("genre","李贊紅");//設定該節點genre屬性
            xe1.SetAttribute("ISBN","1123456789");//設定該節點ISBN屬性

            XmlElement xesub1 = xmlDoc.CreateElement("title");
            xesub1.InnerText ="CS從入門到精通";//設定文字節點
            xe1.AppendChild(xesub1);//新增到節點中
            XmlElement xesub2 = xmlDoc.CreateElement("author");
            xesub2.InnerText ="候捷";
            xe1.AppendChild(xesub2);
            XmlElement xesub3 = xmlDoc.CreateElement("price");
            xesub3.InnerText ="58.3";
            xe1.AppendChild(xesub3);

            root.AppendChild(xe1);//新增到節點中
            xmlDoc.Save("bookstore.xml");


            //修改節點
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("bookstore").ChildNodes;//獲取bookstore節點的所有子節點
            foreach (XmlNode xn in nodeList)//遍歷所有子節點
            {
                XmlElement xe = (XmlElement)xn;//將子節點型別轉換為XmlElement型別
                if (xe.GetAttribute("genre") =="李贊紅")//如果genre屬性值為"李贊紅"
{
                    xe.SetAttribute("genre","update李贊紅");//則修改該屬性為"update李贊紅"

                    XmlNodeList nls = xe.ChildNodes;//繼續獲取xe子節點的所有子節點
                    foreach (XmlNode xn1 in nls)//遍歷
                    {
                        XmlElement xe2 = (XmlElement)xn1;//轉換型別
                        if (xe2.Name =="author")//如果找到
{
                            xe2.InnerText ="亞勝";//則修改
                            break;//找到退出來就可以了
                        }
                    }
                    break;
                }
            }
            xmlDoc.Save("bookstore.xml");//儲存。

            //刪除節點
            XmlNodeList xnl = xmlDoc.SelectSingleNode("bookstore").ChildNodes;

            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("genre") =="fantasy")
                {
                    //刪除genre屬性
                    xe.RemoveAttribute("genre");
                }
                else if (xe.GetAttribute("genre") =="update李贊紅")
                {
                    xe.RemoveAll();//刪除該節點的全部內容
                }
            }
            xmlDoc.Save("bookstore.xml");

        }
    }
}
