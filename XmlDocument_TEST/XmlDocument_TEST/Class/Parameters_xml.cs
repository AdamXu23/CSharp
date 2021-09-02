using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Brooks.WinSECS;
using XmlDocument_TEST;

namespace XmlDocument_TEST
{
    class Parameters_xml
    {
        private string xmlName = "Parameters.xml";
        private XmlDocument document = new XmlDocument() ;
        private XmlNode Parameters_NODE ;
        private XmlNode SECS_Node ;
        private XmlNode General_Node;
        private XmlNode HSMS_Node;
        public _SECS SECS;
        public Parameters_xml(string _xmlName)
        {
            document = new XmlDocument();
            xmlName = _xmlName;
            bool result = File.Exists(xmlName);
            if (result == true)
            {
                document.Load(xmlName);
            }
            else
            {
                XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "UTF-8", "");//xml文件的宣告部分
                document.AppendChild(declaration);

                Parameters_NODE = document.CreateElement("Parameters");
                document.AppendChild(Parameters_NODE);
                /*
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


                
                XmlElement SECS_T3 = document.CreateElement("T3");
                uint T = 45;
                SECS_T3.InnerText = T.ToString();
                HSMS_Node.AppendChild(SECS_T3);//新增到 SECS 節點中
                XmlElement SECS_T5 = document.CreateElement("T5");
                T = 10;
                SECS_T5.InnerText = T.ToString();
                HSMS_Node.AppendChild(SECS_T5);//新增到 SECS 節點中
                XmlElement SECS_T6 = document.CreateElement("T6");
                T = 5;
                SECS_T6.InnerText = T.ToString();
                HSMS_Node.AppendChild(SECS_T6);//新增到 SECS 節點中
                XmlElement SECS_T7 = document.CreateElement("T7");
                T = 10;
                SECS_T7.InnerText = T.ToString();
                HSMS_Node.AppendChild(SECS_T7);//新增到 SECS 節點中
                XmlElement SECS_T8 = document.CreateElement("T8");
                T = 5;
                SECS_T8.InnerText = T.ToString();
                HSMS_Node.AppendChild(SECS_T8);//新增到 SECS 節點中
                XmlElement SECS_ConnectionMode = document.CreateElement("ConnectionMode");
                SECS_ConnectionMode.InnerText = HSMS_CONNECTION_MODE.PASSIVE.ToString();
                HSMS_Node.AppendChild(SECS_ConnectionMode);//新增到 SECS 節點中
                XmlElement SECS_LocalIPAddress = document.CreateElement("LocalIPAddress");
                SECS_LocalIPAddress.InnerText = "127.0.0.1";
                HSMS_Node.AppendChild(SECS_LocalIPAddress);//新增到 SECS 節點中
                XmlElement SECS_RemoteIPAddress = document.CreateElement("RemoteIPAddress");
                SECS_RemoteIPAddress.InnerText = "127.0.0.1";
                HSMS_Node.AppendChild(SECS_RemoteIPAddress);//新增到 SECS 節點中
                XmlElement SECS_LocalIPPort = document.CreateElement("LocalIPPort");
                uint port = 5100;
                SECS_LocalIPPort.InnerText = port.ToString();
                HSMS_Node.AppendChild(SECS_LocalIPPort);//新增到 SECS 節點中

                XmlElement SECS_RemoteIPPort = document.CreateElement("RemoteIPPort");
                SECS_RemoteIPPort.InnerText = port.ToString();
                HSMS_Node.AppendChild(SECS_RemoteIPPort);//新增到 SECS 節點中

                XmlElement SECS_LinkTestTimer = document.CreateElement("LinkTestTimer");
                long Slt = 60;
                SECS_LinkTestTimer.InnerText = Slt.ToString();
                HSMS_Node.AppendChild(SECS_LinkTestTimer);//新增到 SECS 節點中
                */

                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }
            Parameters_NODE = document.SelectSingleNode("Parameters");
            SECS = new _SECS(document, xmlName);
        }
        /*
        public bool General_AutoDevice
        {
            get 
            {
                XmlElement AutoDevice = (XmlElement)General_Node.SelectSingleNode("AutoDevice");
                return bool.Parse(AutoDevice.InnerText);
            }
            set 
            {
                XmlElement AutoDevice = (XmlElement)General_Node.SelectSingleNode("AutoDevice");
                AutoDevice.InnerText = value.ToString(); 
            }
        }
        public bool General_MonitorEnabled
        {
            get
            {
                XmlElement MonitorEnabled = (XmlElement)General_Node.SelectSingleNode("MonitorEnabled");
                return bool.Parse(MonitorEnabled.InnerText);
            }
            set
            {
                XmlElement MonitorEnabled = (XmlElement)General_Node.SelectSingleNode("MonitorEnabled");
                MonitorEnabled.InnerText = value.ToString();
            }
        }
        public bool General_MultipleOpen
        {
            get
            {
                XmlElement MultipleOpen = (XmlElement)General_Node.SelectSingleNode("MultipleOpen");
                return bool.Parse(MultipleOpen.InnerText);
            }
            set
            {
                XmlElement MultipleOpen = (XmlElement)General_Node.SelectSingleNode("MultipleOpen");
                MultipleOpen.InnerText = value.ToString();
            }
        }
        public SECS_PORT_TYPE General_PortType
        {
            get
            {
                XmlElement PortType = (XmlElement)General_Node.SelectSingleNode("PortType");
                
                return (SECS_PORT_TYPE)Enum.Parse(typeof(SECS_PORT_TYPE), PortType.InnerText);
            }
            set
            {
                XmlElement PortType = (XmlElement)General_Node.SelectSingleNode("PortType");
                PortType.InnerText = value.ToString();
            }
        }
        public long General_DefaultDeviceID
        {
            get
            {
                XmlElement DefaultDeviceID = (XmlElement)General_Node.SelectSingleNode("DefaultDeviceID");

                return long.Parse(DefaultDeviceID.InnerText);
            }
            set
            {
                XmlElement DefaultDeviceID = (XmlElement)General_Node.SelectSingleNode("DefaultDeviceID");
                DefaultDeviceID.InnerText = value.ToString();
            }
        }
        
        public long HSMS_T3
        {
            get
            {
                XmlElement T3 = (XmlElement)HSMS_Node.SelectSingleNode("T3");

                return long.Parse(T3.InnerText);
            }
            set
            {
                XmlElement T3 = (XmlElement)HSMS_Node.SelectSingleNode("T3");
                T3.InnerText = value.ToString();
            }
        }
        public long HSMS_T5
        {
            get
            {
                XmlElement T5 = (XmlElement)HSMS_Node.SelectSingleNode("T5");

                return long.Parse(T5.InnerText);
            }
            set
            {
                XmlElement T5 = (XmlElement)HSMS_Node.SelectSingleNode("T5");
                T5.InnerText = value.ToString();
            }
        }
        public long HSMS_T6
        {
            get
            {
                XmlElement T6 = (XmlElement)HSMS_Node.SelectSingleNode("T6");

                return long.Parse(T6.InnerText);
            }
            set
            {
                XmlElement T6 = (XmlElement)HSMS_Node.SelectSingleNode("T6");
                T6.InnerText = value.ToString();
            }
        }
        public long HSMS_T7
        {
            get
            {
                XmlElement T7 = (XmlElement)HSMS_Node.SelectSingleNode("T7");

                return long.Parse(T7.InnerText);
            }
            set
            {
                XmlElement T7 = (XmlElement)HSMS_Node.SelectSingleNode("T7");
                T7.InnerText = value.ToString();
            }
        }
        public long HSMS_T8
        {
            get
            {
                XmlElement T8 = (XmlElement)HSMS_Node.SelectSingleNode("T8");

                return long.Parse(T8.InnerText);
            }
            set
            {
                XmlElement T8 = (XmlElement)HSMS_Node.SelectSingleNode("T8");
                T8.InnerText = value.ToString();
            }
        }
        public HSMS_CONNECTION_MODE HSMS_ConnectionMode
        {
            get
            {
                XmlElement ConnectionMode = (XmlElement)HSMS_Node.SelectSingleNode("ConnectionMode");

                return (HSMS_CONNECTION_MODE)Enum.Parse(typeof(HSMS_CONNECTION_MODE), ConnectionMode.InnerText);
            }
            set
            {
                XmlElement ConnectionMode = (XmlElement)HSMS_Node.SelectSingleNode("ConnectionMode");
                ConnectionMode.InnerText = value.ToString();
            }
        }
        public string HSMS_LocalIPAddress
        {
            get
            {
                XmlElement LocalIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPAddress");

                return LocalIPAddress.InnerText;
            }
            set
            {
                XmlElement LocalIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPAddress");
                LocalIPAddress.InnerText = value.ToString();
            }
        }
        public string HSMS_RemoteIPAddress
        {
            get
            {
                XmlElement RemoteIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPAddress");

                return RemoteIPAddress.InnerText;
            }
            set
            {
                XmlElement RemoteIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPAddress");
                RemoteIPAddress.InnerText = value.ToString();
            }
        }
        public uint HSMS_LocalIPPort
        {
            get
            {
                XmlElement LocalIPPort = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPPort");

                return uint.Parse(LocalIPPort.InnerText);
            }
            set
            {
                XmlElement LocalIPPort = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPPort");
                LocalIPPort.InnerText = value.ToString();
            }
        }
        public uint HSMS_RemoteIPPort
        {
            get
            {
                XmlElement RemoteIPPort = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPPort");
                return uint.Parse(RemoteIPPort.InnerText);
            }
            set
            {
                XmlElement RemoteIPPort = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPPort");
                RemoteIPPort.InnerText = value.ToString();
            }
        }
        public uint HSMS_LinkTestTimer
        {
            get
            {
                XmlElement LinkTestTimer = (XmlElement)HSMS_Node.SelectSingleNode("LinkTestTimer");
                return uint.Parse(LinkTestTimer.InnerText);
            }
            set
            {
                XmlElement LinkTestTimer = (XmlElement)HSMS_Node.SelectSingleNode("LinkTestTimer");
                LinkTestTimer.InnerText = value.ToString();
            }
        }
        */
        public void Upgrade()
        {
            document.Save(xmlName);
        }
    }
}
