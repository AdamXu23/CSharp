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
    class _HSMS
    {
        private string xmlName = "Parameters.xml";
        private XmlDocument document = new XmlDocument();
        private XmlNode Parameters_NODE;
        private XmlNode SECS_Node;
        private XmlNode HSMS_Node;
        public _HSMS(XmlDocument _XmlDocument , string _xmlName)
        {
            document = _XmlDocument;
            Parameters_NODE = document.SelectSingleNode("Parameters");
            SECS_Node = Parameters_NODE.SelectSingleNode("SECS");
            HSMS_Node = SECS_Node.SelectSingleNode("HSMS");
            if (HSMS_Node == null)
            {
                HSMS_Node = document.CreateElement("HSMS");
                SECS_Node.AppendChild(HSMS_Node);//新增到 SECS 節點中


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

                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }
        }
        public long T3
        {
            get
            {
                XmlElement HSMS_T3 = (XmlElement)HSMS_Node.SelectSingleNode("T3");

                return long.Parse(HSMS_T3.InnerText);
            }
            set
            {
                XmlElement HSMS_T3 = (XmlElement)HSMS_Node.SelectSingleNode("T3");
                HSMS_T3.InnerText = value.ToString();
            }
        }
        public long T5
        {
            get
            {
                XmlElement HSMS_T5 = (XmlElement)HSMS_Node.SelectSingleNode("T5");

                return long.Parse(HSMS_T5.InnerText);
            }
            set
            {
                XmlElement HSMS_T5 = (XmlElement)HSMS_Node.SelectSingleNode("T5");
                HSMS_T5.InnerText = value.ToString();
            }
        }
        public long T6
        {
            get
            {
                XmlElement HSMS_T6 = (XmlElement)HSMS_Node.SelectSingleNode("T6");

                return long.Parse(HSMS_T6.InnerText);
            }
            set
            {
                XmlElement HSMS_T6 = (XmlElement)HSMS_Node.SelectSingleNode("T6");
                HSMS_T6.InnerText = value.ToString();
            }
        }
        public long T7
        {
            get
            {
                XmlElement HSMS_T7 = (XmlElement)HSMS_Node.SelectSingleNode("T7");

                return long.Parse(HSMS_T7.InnerText);
            }
            set
            {
                XmlElement HSMS_T7 = (XmlElement)HSMS_Node.SelectSingleNode("T7");
                HSMS_T7.InnerText = value.ToString();
            }
        }
        public long T8
        {
            get
            {
                XmlElement HSMS_T7 = (XmlElement)HSMS_Node.SelectSingleNode("T8");

                return long.Parse(HSMS_T7.InnerText);
            }
            set
            {
                XmlElement HSMS_T7 = (XmlElement)HSMS_Node.SelectSingleNode("T8");
                HSMS_T7.InnerText = value.ToString();
            }
        }
        public HSMS_CONNECTION_MODE ConnectionMode
        {
            get
            {
                XmlElement HSMS_ConnectionMode = (XmlElement)HSMS_Node.SelectSingleNode("ConnectionMode");

                return (HSMS_CONNECTION_MODE)Enum.Parse(typeof(HSMS_CONNECTION_MODE), HSMS_ConnectionMode.InnerText);
            }
            set
            {
                XmlElement HSMS_ConnectionMode = (XmlElement)HSMS_Node.SelectSingleNode("ConnectionMode");
                HSMS_ConnectionMode.InnerText = value.ToString();
            }
        }
        public string LocalIPAddress
        {
            get
            {
                XmlElement HSMS_LocalIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPAddress");

                return HSMS_LocalIPAddress.InnerText;
            }
            set
            {
                XmlElement HSMS_LocalIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPAddress");
                HSMS_LocalIPAddress.InnerText = value.ToString();
            }
        }
        public string RemoteIPAddress
        {
            get
            {
                XmlElement HSMS_RemoteIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPAddress");

                return HSMS_RemoteIPAddress.InnerText;
            }
            set
            {
                XmlElement HSMS_RemoteIPAddress = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPAddress");
                HSMS_RemoteIPAddress.InnerText = value.ToString();
            }
        }
        public uint LocalIPPort
        {
            get
            {
                XmlElement HSMS_LocalIPPort = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPPort");

                return uint.Parse(HSMS_LocalIPPort.InnerText);
            }
            set
            {
                XmlElement HSMS_LocalIPPort = (XmlElement)HSMS_Node.SelectSingleNode("LocalIPPort");
                HSMS_LocalIPPort.InnerText = value.ToString();
            }
        }
        public uint RemoteIPPort
        {
            get
            {
                XmlElement HSMS_RemoteIPPort = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPPort");
                return uint.Parse(HSMS_RemoteIPPort.InnerText);
            }
            set
            {
                XmlElement HSMS_RemoteIPPort = (XmlElement)HSMS_Node.SelectSingleNode("RemoteIPPort");
                HSMS_RemoteIPPort.InnerText = value.ToString();
            }
        }
        public uint LinkTestTimer
        {
            get
            {
                XmlElement HSMS_LinkTestTimer = (XmlElement)HSMS_Node.SelectSingleNode("LinkTestTimer");
                return uint.Parse(HSMS_LinkTestTimer.InnerText);
            }
            set
            {
                XmlElement HSMS_LinkTestTimer = (XmlElement)HSMS_Node.SelectSingleNode("LinkTestTimer");
                HSMS_LinkTestTimer.InnerText = value.ToString();
            }
        }


    }
}
