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

namespace XmlDocument_TEST
{
    public partial class Form1 : Form
    {
        Parameters_xml Parameters;
        public Form1()
        {
            InitializeComponent();
            Parameters = new Parameters_xml("Parameters.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            General_Load();
            HSMS_Load();
        }

        private void General_Load()
        {
            XmlNode Parameters = document.SelectSingleNode("Parameters");
            XmlNode SECS = Parameters.SelectSingleNode("SECS");
            XmlNode General = SECS.SelectSingleNode("General");

            XmlElement AutoDevice = (XmlElement)General.SelectSingleNode("AutoDevice");
            AutoDevice_CB.Checked = bool.Parse(AutoDevice.InnerText);

            XmlElement MonitorEnabled = (XmlElement)General.SelectSingleNode("MonitorEnabled");
            MonitorEnabled_CB.Checked = bool.Parse(MonitorEnabled.InnerText);

            XmlElement MultipleOpen = (XmlElement)General.SelectSingleNode("MultipleOpen");
            MultipleOpen_CB.Checked = bool.Parse(MultipleOpen.InnerText);

            PortType_CB.Items.Add(SECS_PORT_TYPE.HSMS);
            PortType_CB.Items.Add(SECS_PORT_TYPE.SECS1_SERIAL);
            PortType_CB.Items.Add(SECS_PORT_TYPE.SECS1_TCPIP);
            PortType_CB.Items.Add(SECS_PORT_TYPE.SECS1_TELNET);
            XmlElement PortType = (XmlElement)General.SelectSingleNode("PortType");
            PortType_CB.SelectedItem = (SECS_PORT_TYPE)Enum.Parse(typeof(SECS_PORT_TYPE), PortType.InnerText);

            XmlElement DefaultDeviceID = (XmlElement)General.SelectSingleNode("DefaultDeviceID");
            DefaultDeviceID_numericUpDown.Value = long.Parse(DefaultDeviceID.InnerText);
        }
        private void HSMS_Load()
        {
            XmlNode Parameters = document.SelectSingleNode("Parameters");
            XmlNode SECS = Parameters.SelectSingleNode("SECS");
            XmlNode HSMS = SECS.SelectSingleNode("HSMS");

            XmlElement T3 = (XmlElement)HSMS.SelectSingleNode("T3");
            T3_numericUpDown.Value = long.Parse(T3.InnerText);

            XmlElement T5 = (XmlElement)HSMS.SelectSingleNode("T5");
            T5_numericUpDown.Value = long.Parse(T5.InnerText);

            XmlElement T6 = (XmlElement)HSMS.SelectSingleNode("T6");
            T6_numericUpDown.Value = long.Parse(T6.InnerText);

            XmlElement T7 = (XmlElement)HSMS.SelectSingleNode("T7");
            T7_numericUpDown.Value = long.Parse(T7.InnerText);

            XmlElement T8 = (XmlElement)HSMS.SelectSingleNode("T8");
            T8_numericUpDown.Value = long.Parse(T8.InnerText);

            ConnectionMode_CB.Items.Add(HSMS_CONNECTION_MODE.ACTIVE);
            ConnectionMode_CB.Items.Add(HSMS_CONNECTION_MODE.PASSIVE);
            ConnectionMode_CB.Items.Add(HSMS_CONNECTION_MODE.ALTERNATING);
            XmlElement ConnectionMode = (XmlElement)HSMS.SelectSingleNode("ConnectionMode");
            ConnectionMode_CB.SelectedItem = (HSMS_CONNECTION_MODE)Enum.Parse(typeof(HSMS_CONNECTION_MODE), ConnectionMode.InnerText);

            XmlElement LocalIPAddress = (XmlElement)HSMS.SelectSingleNode("LocalIPAddress");
            LocalIPAddress_textBox.Text = LocalIPAddress.InnerText;

            XmlElement RemoteIPAddress = (XmlElement)HSMS.SelectSingleNode("RemoteIPAddress");
            RemoteIPAddress_textBox.Text = RemoteIPAddress.InnerText;

            XmlElement LocalIPPort = (XmlElement)HSMS.SelectSingleNode("LocalIPPort");
            LocalIPPort_numericUpDown.Value = uint.Parse(LocalIPPort.InnerText);

            XmlElement RemoteIPPort = (XmlElement)HSMS.SelectSingleNode("RemoteIPPort");
            RemoteIPPort_numericUpDown.Value = uint.Parse(RemoteIPPort.InnerText);

            XmlElement LinkTestTimer = (XmlElement)HSMS.SelectSingleNode("LinkTestTimer");
            LinkTestTimer_numericUpDown.Value = uint.Parse(LinkTestTimer.InnerText);

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
