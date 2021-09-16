using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace TCP_client_socket_Test
{
    public partial class Form1 : Form
    {
        TcpClient _client;
        NetworkStream _stream;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立 TcpClient連線  
                Int32 port = Int32.Parse(Server_Port.Text);
                String IP =  Server_IP.Text;
                _client = new TcpClient(IP , port);
                MessageBox.Show("伺服端連線");
            }
            catch (ArgumentNullException A)
            {
                MessageBox.Show("伺服端未連線");
            }
            catch (SocketException S)
            {
                MessageBox.Show("伺服端未連線");
            }
        }

        private void Send_1_Click(object sender, EventArgs e)
        {
            Byte[] Char = Encoding.UTF8.GetBytes("EC_ErrorRest\r\n");
            try
            {
                _stream = _client.GetStream(); 
                _stream.Write(Char, 0, Char.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("未連線");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte[] Char = Encoding.UTF8.GetBytes("Server_Enable\r\n");
            try
            {
                _stream = _client.GetStream();
                _stream.Write(Char, 0, Char.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("未連線");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] Char = Encoding.UTF8.GetBytes("Server_Disable\r\n");
            try
            {
                _stream = _client.GetStream();
                _stream.Write(Char, 0, Char.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("未連線");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Byte[] Char = Encoding.UTF8.GetBytes("MC_Reverse\r\n");
            try
            {
                _stream = _client.GetStream();
                _stream.Write(Char, 0, Char.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("未連線");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Byte[] Char = Encoding.UTF8.GetBytes("MC_Axis000_Jog\r\n");
            try
            {
                _stream = _client.GetStream();
                _stream.Write(Char, 0, Char.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("未連線");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Byte[] Char = Encoding.UTF8.GetBytes("MC_Axis001_Jog\r\n");
            try
            {
                _stream = _client.GetStream();
                _stream.Write(Char, 0, Char.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("未連線");
            }
        }
    }
}
