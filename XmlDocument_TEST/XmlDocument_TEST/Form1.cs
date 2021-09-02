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
            AutoDevice_CB.Checked = Parameters.SECS.General.AutoDevice;
            MonitorEnabled_CB.Checked = Parameters.SECS.General.MultipleOpen;
            MultipleOpen_CB.Checked = Parameters.SECS.General.MultipleOpen;
            PortType_CB.SelectedItem = Parameters.SECS.General.PortType;
            DefaultDeviceID_numericUpDown.Value = Parameters.SECS.General.DefaultDeviceID;
        }
        private void HSMS_Load()
        {
            /*
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
            */
            T3_numericUpDown.Value = Parameters.SECS.HSMS.T3;
            T5_numericUpDown.Value = Parameters.SECS.HSMS.T5;
            T6_numericUpDown.Value = Parameters.SECS.HSMS.T6;
            T7_numericUpDown.Value = Parameters.SECS.HSMS.T7;
            T8_numericUpDown.Value = Parameters.SECS.HSMS.T8;
            ConnectionMode_CB.SelectedItem = Parameters.SECS.HSMS.ConnectionMode;
            LocalIPAddress_textBox.Text = Parameters.SECS.HSMS.LocalIPAddress;
            RemoteIPAddress_textBox.Text = Parameters.SECS.HSMS.RemoteIPAddress;
            LocalIPPort_numericUpDown.Value = Parameters.SECS.HSMS.LocalIPPort;
            RemoteIPPort_numericUpDown.Value = Parameters.SECS.HSMS.RemoteIPPort;
            LinkTestTimer_numericUpDown.Value = Parameters.SECS.HSMS.LinkTestTimer;
        }

        private void General_Save()
        {
            Parameters.SECS.General.AutoDevice= AutoDevice_CB.Checked;
            Parameters.SECS.General.MonitorEnabled = MonitorEnabled_CB.Checked;
            Parameters.SECS.General.MultipleOpen = MultipleOpen_CB.Checked;
            Parameters.SECS.General.PortType = (SECS_PORT_TYPE)Enum.Parse(typeof(SECS_PORT_TYPE), PortType_CB.Text); 
            Parameters.SECS.General.DefaultDeviceID  = Convert.ToInt64(DefaultDeviceID_numericUpDown.Value);
        }

        private void HSMS_Save()
        {
            /*
            Parameters.HSMS_T3 = Convert.ToInt64(T3_numericUpDown.Value);
            Parameters.HSMS_T5 = Convert.ToInt64(T5_numericUpDown.Value);
            Parameters.HSMS_T6 = Convert.ToInt64(T6_numericUpDown.Value);
            Parameters.HSMS_T7 = Convert.ToInt64(T7_numericUpDown.Value);
            Parameters.HSMS_T8 = Convert.ToInt64(T8_numericUpDown.Value);
            Parameters.HSMS_ConnectionMode = (HSMS_CONNECTION_MODE)Enum.Parse(typeof(HSMS_CONNECTION_MODE), ConnectionMode_CB.Text);
            Parameters.HSMS_LocalIPAddress = LocalIPAddress_textBox.Text;
            Parameters.HSMS_RemoteIPAddress = RemoteIPAddress_textBox.Text;
            Parameters.HSMS_LocalIPPort = Convert.ToUInt32(LocalIPPort_numericUpDown.Value);
            Parameters.HSMS_RemoteIPPort = Convert.ToUInt32(RemoteIPPort_numericUpDown.Value);
            Parameters.HSMS_LinkTestTimer = Convert.ToUInt32(LinkTestTimer_numericUpDown.Value);
            */
            Parameters.SECS.HSMS.T3 = Convert.ToInt64(T3_numericUpDown.Value);
            Parameters.SECS.HSMS.T5 = Convert.ToInt64(T5_numericUpDown.Value);
            Parameters.SECS.HSMS.T6 = Convert.ToInt64(T6_numericUpDown.Value);
            Parameters.SECS.HSMS.T7 = Convert.ToInt64(T7_numericUpDown.Value);
            Parameters.SECS.HSMS.T8 = Convert.ToInt64(T8_numericUpDown.Value);
            Parameters.SECS.HSMS.ConnectionMode = (HSMS_CONNECTION_MODE)Enum.Parse(typeof(HSMS_CONNECTION_MODE), ConnectionMode_CB.Text);
            Parameters.SECS.HSMS.LocalIPAddress = LocalIPAddress_textBox.Text;
            Parameters.SECS.HSMS.RemoteIPAddress = RemoteIPAddress_textBox.Text;
            Parameters.SECS.HSMS.LocalIPPort = Convert.ToUInt32(LocalIPPort_numericUpDown.Value);
            Parameters.SECS.HSMS.RemoteIPPort = Convert.ToUInt32(RemoteIPPort_numericUpDown.Value);
            Parameters.SECS.HSMS.LinkTestTimer = Convert.ToUInt32(LinkTestTimer_numericUpDown.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General_Save();
            HSMS_Save();
            Parameters.Upgrade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General_Load();
            HSMS_Load();
        }
    }
}
