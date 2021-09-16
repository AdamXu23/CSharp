using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nModebus;
using NModbus;

namespace nModebus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 初始化一個新的SerialPort物件
            System.IO.Ports.SerialPort serialPort = new System.IO.Ports.SerialPort();
            // 2. 設定com port的設定值後開啟com port
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.Parity = System.IO.Ports.Parity.None;
            serialPort.StopBits = System.IO.Ports.StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Open();
            // 3. 建立一個新的Modbus RTU Master的物件
            Modbus.Device.ModbusSerialMaster master;
            master = Modbus.Device.ModbusSerialMaster.CreateRtu(serialPort);
            master.Transport.ReadTimeout = 300;
            // 4. 應用ReadInputRegisters函式讀取Modbus Slave裝置站號是1的Input Register資料
            ushort[] register = master.ReadInputRegisters(1, 0, 1);
            MessageBox.Show("Read Input Register 30001 = " + register[0].ToString());

        }
    }
}
