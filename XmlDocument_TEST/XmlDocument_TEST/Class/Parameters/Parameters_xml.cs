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
        private XmlNode System_NODE;
        private XmlDeclaration declaration;
        public _SECS SECS;
        public Parameters_xml(string _xmlName)
        {
            document = new XmlDocument();
            xmlName = _xmlName;
            try
            {
                document.Load(xmlName);
            }
            catch
            {
                declaration = document.FirstChild as XmlDeclaration;
                if (declaration == null)
                {

                    declaration = document.CreateXmlDeclaration("1.0", "UTF-8", "");//xml文件的宣告部分
                    document.AppendChild(declaration);
                }
                else
                {
                    declaration.Encoding = "UTF-8";
                }
                System_NODE = document.SelectSingleNode("System");
                if (System_NODE == null)
                {
                    System_NODE = document.CreateElement("System");
                    document.AppendChild(System_NODE);
                }
                document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
            }
            System_NODE = document.SelectSingleNode("System");
            SECS = new _SECS(document, xmlName);
        }

        public string EQ_MDLN
        {
            get
            {
                XmlElement _EQ_MDLN = (XmlElement)System_NODE.SelectSingleNode("EQ_MDLN");
                if (_EQ_MDLN == null)
                {
                    _EQ_MDLN = document.CreateElement("EQ_MDLN");
                    _EQ_MDLN.InnerText = "Please modify EQ_MDLN";
                    System_NODE.AppendChild(_EQ_MDLN);//新增到 SECS 節點中
                    document.Save(xmlName);//將生成好的xml儲存到test.xml檔案中
                }
                return _EQ_MDLN.InnerText;
            }
            set
            {
                XmlElement _EQ_MDLN = (XmlElement)System_NODE.SelectSingleNode("EQ_MDLN");
                _EQ_MDLN.InnerText = value;
            }
        }

        public void Upgrade()
        {
            document.Save(xmlName);
        }
    }
}
