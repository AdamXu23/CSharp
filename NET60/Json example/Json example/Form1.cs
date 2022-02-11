using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Web;

namespace Json_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dtstring = JsonConvert.ToString(DateTime.Now.AddDays(3).ToString("yyyy-MM-dd hh:mm:ss"));








            string filePath = @"C:\VM_Shared\ObjectJson.txt";

            List<string> languages = null;

            List<Programmer> list = new List<Programmer>();

            languages = new List<string>(new string[] { "C#", "Java" });

            list.Add(new Programmer("李志伟", true, languages));

            languages = new List<string>(new string[] { "C#", "C++" });

            list.Add(new Programmer("Coder2", false, languages));

            languages = new List<string>(new string[] { "C#", "C++", "C", "Java" });

            list.Add(new Programmer("Coder3", true, languages));

            //序列化对象

            string jsonStr = JsonConvert.SerializeObject(list[0]);//将对象转换成json存储

            File.WriteAllText(filePath, jsonStr);

            list.Clear();

            //反序列化对象

            list = JsonConvert.DeserializeObject<List<Programmer>>(jsonStr);

            foreach (Programmer p in list)

            {
                Console.WriteLine(p);

            }

            Console.WriteLine("OK!");

            Console.Read();

        }

        private void Send_BT_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string postBody


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