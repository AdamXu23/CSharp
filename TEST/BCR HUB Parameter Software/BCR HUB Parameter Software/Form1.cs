using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace BCR_HUB_Parameter_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///多线程编程中，如果子线程需要使用主线程中创建的对象和控件，最好在主线程中体现进行检查取消
            CheckForIllegalCrossThreadCalls = false;
        }
        bool Connected;
        SerialPort SerialPort_interface;
        string DataReceived_String;
        string PortHex;

        private void Form1_Shown(Object sender, EventArgs e)
        {
            Serial_port_Refresh();
        }
        private void Open_button_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort_interface = new SerialPort(Serial_port_comboBox.Text);
                try
                {
                    SerialPort_interface.BaudRate = Convert.ToInt32(BaudRate_TextBox.Text);
                    int Item = Parity_ComboBox.SelectedIndex;
                    switch (Item)
                    {
                        case 0:
                            SerialPort_interface.Parity = Parity.Even;
                            break;
                        case 1:
                            SerialPort_interface.Parity = Parity.None;
                            break;
                        case 3:
                            SerialPort_interface.Parity = Parity.Odd;
                            break;
                        default:
                            MessageBox.Show("Parity Empty");
                            break;
                    }
                    Item = StopBits_ComboBox.SelectedIndex;
                    switch (Item)
                    {
                        case 0:
                            SerialPort_interface.StopBits = StopBits.One;
                            break;
                        case 1:
                            SerialPort_interface.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("StopBits Empty");
                            break;
                    }
                    SerialPort_interface.DataBits = Convert.ToInt32(DataBits_TextBox.Text);
                    SerialPort_interface.Handshake = Handshake.None;

                    SerialPort_interface.Open();
                    SerialPort_interface.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                    MessageBox.Show(SerialPort_interface.PortName + " Open");
                }
                catch (Exception)
                {
                    MessageBox.Show("Serial port open failed");
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("Please select the serial port");
            }

        }
        //订阅委托
        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //接收数据
            System.Threading.Thread.Sleep(100);
            DataReceived_String = "";
            do
            {
                int count = SerialPort_interface.BytesToRead;
                if (count <= 0)
                    break;
                byte[] readBuffer = new byte[count];

                Application.DoEvents();
                SerialPort_interface.Read(readBuffer, 0, count);
                DataReceived_String += System.Text.Encoding.Default.GetString(readBuffer);

            } while (SerialPort_interface.BytesToRead > 0);
            Log_listBox.Items.Add(DateTime.Now + "[Rcv]: " + DataReceived_String);
            if (DataReceived_String.IndexOf("FFF-") > 0)
            {
                string Data_String;
                Data_String = DataReceived_String.Substring(35,4);
                label29.Text = Data_String;
                Data_String = DataReceived_String.Substring(31, 4);
                label26.Text = Data_String;
                Data_String = DataReceived_String.Substring(27, 4);
                label23.Text = Data_String;
                Data_String = DataReceived_String.Substring(23, 4);
                label20.Text = Data_String;
                Data_String = DataReceived_String.Substring(19, 4);
                label17.Text = Data_String;
                Data_String = DataReceived_String.Substring(15, 4);
                label14.Text = Data_String;
                Data_String = DataReceived_String.Substring(11, 4);
                label11.Text = Data_String;
                Data_String = DataReceived_String.Substring(7, 4);
                Current_Retry_Settings.Text = Data_String;
            }
            Log_listBox.SelectedIndex = Log_listBox.Items.Count - 1;
        }
        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Serial_port_Refresh();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            SerialPort_interface.Close();
            MessageBox.Show(SerialPort_interface.PortName + " Close");
        }
        void Serial_port_Refresh()
        {
            Serial_port_comboBox.Items.Clear();
            //获取单片机与计算机连接的端口号
            //获取本机串口名称，存入PortNames数组中
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }

            //添加串口项目
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {//获取有多少个COM口
                Serial_port_comboBox.Items.Add(s);
            }

            //串口设置默认选择项
            Serial_port_comboBox.SelectedIndex = 0;
        }

        private void BCR_ON_Click(object sender, EventArgs e)
        {
            Port_NUM();
            SendMsg("%T"+ PortHex + "-LON\r");
        }

        private void BCR_OFF_Click(object sender, EventArgs e)
        {
            Port_NUM();
            SendMsg("%T" + PortHex + "-LOFF\r");
        }
        void SendMsg( string str)
        {
            try
            {
                SerialPort_interface.Write(str);
                Log_listBox.Items.Add(DateTime.Now + "[Snd]: " + str);
                Log_listBox.SelectedIndex = Log_listBox.Items.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Please open the serial port");
            }
        }
        void Port_NUM()
        {

            int result;
            try
            {
                result = Convert.ToInt32(BCR_TextBox.Text);
            }
            catch (Exception)
            {
                result = 0;
                BCR_TextBox.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                BCR_TextBox.Text = "255";
            }
            if (result < 16)
            {
                PortHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                PortHex = Convert.ToString(result, 16);
            }
            PortHex = PortHex.ToUpper();
            label8.Text = PortHex;
        }

        private void Data_Refresh_Click(object sender, EventArgs e)
        {
            SendMsg("%F00-0008\r");
        }

        private void NG_Reset(object sender, EventArgs e)
        {
            Port_NUM();
            SendMsg("%F09-00" + PortHex + "\r");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;
            string DataHex;
            try
            {
                result = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                result = 0;
                textBox1.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                textBox1.Text = "255";
            }
            if (result < 16)
            {
                DataHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                DataHex = Convert.ToString(result, 16);
            }
            DataHex = DataHex.ToUpper();
            SendMsg("%F01-00" + DataHex + "\r");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result;
            string DataHex;
            try
            {
                result = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                result = 0;
                textBox2.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                textBox2.Text = "255";
            }
            if (result < 16)
            {
                DataHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                DataHex = Convert.ToString(result, 16);
            }
            DataHex = DataHex.ToUpper();
            SendMsg("%F02-00" + DataHex + "\r");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SendMsg("%F03-0001\r");
            }
            else
            {
                SendMsg("%F03-0000\r");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int result;
            string DataHex;
            try
            {
                result = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception)
            {
                result = 0;
                textBox4.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                textBox4.Text = "255";
            }
            if (result < 16)
            {
                DataHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                DataHex = Convert.ToString(result, 16);
            }
            DataHex = DataHex.ToUpper();
            SendMsg("%F04-00" + DataHex + "\r");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendMsg("%F05-0001\r");
            }
            else
            {
                SendMsg("%F05-0000\r");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int result;
            string DataHex;
            try
            {
                result = Convert.ToInt32(textBox6.Text);
            }
            catch (Exception)
            {
                result = 0;
                textBox6.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                textBox6.Text = "255";
            }
            if (result < 16)
            {
                DataHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                DataHex = Convert.ToString(result, 16);
            }
            DataHex = DataHex.ToUpper();
            SendMsg("%F06-00" + DataHex + "\r");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result;
            string DataHex;
            try
            {
                result = Convert.ToInt32(textBox7.Text);
            }
            catch (Exception)
            {
                result = 0;
                textBox7.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                textBox7.Text = "255";
            }
            if (result < 16)
            {
                DataHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                DataHex = Convert.ToString(result, 16);
            }
            DataHex = DataHex.ToUpper();
            SendMsg("%F07-00" + DataHex + "\r");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int result;
            string DataHex;
            try
            {
                result = Convert.ToInt32(textBox8.Text);
            }
            catch (Exception)
            {
                result = 0;
                textBox8.Text = "0";
            }
            if (result > 255)
            {
                result = 255;
                textBox8.Text = "255";
            }
            if (result < 16)
            {
                DataHex = "0" + Convert.ToString(result, 16);
            }
            else
            {
                DataHex = Convert.ToString(result, 16);
            }
            DataHex = DataHex.ToUpper();
            SendMsg("%F08-00" + DataHex + "\r");

        }

        private void Serial_port_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}