using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Plus_Json_Http
{
    public class Geek
    {
        System.Timers.Timer Mytimer;
        public uint RobotInfoMsg_QTY = 0;
        public Geek_WorkflowStartMsg_Response WorkflowStartMsg_Response;
        public Geek_RobotInfoMsg_Response RobotInfoMsg_Response;

        public delegate void _Geek_RobotInfoMsg_Response_Event(Geek_RobotInfoMsg_Response NameObject);
        public event _Geek_RobotInfoMsg_Response_Event Geek_RobotInfoMsg_Response_Event;
        public delegate void _Geek_WorkflowStartMsg_Response_Event(Geek_WorkflowStartMsg_Response NameObject);
        public event _Geek_WorkflowStartMsg_Response_Event Geek_WorkflowStartMsg_Response_Event;

        public Geek()
        {

            Mytimer = new System.Timers.Timer(500);
            Mytimer.AutoReset = true;
            Mytimer.Elapsed += new System.Timers.ElapsedEventHandler(Mytimer_tick);
            
        }
        public void Start()
        {
            RobotInfoMsg();
            Mytimer.Start();
        }
        public void Stop()
        {
            Mytimer.Stop();
        }
        private void Mytimer_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            RobotInfoMsg();
        }
        public void RobotInfoMsg()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postBody = JsonConvert.SerializeObject(new Geek_RobotInfoMsg_CMD());//将对象转换成json存储
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
            RobotInfoMsg_Response = JsonConvert.DeserializeObject<Geek_RobotInfoMsg_Response>(responseStr);
            RobotInfoMsg_QTY++;
            if (Geek_RobotInfoMsg_Response_Event != null) Geek_RobotInfoMsg_Response_Event(RobotInfoMsg_Response);
        }
        public void WorkflowStartMsg(string _workflowCode )
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.10.2:24249");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postBody = JsonConvert.SerializeObject(new Geek_WorkflowStartMsg_CMD(new Geek_WorkflowStartMsg_CMD_body(_workflowCode)));//将对象转换成json存储
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
            WorkflowStartMsg_Response = JsonConvert.DeserializeObject<Geek_WorkflowStartMsg_Response>(responseStr);
            if (Geek_WorkflowStartMsg_Response_Event != null) Geek_WorkflowStartMsg_Response_Event(WorkflowStartMsg_Response);
        }
    }
}
