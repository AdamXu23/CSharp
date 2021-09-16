using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Modbus;
using Modbus.Device;
using System.IO.Ports;

namespace nModebus_Test
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        ModbusSerialMaster master;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            master = ModbusSerialMaster.CreateRtu(serialPort);
            master.Transport.ReadTimeout = 300;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ushort[] register = master.ReadInputRegisters(1, 0, 1);
            MessageBox.Show("Read Input Register 30001 = " + register[0].ToString());
        }
    }
}
