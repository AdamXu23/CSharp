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
        Parameters_xml Parameters;
        public Form1()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(SECS_PORT_TYPE)))
            {
                PortType_CB.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(HSMS_CONNECTION_MODE)))
            {
                ConnectionMode_CB.Items.Add(item);
            }
            Parameters = new Parameters_xml("Parameters.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            General_Load();
            HSMS_Load();
        }

        private void General_Load()
        {
            AutoDevice_CB.Checked = Parameters.General_AutoDevice;

            MonitorEnabled_CB.Checked = Parameters.General_MultipleOpen;

            MultipleOpen_CB.Checked = Parameters.General_MultipleOpen;
            
            PortType_CB.SelectedItem = Parameters.General_PortType;

            DefaultDeviceID_numericUpDown.Value = Parameters.General_DefaultDeviceID;
        }
        private void HSMS_Load()
        {
            T3_numericUpDown.Value = Parameters.HSMS_T3;

            T5_numericUpDown.Value = Parameters.HSMS_T5;

            T6_numericUpDown.Value = Parameters.HSMS_T6;

            T7_numericUpDown.Value = Parameters.HSMS_T7;

            T8_numericUpDown.Value = Parameters.HSMS_T8;

            ConnectionMode_CB.SelectedItem = Parameters.HSMS_ConnectionMode;

            LocalIPAddress_textBox.Text = Parameters.HSMS_LocalIPAddress;

            RemoteIPAddress_textBox.Text = Parameters.HSMS_RemoteIPAddress;

            LocalIPPort_numericUpDown.Value = Parameters.HSMS_LocalIPPort;

            RemoteIPPort_numericUpDown.Value = Parameters.HSMS_RemoteIPPort;

            LinkTestTimer_numericUpDown.Value = Parameters.HSMS_LinkTestTimer;

        }
    }
}
