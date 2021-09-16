using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TCP_Socket_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///多线程编程中，如果子线程需要使用主线程中创建的对象和控件，最好在主线程中体现进行检查取消
            CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 创建一个字典，用来存储记录服务器与客户端之间的连接(线程问题)
        /// </summary>
        Dictionary<string, Socket> clientList = new Dictionary<string, Socket>();
        Dictionary<string, string> Answerlist = new Dictionary<string, string>();
        Socket Send_Socket ;
        bool Send_Socket_Auto;
        //INI文件名 
        public string FileName;
        //声明写INI文件的API函数 
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        //声明读INI文件的API函数 
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        /// <summary>
        /// 创建连接
        /// </summary>
        private void Listener_Button_Click(object sender, EventArgs e)
        {
            Thread myServer = new Thread(MySocket);
            //设置这个线程是后台线程
            myServer.IsBackground = true;
            myServer.Start();
        }
        /// <summary>
        /// 创建连接的方法
        /// </summary>
        void MySocket()
        {
            //1.创建服务器端电话
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //2.创建手机卡
            IPAddress iP = IPAddress.Parse(IPAddress_Text.Text);
            IPEndPoint endPoint = new IPEndPoint(iP, int.Parse(IPPort_Text.Text));
            //3.将电话卡插进电话中
            server.Bind(endPoint);
            //4.开始监听电话卡
            //同一时刻内允许同时加入链接的最大数量
            server.Listen(20);
            //listBox1.Items.Add("服务器已经成功开启!");
            MessageBox.Show("服务器已经成功开启!");
            //5.等待来电接电话
            while (true)
            {
                //接受接入的一个客户端
                Socket connectClient = server.Accept();
                if (connectClient != null)
                {
                    string infor = connectClient.RemoteEndPoint.ToString();
                    clientList.Add(infor, connectClient);
                    comboBox1.Items.Add(infor);
                    MessageBox.Show(infor + "加入服务器!");
                        if (checkBox1.Checked)
                    {
                        Send_Socket = connectClient;
                    }

                    //每有一个客户端接入时，需要有一个线程进行服务
                    Thread threadClient = new Thread(ReciveMsg);
                    threadClient.IsBackground = true;
                    //设置这个线程中的通信对象是对应的Socket和客户端Socket进行通信
                    threadClient.Start(connectClient);
                }
            }
        }
        /// <summary>
        /// 服务器接收到客户端发送的消息
        /// </summary>
        /// <param name="o">客户端</param>
        void ReciveMsg(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                try
                {
                    ///定义服务器接收的字节大小
                    byte[] arrMsg = new byte[1024 * 1024];
                    ///接收到的信息大小(所占字节数)
                    int length = client.Receive(arrMsg);

                    if (length > 0)
                    {
                        string recMsg = Encoding.UTF8.GetString(arrMsg, 0, length);
                        //获取客户端的端口号
                        IPEndPoint endPoint = client.RemoteEndPoint as IPEndPoint;
                        //服务器显示客户端的端口号和消息
                        listBox1.Items.Add(DateTime.Now + "[Rcv]:[" + endPoint.Port.ToString() + "]：" + recMsg);
                        if (checkBox1.Checked)
                        {
                            Send_Socket = client;
                        }
                        if (Answer_List_EN.Checked)
                        {
                            foreach (var item in Answerlist)
                            {
                                if (recMsg.Contains(item.Key))
                                {
                                    SendMsg(Send_Socket,item.Value);
                                }
                            }

                        }
                    }
                }
                catch (Exception)
                {
                    ///关闭客户端
                    string Remove_Socket = client.RemoteEndPoint.ToString();
                    ///移除添加在字典中的服务器和客户端之间的线程
                    MessageBox.Show(DateTime.Now + "[Remove]：" + Remove_Socket);
                    clientList.Remove(Remove_Socket);
                    comboBox1.Items.Remove(Remove_Socket);
                    MessageBox.Show(Remove_Socket + "Already removed");
                    client.Close();
                    System.Threading.Thread.CurrentThread.Abort();
                }
            }
        }
        /// <summary>
        /// 获取本地IP
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress_Text.Items.Clear();
            string name = Dns.GetHostName();
            IPAddress[] ipadrlist = Dns.GetHostAddresses(name);
            foreach (IPAddress ipa in ipadrlist)
                 {
                             if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    IPAddress_Text.Items.Add(ipa.ToString());
                 }
        }
        /// <summary>
        /// 服务器发送消息，客户端接收到
        /// </summary>
        void SendMsg(Socket Socket_IN,string str)
        {
            string Send_IPEndPoint = Socket_IN.RemoteEndPoint.ToString();
            listBox1.Items.Add(DateTime.Now + "[" + Send_IPEndPoint + "][Sed]：" + str);
            byte[] arrMsg = Encoding.UTF8.GetBytes(str);
            Socket_IN.Send(arrMsg);
        }
        /// <summary>
        /// 服务器发送消息
        /// </summary>

        private void Send_Butter_Click(object sender, EventArgs e)
        {
            if (Send_textBox.Text != "")
            {
                try
                {
                    SendMsg(Send_Socket, Send_textBox.Text);
                    Send_textBox.Text = "";
                }
                catch (Exception)
                { 
                    MessageBox.Show("Please select a sending port.");
                }
            }
        }
        /// <summary>
        /// 发送客户端选择
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                Send_Socket = clientList[comboBox1.Text];
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Automatically send back to the sending client");
            }
            else
            {
                MessageBox.Show("You are in the CheckBox.CheckedChanged event.");
            }
        }
        private void Answer_list_added_Click(object sender, EventArgs e)
        {
            Answerlist.Add(KeyWord.Text, Return_text.Text);
            Answer_List.Items.Add(KeyWord.Text);
            Return_list.Items.Add(Return_text.Text);
        }

        private void Answer_List_Deletion_Click(object sender, EventArgs e)
        {
            Return_list.Items.Remove(Answerlist[Answer_List.SelectedItem.ToString()]);
            Answerlist.Remove(Answer_List.SelectedItem.ToString());
            Answer_List.Items.Remove(Answer_List.SelectedItem);
        }

        private void IPAddress_Text_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
