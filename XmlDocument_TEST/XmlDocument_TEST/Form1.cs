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
using System.IO;
using Brooks.WinSECS;

namespace XmlDocument_TEST
{
    public partial class Form1 : Form
    {
        string xmlName = "Parameters.xml";
        XmlDocument document = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            //XML_Read_All();
            bool result = File.Exists(xmlName);
            if (result == true)
            {
            }
            else
            {
                XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "UTF-8", "");//xml文件的宣告部分
                document.AppendChild(declaration);

                XmlElement Parameters = document.CreateElement("Parameters");
                document.AppendChild(Parameters);

                XmlElement SECS = document.CreateElement("SECS");
                Parameters.AppendChild(SECS);//新增到 Parameters 節點中

                XmlElement HSMS = document.CreateElement("HSMS");
                SECS.AppendChild(HSMS);//新增到 SECS 節點中

                XmlElement General = document.CreateElement("General");
                SECS.AppendChild(General);//新增到 SECS 節點中

                XmlElement AutoDevice = document.CreateElement("AutoDevice");
                AutoDevice.InnerText = true.ToString();
                General.AppendChild(AutoDevice);//新增到 SECS 節點中

                XmlElement SECS_MonitorEnabled = document.CreateElement("MonitorEnabled");
                SECS_MonitorEnabled.InnerText = false.ToString();
                General.AppendChild(SECS_MonitorEnabled);//新增到 SECS 節點中

                XmlElement SECS_MultipleOpen = document.CreateElement("MultipleOpen");
                SECS_MultipleOpen.InnerText = true.ToString();
                General.AppendChild(SECS_MultipleOpen);//新增到 SECS 節點中

                XmlElement SECS_PortType = document.CreateElement("PortType");
                SECS_PortType.InnerText = SECS_PORT_TYPE.HSMS.ToString();
                General.AppendChild(SECS_PortType);//新增到 SECS 節點中

                XmlElement SECS_DefaultDeviceID = document.CreateElement("DefaultDeviceID");
                long DefaultDeviceID = 0;
                SECS_DefaultDeviceID.InnerText = DefaultDeviceID.ToString();
                General.AppendChild(SECS_DefaultDeviceID);//新增到 SECS 節點中

                XmlElement SECS_T3 = document.CreateElement("T3");
                uint T = 45;
                SECS_T3.InnerText = T.ToString();
                HSMS.AppendChild(SECS_T3);//新增到 SECS 節點中

                XmlElement SECS_T5 = document.CreateElement("T5");
                T = 10;
                SECS_T5.InnerText = T.ToString();
                HSMS.AppendChild(SECS_T5);//新增到 SECS 節點中

                XmlElement SECS_T6 = document.CreateElement("T6");
                T = 5;
                SECS_T6.InnerText = T.ToString();
                HSMS.AppendChild(SECS_T6);//新增到 SECS 節點中

                XmlElement SECS_T7 = document.CreateElement("T7");
                T = 10;
                SECS_T7.InnerText = T.ToString();
                HSMS.AppendChild(SECS_T7);//新增到 SECS 節點中

                XmlElement SECS_T8 = document.CreateElement("T8");
                T = 5;
                SECS_T8.InnerText = T.ToString();
                HSMS.AppendChild(SECS_T8);//新增到 SECS 節點中

                XmlElement SECS_ConnectionMode = document.CreateElement("ConnectionMode");
                SECS_ConnectionMode.InnerText = HSMS_CONNECTION_MODE.PASSIVE.ToString();
                HSMS.AppendChild(SECS_ConnectionMode);//新增到 SECS 節點中

                XmlElement SECS_LocalIPAddress = document.CreateElement("LocalIPAddress");
                SECS_LocalIPAddress.InnerText = "127.0.0.1";
                HSMS.AppendChild(SECS_LocalIPAddress);//新增到 SECS 節點中

                XmlElement SECS_RemoteIPAddress = document.CreateElement("RemoteIPAddress");
                SECS_RemoteIPAddress.InnerText = "127.0.0.1";
                HSMS.AppendChild(SECS_RemoteIPAddress);//新增到 SECS 節點中

                XmlElement SECS_LocalIPPort = document.CreateElement("LocalIPPort");
                uint port = 5100;
                SECS_LocalIPPort.InnerText = port.ToString();
                HSMS.AppendChild(SECS_LocalIPPort);//新增到 SECS 節點中

                XmlElement SECS_RemoteIPPort = document.CreateElement("RemoteIPPort");
                SECS_RemoteIPPort.InnerText = port.ToString();
                HSMS.AppendChild(SECS_RemoteIPPort);//新增到 SECS 節點中

                XmlElement SECS_LinkTestTimer = document.CreateElement("LinkTestTimer");
                long Slt = 60;
                SECS_LinkTestTimer.InnerText = Slt.ToString();
                HSMS.AppendChild(SECS_LinkTestTimer);//新增到 SECS 節點中

                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
