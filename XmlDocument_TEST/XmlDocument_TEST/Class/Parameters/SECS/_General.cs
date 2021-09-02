using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Brooks.WinSECS;

namespace XmlDocument_TEST
{
    class _General
    {

        private string xmlName = "Parameters.xml";
        private XmlDocument document = new XmlDocument();
        private XmlNode Parameters_NODE;
        private XmlNode SECS_Node;
        private XmlNode General_Node;
        public _General(XmlDocument _XmlDocument, string _xmlName)
        {
            document = _XmlDocument;
            Parameters_NODE = document.SelectSingleNode("Parameters");
            SECS_Node = Parameters_NODE.SelectSingleNode("SECS");
            General_Node = SECS_Node.SelectSingleNode("General");
            if (General_Node == null)
            {
                General_Node = document.CreateElement("General");
                SECS_Node.AppendChild(General_Node);//新增到 SECS 節點中


                XmlElement AutoDevice = document.CreateElement("AutoDevice");
                AutoDevice.InnerText = true.ToString();
                General_Node.AppendChild(AutoDevice);//新增到 SECS 節點中

                XmlElement SECS_MonitorEnabled = document.CreateElement("MonitorEnabled");
                SECS_MonitorEnabled.InnerText = false.ToString();
                General_Node.AppendChild(SECS_MonitorEnabled);//新增到 SECS 節點中

                XmlElement SECS_MultipleOpen = document.CreateElement("MultipleOpen");
                SECS_MultipleOpen.InnerText = true.ToString();
                General_Node.AppendChild(SECS_MultipleOpen);//新增到 SECS 節點中

                XmlElement SECS_PortType = document.CreateElement("PortType");
                SECS_PortType.InnerText = SECS_PORT_TYPE.HSMS.ToString();
                General_Node.AppendChild(SECS_PortType);//新增到 SECS 節點中

                XmlElement SECS_DefaultDeviceID = document.CreateElement("DefaultDeviceID");
                long DefaultDeviceID = 0;
                SECS_DefaultDeviceID.InnerText = DefaultDeviceID.ToString();
                General_Node.AppendChild(SECS_DefaultDeviceID);//新增到 SECS 節點中

                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }
        }

        public bool AutoDevice
        {
            get
            {
                XmlElement General_AutoDevice = (XmlElement)General_Node.SelectSingleNode("AutoDevice");
                return bool.Parse(General_AutoDevice.InnerText);
            }
            set
            {
                XmlElement General_AutoDevice = (XmlElement)General_Node.SelectSingleNode("AutoDevice");
                General_AutoDevice.InnerText = value.ToString();
            }
        }
        public bool MonitorEnabled
        {
            get
            {
                XmlElement General_MonitorEnabled = (XmlElement)General_Node.SelectSingleNode("MonitorEnabled");
                return bool.Parse(General_MonitorEnabled.InnerText);
            }
            set
            {
                XmlElement General_MonitorEnabled = (XmlElement)General_Node.SelectSingleNode("MonitorEnabled");
                General_MonitorEnabled.InnerText = value.ToString();
            }
        }
        public bool MultipleOpen
        {
            get
            {
                XmlElement General_MultipleOpen = (XmlElement)General_Node.SelectSingleNode("MultipleOpen");
                return bool.Parse(General_MultipleOpen.InnerText);
            }
            set
            {
                XmlElement General_MultipleOpen = (XmlElement)General_Node.SelectSingleNode("MultipleOpen");
                General_MultipleOpen.InnerText = value.ToString();
            }
        }
        public SECS_PORT_TYPE PortType
        {
            get
            {
                XmlElement General_PortType = (XmlElement)General_Node.SelectSingleNode("PortType");

                return (SECS_PORT_TYPE)Enum.Parse(typeof(SECS_PORT_TYPE), General_PortType.InnerText);
            }
            set
            {
                XmlElement General_PortType = (XmlElement)General_Node.SelectSingleNode("PortType");
                General_PortType.InnerText = value.ToString();
            }
        }
        public long DefaultDeviceID
        {
            get
            {
                XmlElement General_DefaultDeviceID = (XmlElement)General_Node.SelectSingleNode("DefaultDeviceID");

                return long.Parse(General_DefaultDeviceID.InnerText);
            }
            set
            {
                XmlElement General_DefaultDeviceID = (XmlElement)General_Node.SelectSingleNode("DefaultDeviceID");
                General_DefaultDeviceID.InnerText = value.ToString();
            }
        }
    }
}
