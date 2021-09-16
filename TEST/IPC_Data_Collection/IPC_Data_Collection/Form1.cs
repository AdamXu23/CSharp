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

namespace IPC_Data_Collection
{
    public partial class Form1 : Form
    {
        
        static SerialPort _serialPort;
        bool _serialPort_IsOpen;
        string DataReceived_String;
        string str;
        delegate void Display(string buffer);


        public Form1()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
            str = System.Environment.CurrentDirectory;
            IniManager iniManager = new IniManager(str + "\\Shipping_Date.ini");
            Shipping_Date.Text= iniManager.ReadIniFile("Shipping_Date", "Shipping_Date", "default");


        }
        public class IniManager
        {
            private string filePath;
            private StringBuilder lpReturnedString;
            private int bufferSize;

            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string lpString, string lpFileName);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

            public IniManager(string iniPath)
            {
                filePath = iniPath;
                bufferSize = 512;
                lpReturnedString = new StringBuilder(bufferSize);
            }

            // read ini date depend on section and key
            public string ReadIniFile(string section, string key, string defaultValue)
            {
                //lpReturnedString ;
                GetPrivateProfileString(section, key, defaultValue, lpReturnedString, bufferSize, filePath);
                return lpReturnedString.ToString();
            }

            // write ini data depend on section and key
            public void WriteIniFile(string section, string key, Object value)
            {
                WritePrivateProfileString(section, key, value.ToString(), filePath);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            IniManager iniManager = new IniManager(str+ "\\Shipping_Date.ini");

            iniManager.WriteIniFile("Shipping_Date", "Shipping_Date", Shipping_Date.Text);

            
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
            if (SerialPort_comboBox.Text == string.Empty | SerialPort_comboBox.Text == "Close" )
            {
                if(_serialPort_IsOpen)
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
                        //_serialPort.PortName = SerialPort_comboBox.Text;
                        _serialPort.BaudRate = 9600;
                        _serialPort.DataBits = 7;
                        _serialPort.Parity = Parity.Even;
                        _serialPort.StopBits = StopBits.One;
                        _serialPort.Open();
                        _serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                        _serialPort_IsOpen = true;
                    }
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Serial port opening failed");
                }

            }
        }
        private void Machine_number_textBox_Click(object sender, EventArgs e)
        {
            //Machine_number_textBox.Text = "123";
            SendMsg(_serialPort_IsOpen, "LON\r");
        }
        void SendMsg( bool port_Open, string str)
        {
            try
            {
                if(port_Open)
                {
                    _serialPort.Write(str);
                }
                else
                {
                    //MessageBox.Show("Please open the serial port");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please open the serial port");
            }
        }
        public void Machine_number_textBox_Show(string buffer)
        {
            Machine_number_textBox.Text = buffer;
        }
        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //接收数据
            System.Threading.Thread.Sleep(100);
            DataReceived_String = "";
            do
            {
                int count = _serialPort.BytesToRead;
                if (count <= 0)
                    break;
                byte[] readBuffer = new byte[count];

                Application.DoEvents();
                _serialPort.Read(readBuffer, 0, count);
                DataReceived_String += System.Text.Encoding.Default.GetString(readBuffer);

            } while (_serialPort.BytesToRead > 0);
            string buffer = DataReceived_String.Substring(0, DataReceived_String.Length - 1);
            Display d = new Display(Machine_number_textBox_Show);
            this.Invoke(d, new Object[] { buffer });
            //Machine_number_textBox.Text = DataReceived_String.Substring(0, DataReceived_String.Length - 1);

        }
        void Save_Data( string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void Save_SN_Click(object sender, EventArgs e)
        {
            string savepath = str + "\\PTLP防毒&MAC截圖（" + Shipping_Date.Text + "出貨）\\" + '\\' + Machine_number_textBox.Text + '\\';
            Save_Data(savepath);
            string MAC_FileName = @"D:\MAC.PNG";
            string MAC_Data_FileName = Machine_number_textBox.Text + "_TLP_MAC.PNG";
            string Capture_FileName = @"D:\Capture.PNG";
            string Capture_Data_FileName = Machine_number_textBox.Text + "_TLP_ScanReport.PNG";
            string D_FileName = "D:\\";
            if (File.Exists(MAC_FileName))
            {
                File.Move(MAC_FileName, D_FileName + MAC_Data_FileName);
                File.Copy(D_FileName + MAC_Data_FileName, savepath + MAC_Data_FileName);
            }
            if (File.Exists(Capture_FileName))
            {
                File.Move(Capture_FileName, D_FileName + Capture_Data_FileName);
                File.Copy(D_FileName + Capture_Data_FileName, savepath + Capture_Data_FileName);
            }
            

        }
    }
}
