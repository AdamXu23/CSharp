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
        private XmlNode HSMS_Node;
        private XmlDocument document = new XmlDocument();
        public _HSMS(XmlDocument _XmlDocument, XmlNode _XmlNode)
        {
            document = _XmlDocument;
            HSMS_Node = _XmlNode;
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
