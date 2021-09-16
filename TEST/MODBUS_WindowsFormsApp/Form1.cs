using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace MODBUS_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        System.Timers.Timer Polling_Timer = new System.Timers.Timer();
        static bool Scan;
        static int Scan_Item;
        static SerialPort _serialPort = new SerialPort();
        Modbus.Device.ModbusSerialMaster master;
        public Form1()
        {
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            Polling_Timer.Interval = 1000;
            Polling_Timer.Enabled = true;
            Polling_Timer.Elapsed += TimersTimer_Elapsed;
            Polling_Timer.Start();
            button1.Text = "Scan start";
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Scan Stop";
            Scan_Item = 0;
            Scan = true;
        }
        private void TimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Scan)
            {
                switch (Scan_Item)
                {
                    case 0:
                        _serialPort.Close();
                        _serialPort.Parity = Parity.None;
                        _serialPort.Open();
                        
                        master = Modbus.Device.ModbusSerialMaster.CreateRtu(_serialPort);
                        master.Transport.ReadTimeout = 300;
                        // 4. 應用ReadInputRegisters函式讀取Modbus Slave裝置站號是1的Input Register資料
                        ushort[] register = master.ReadInputRegisters(255, 6, 1);
                        if (register[0] != 0)
                        {
                            MessageBox.Show("Read Input Register 30007 = " + register[0].ToString());
                            Scan = false;
                        }
                    break;
                    case 1:
                        _serialPort.Close();
                        _serialPort.Parity = Parity.Even;
                        _serialPort.Open();
                        master = Modbus.Device.ModbusSerialMaster.CreateRtu(_serialPort);
                        master.Transport.ReadTimeout = 300;
                        // 4. 應用ReadInputRegisters函式讀取Modbus Slave裝置站號是1的Input Register資料
                        ushort[] register = master.ReadInputRegisters(255, 6, 1);
                        if (register[0] != 0)
                        {
                            MessageBox.Show("Read Input Register 30007 = " + register[0].ToString());
                            Scan = false;
                        }
                        break;
                }
            }
         
        }
    }
}
