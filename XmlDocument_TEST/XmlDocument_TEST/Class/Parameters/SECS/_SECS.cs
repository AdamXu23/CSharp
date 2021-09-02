using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XmlDocument_TEST
{
    class _SECS
    {
        private string xmlName = "Parameters.xml";
        private XmlDocument document = new XmlDocument();
        private XmlNode System_NODE;
        private XmlNode SECS_Node;
        public _HSMS HSMS;
        public _General General;
        public _SECS(XmlDocument _XmlDocument, string _xmlName)
        {
            document = _XmlDocument;
            System_NODE = document.SelectSingleNode("System");
            SECS_Node = System_NODE.SelectSingleNode("SECS");
            if (SECS_Node == null)
            {

                SECS_Node = document.CreateElement("SECS");
                System_NODE.AppendChild(SECS_Node);//新增到 Parameters 節點中
                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }
            HSMS = new _HSMS(document, xmlName);
            General = new _General(document, xmlName);
        }
    }
}
