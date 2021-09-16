using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace GET_MAC_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in interfaces)
                {
                    richTextBox1.Text = richTextBox1.Text + interfaces[i].Name + '\n';
                    richTextBox1.Text = richTextBox1.Text +  BitConverter.ToString(ni.GetPhysicalAddress().GetAddressBytes()) + '\n';
                    i++;
                }
            }
            catch (Exception)
            {
                richTextBox1.Text = richTextBox1.Text + "00-00-00-00-00-00\n";
            }
        }
    }
}
