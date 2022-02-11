using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Geek_Plus_Json_Http
{
    public partial class Form1 : Form
    {

        string filePath = @"C:\VM_Shared\ObjectJson.txt";

        List<Geek_CMD> geek_CMD = new List<Geek_CMD>();
        public Form1()
        {
            InitializeComponent();
            geek_CMD.Add(new Geek_CMD(new Geek_CMD_body("155-154")));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonStr = JsonConvert.SerializeObject(new Geek_CMD(new Geek_CMD_body("155-154")));//将对象转换成json存储

            File.WriteAllText(filePath, jsonStr);
        }

        private void Send_BT_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postBody  = JsonConvert.SerializeObject(new Geek_CMD(new Geek_CMD_body("155-154")));//将对象转换成json存储
            byte[] byteArray = Encoding.UTF8.GetBytes(postBody);//要發送的字串轉為byte[]

            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(byteArray, 0, byteArray.Length);
            }

            string responseStr = "";
            //發出Request
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    responseStr = sr.ReadToEnd();
                }//end using  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postBody = JsonConvert.SerializeObject(new Geek_CMD(new Geek_CMD_body("154-155")));//将对象转换成json存储
            byte[] byteArray = Encoding.UTF8.GetBytes(postBody);//要發送的字串轉為byte[]

            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(byteArray, 0, byteArray.Length);
            }

            string responseStr = "";
            //發出Request
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    responseStr = sr.ReadToEnd();
                }//end using  
            }
        }
    }
}