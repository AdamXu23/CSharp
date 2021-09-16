using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;
using Modbus.Device;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Timers;

namespace Modebus_Test
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        bool _serialPort_IsOpen;
        string str;
        Thread t;
        Thread timers;
        public Form1()
        {
            InitializeComponent();
            str = System.Environment.CurrentDirectory;
        }
        private void SerialPort_comboBox_DropDown(object sender, EventArgs e)
        {
            SerialPort_comboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            SerialPort_comboBox.Items.Add("Close");
            foreach (string port in ports)
            {
                SerialPort_comboBox.Items.Add(port);
            }
        }
        private void SerialPort_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SerialPort_comboBox.Text == string.Empty | SerialPort_comboBox.Text == "Close")
            {
                if (_serialPort_IsOpen)
                {
                    _serialPort.Close();
                    _serialPort_IsOpen = false;
                }
            }
            else
            {
                if (_serialPort_IsOpen)
                {
                    _serialPort.Close();
                    _serialPort_IsOpen = false;
                }
                try
                {
                    if (_serialPort_IsOpen == false)
                    {
                        _serialPort = new SerialPort(SerialPort_comboBox.Text);
                        _serialPort.BaudRate = 9600;
                        _serialPort.DataBits = 8;
                        _serialPort.Parity = Parity.Even;
                        _serialPort.StopBits = StopBits.One;
                        _serialPort.Open();
                        t = new Thread(ThreadProc);
                        t.IsBackground = true;
                        timers = new Thread(test);
                        timers.IsBackground = true;
                    }
                }
                catch (InvalidCastException ex)
                {
                    timers.Start();
                    MessageBox.Show("Serial port opening failed");
                }

            }
        }
        void test(object source)
        {
            System.DateTime currentTime1 = System.DateTime.Now;
            String currentTime = currentTime1.Hour.ToString() + "-" + currentTime1.Minute.ToString() + "-" + currentTime1.Second.ToString();
            if (!File.Exists(str + "\\" + currentTime + "RH_V.csv"))
            {
                FileStream fs1 = new FileStream(str + "\\" + currentTime + "RH_V.csv", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine("system time，Serial 1,Serial 2,Serial 3,Serial 4,AVEX1,AVEX2");//开始写入值
                sw.Close();
                fs1.Close();
            }
            System.Threading.Thread.Sleep(1000);
            while (true)
            {
                /*if (!File.Exists(str + "\\" + currentTime + "RH_V.csv"))
                {
                    FileStream fs1 = new FileStream(str + "\\" + currentTime + "RH_V.csv", FileMode.Create, FileAccess.Write);//创建写入文件 
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.WriteLine("system time，Serial 1,Serial 2,Serial 3,Serial 4");//开始写入值
                    sw.Close();
                    fs1.Close();
                }
                else
                {*/
                StreamWriter sr = new StreamWriter(str + "\\" + currentTime + "RH_V.csv", true);
                sr.WriteLine(this.RH1_textBox.Text + "," + this.RH2_textBox.Text + "," + this.RH3_textBox.Text + "," + this.RH4_textBox.Text + "," + this.AVEX_textBox1.Text + "," + this.AVEX_textBox2.Text);//开始写入值
                sr.Close();
                System.Threading.Thread.Sleep(100);
                //}
                
            }
        }
        
        void ChangeTextBox1(ushort[] ModeBUSData)
        {
            RH1_textBox.Text = ModeBUSData[0].ToString();
            RH2_textBox.Text = ModeBUSData[1].ToString();
            RH3_textBox.Text = ModeBUSData[2].ToString();
            RH4_textBox.Text = ModeBUSData[3].ToString();
            AVEX_textBox1.Text = ModeBUSData[4].ToString();
            AVEX_textBox2.Text = ModeBUSData[5].ToString();
        }
        delegate void ChangeTextBoxEventHandler(ushort[] ModeBUSData);
         void ThreadProc(object param)
        {
            ushort[] holding_register;
            ushort[] RH_V = new ushort[7];
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(_serialPort);
            while (true)
            {
                holding_register = master.ReadHoldingRegisters(21, 0x446, 0x01);
                RH_V[0] = holding_register[0];
                System.Threading.Thread.Sleep(150);
                holding_register = master.ReadHoldingRegisters(22, 0x446, 0x01);
                RH_V[1] = holding_register[0];
                System.Threading.Thread.Sleep(150);
                holding_register = master.ReadHoldingRegisters(23, 0x446, 0x01);
                RH_V[2] = holding_register[0];
                System.Threading.Thread.Sleep(150);
                holding_register = master.ReadHoldingRegisters(24, 0x446, 0x01);
                RH_V[3] = holding_register[0];
                System.Threading.Thread.Sleep(150);
                holding_register = master.ReadInputRegisters(25, 0x01, 0x01);
                RH_V[4] = holding_register[0];
                System.Threading.Thread.Sleep(150);
                ///holding_register = master.ReadInputRegisters(26, 0x01, 0x01);
                //RH_V[5] = holding_register[0];
                //System.Threading.Thread.Sleep(150);
                //RH1_textBox.Text = RH_V[0].ToString();
                //RH2_textBox.Text = RH_V[1].ToString();
                //RH3_textBox.Text = RH_V[2].ToString();
                //RH4_textBox.Text = RH_V[3].ToString();
                //AVEX_textBox1.Text = RH_V[4].ToString();
                //AVEX_textBox2.Text = ModeBUSData[5].ToString();
                this.Invoke(new ChangeTextBoxEventHandler(ChangeTextBox1), RH_V);
            }
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            t.Abort();
            timers.Abort();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            t.Start(_serialPort);
            timers.Start();
        }
        private void Stop_button_Click(object sender, EventArgs e)
        {
            t.Abort();
            timers.Abort();
        }
    }
}
