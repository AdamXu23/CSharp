using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading;
//using System.Threading.Tasks;

namespace TCP_Socket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            CheckForIllegalCrossThreadCalls = false;
            CheckForIllegalCrossThreadCalls = false;
            CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 创建客户端
        /// </summary>
        Socket client;
        private void Connection_Click(object sender, EventArgs e)
        {
            ///创建客户端
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            ///IP地址
            IPAddress ip = IPAddress.Parse(IPAddress_TEXT.Text);
            ///端口号
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(IPPort_TEXT.Text));
            ///建立与服务器的远程连接
            try
            {
                client.Connect(endPoint);
                ///线程问题
                Thread thread = new Thread(ReciveMsg);
                thread.IsBackground = true;
                thread.Start(client);
            }
            catch (Exception)
            {
            }
            }
        /// <summary>
        /// 客户端接收到服务器发送的消息
        /// </summary>
        /// <param name="o">客户端</param>
        void ReciveMsg(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                try
                {
                    ///定义客户端接收到的信息大小
                    byte[] arrList = new byte[1024 * 1024];
                    ///接收到的信息大小(所占字节数)
                    int length = client.Receive(arrList);
                    string Items_String = Encoding.UTF8.GetString(arrList, 0, length);
                    int STX_FLAG = Items_String.IndexOf((char)02);
                    int ETX_FLAG = Items_String.IndexOf((char)03);
                    while ((STX_FLAG > -1) & (ETX_FLAG > -1))
                    {
                            string msg = DateTime.Now + " [Rcv] " + Items_String.Substring(STX_FLAG, (ETX_FLAG - STX_FLAG));
                            listBox1.Items.Add(msg);
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            Items_String = Items_String.Remove(Items_String.IndexOf((char)03));
                        STX_FLAG = Items_String.IndexOf((char)02);
                        ETX_FLAG = Items_String.IndexOf((char)03);
                    }
                    if (Items_String == "CMD")
                    {
                        SendMsg("What CMD is ?");
                    }
                }
                catch (Exception)
                {
                    ///关闭客户端
                    client.Close();
                }
            }
        }
        /// <summary>
        /// 客户端发送消息给服务端
        /// </summary>
private void CMON_Click_1(object sender, EventArgs e)
        {
            string send_Data = Port.Text + "OCMON";
            SendMsg(send_Data);
           
        }
private void Send_Button_Click(object sender, EventArgs e)
        {
            SendMsg(Send_textBox1.Text);
        }
        void SendMsg(string str)
        {
            try
            {
                str = (char)02 + str + (char)03;
                string msg = DateTime.Now + " [Sed] " + str;
                listBox1.Items.Add(msg);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                byte[] arrMsg = Encoding.UTF8.GetBytes(str);
                client.Send(arrMsg);
            }
            catch (Exception)
            {
                ///关闭客户端
                client.Close();
            }

        }
        private void OCMOF_Click(object sender, EventArgs e)
        {
                string send_Data = Port.Text + "OCMOF";
                SendMsg(send_Data);
        }
        private void HC_Click(object sender, EventArgs e)
        {
            int Data_Len;
            if (HCON.Text.Length < 5)
            {
            Data_Len = 5 - HCON.Text.Length;
                for (int i = 0 ; i < Data_Len; i++)
                {
                    HCON.Text = "0" + HCON.Text;
                }
            }
            if (HCOF.Text.Length < 5)
            {
                Data_Len = 5 - HCOF.Text.Length;
                for (int i = 0; i < Data_Len; i++)
                {
                    HCOF.Text = "0" + HCOF.Text;
                }
            }

            string send_Data = Port.Text + "HC"+ HCON.Text + HCOF.Text;
                SendMsg(send_Data);
        }
        private void LC_Click(object sender, EventArgs e)
        {
            int Data_Len;
            if (LCT1.Text.Length < 5)
            {
                Data_Len = 5 - LCT1.Text.Length;
                for (int i = 0; i < Data_Len; i++)
                {
                    LCT1.Text = "0" + LCT1.Text;
                }
            }
            if (LCT2.Text.Length < 5)
            {
                Data_Len = 5 - LCT2.Text.Length;
                for (int i = 0; i < Data_Len; i++)
                {
                    LCT2.Text = "0" + LCT2.Text;
                }
            }
            if (LCF1.Text.Length < 5)
            {
                Data_Len = 5 - LCF1.Text.Length;
                for (int i = 0; i < Data_Len; i++)
                {
                    LCF1.Text = "0" + LCF1.Text;
                }
            }
            if (LCF2.Text.Length < 5)
            {
                Data_Len = 5 - LCF2.Text.Length;
                for (int i = 0; i < Data_Len; i++)
                {
                    LCF2.Text = "0" + LCF2.Text;
                }
            }
            string send_Data = Port.Text + "LC" + LCT1.Text+LCT2.Text+LCF1.Text+LCF2.Text;
            SendMsg(send_Data);
        }

        private void OCMS_Click(object sender, EventArgs e)
        {
            string send_Data = Port.Text + "OCMS";
            SendMsg(send_Data);
        }

        private void Port_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Disconnected.Text = "斷綫";
            Connection.Text = "連綫";
            label1.Text = "Port 號";
            CMON.Text = "O2 矯正開啓";
            OCMOF.Text = "O2 矯正關閉";
            label2.Text = "抽氣打開時間";
            label3.Text = "抽氣關閉時間";
            HC.Text = "高點矯正開啓";
            label4.Text = "高流量充氣時間";
            label6.Text = "高流量設定值";
            label5.Text = "低流量矫正延遲時間";
            label7.Text = "低流量設定值";
            LC.Text = "低點矯正開啓";
            OCMS.Text = "矯正值寫入";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Disconnected.Text = "Disconnected";
            Connection.Text = "Connection";
            label1.Text = "Port Number";
            CMON.Text = "O2 Correction ON";
            OCMOF.Text = "O2 Correction OFF";
            label2.Text = "Pump ON time";
            label3.Text = "Pump OFF time";
            HC.Text = "High Correction Start";
            label4.Text = "High Flow Time";
            label6.Text = "High Flow Setting";
            label5.Text = "Low Flow Correction Delay Time";
            label7.Text = "Low Flow Setting";
            LC.Text = "Low Correction Start";
            OCMS.Text = "Correction Write";
        }
    }
}
