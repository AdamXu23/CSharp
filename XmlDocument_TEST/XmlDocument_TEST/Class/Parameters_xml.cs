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

                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }
            Parameters_NODE = document.SelectSingleNode("Parameters");
            SECS = new _SECS(document, xmlName);
        }
        public void Upgrade()
        {
            document.Save(xmlName);
        }
    }
}
