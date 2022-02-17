using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Geek_Plus_Json_Http
{
    public partial class Form1 : Form
    {
        Geek geek ;
        public int i;
        public Form1()
        {
            InitializeComponent(); 
            geek = new Geek();
        }
        public delegate void Thread_Geek_Geek_RobotInfoMsg_Response_Event(Geek_RobotInfoMsg_Response NameObject);
        private void Geek_Geek_RobotInfoMsg_Response_Event(Geek_RobotInfoMsg_Response NameObject)
        {
            if (label1.InvokeRequired)
            {
                Thread_Geek_Geek_RobotInfoMsg_Response_Event helper = new Thread_Geek_Geek_RobotInfoMsg_Response_Event(Geek_Geek_RobotInfoMsg_Response_Event);
                label1.Invoke(helper, NameObject);
            }
            else
            {
                label1.Text = geek.RobotInfoMsg_QTY.ToString();
                responseId_textBox.Text = NameObject.header.responseId.ToString();
                msgType_textBox.Text = NameObject.header.msgType.ToString();
                code_textBox.Text = NameObject.header.code.ToString();
                msg_textBox.Text = NameObject.header.msg.ToString();
                robot_textBox.Text = NameObject.body[0].robot.ToString();
                robotConnectStatus_textBox.Text = NameObject.body[0].robotConnectStatus.ToString();
                robotStopStatus_textBox.Text = NameObject.body[0].robotStopStatus.ToString();
                robotError_textBox.Text = NameObject.body[0].robotError.ToString();
                powerPercent_textBox.Text = NameObject.body[0].powerPercent.ToString();
                angle_textBox.Text = NameObject.body[0].angle.ToString();
                if(NameObject.body[0].speed == null)
                {
                    speed_textBox.Text =String.Empty;
                }
                else
                {
                    speed_textBox.Text = NameObject.body[0].speed.ToString();
                }
                location_textBox.Text = NameObject.body[0].location.ToString();
                locationIndex_textBox.Text = NameObject.body[0].locationIndex.ToString();
                locationCode_textBox.Text = NameObject.body[0].locationCode.ToString();
                if(NameObject.body[0].hostLocationCode == null)
                {
                    robotConnectStatus_textBox.Text = String.Empty;
                }
                else
                {
                    robotConnectStatus_textBox.Text = NameObject.body[0].hostLocationCode.ToString();
                }
                robotPathMode_textBox.Text = NameObject.body[0].robotPathMode.ToString();
                if (NameObject.body[0].robotTaskId == null)
                {
                    robotTaskId_textBox.Text = String.Empty;
                }
                else
                {
                    robotTaskId_textBox.Text = NameObject.body[0].robotTaskId.ToString();
                }
                path_textBox.Text = NameObject.body[0].path.ToString();
                voltage_textBox.Text = NameObject.body[0].voltage.ToString();
                current_textBox.Text = NameObject.body[0].current.ToString();
                temperature_textBox.Text = NameObject.body[0].temperature.ToString();
                ip_textBox.Text = NameObject.body[0].ip.ToString();
                if (NameObject.body[0].instanceId == null)
                {
                    instanceId_textBox.Text = String.Empty;
                }
                else
                {
                    instanceId_textBox.Text = NameObject.body[0].instanceId.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            geek.Geek_RobotInfoMsg_Response_Event += new Geek._Geek_RobotInfoMsg_Response_Event(Geek_Geek_RobotInfoMsg_Response_Event);
        }
        private void Send_BT_Click(object sender, EventArgs e)
        {
            geek.WorkflowStartMsg("155-156");
            /*
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postBody  = JsonConvert.SerializeObject(new Geek_WorkflowStartMsg_CMD(new Geek_WorkflowStartMsg_CMD_body("155-154")));//将对象转换成json存储
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
            Geek_WorkflowStartMsg_Response NameObject = JsonConvert.DeserializeObject<Geek_WorkflowStartMsg_Response>(responseStr);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            geek.WorkflowStartMsg("156-155");
            /*
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postBody = JsonConvert.SerializeObject(new Geek_WorkflowStartMsg_CMD(new Geek_WorkflowStartMsg_CMD_body("154-155")));//将对象转换成json存储
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
            Geek_WorkflowStartMsg_Response NameObject = JsonConvert.DeserializeObject<Geek_WorkflowStartMsg_Response>(responseStr);
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            geek.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            geek.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            geek.RobotInfoMsg();
        }
    }
}