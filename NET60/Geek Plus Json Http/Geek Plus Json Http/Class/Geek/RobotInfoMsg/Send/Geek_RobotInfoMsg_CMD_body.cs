using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_CMD_body
    {

        public string msgType = "RobotInfoMsg";//extraParam1
        public string robot = "3501014";//extraParam1
        public string[] robots = new string [] {String.Empty};//extraParam1
        public string[] robotProducts = new string[] { "M500L" };//extraParam1
        public string robotConnectStatus = String.Empty;//extraParam1
        public string robotTaskStatus = String.Empty;//extraParam1
        public string robotErrorCode = String.Empty;//extraParam1
        public Geek_RobotInfoMsg_CMD_body()
        {
        }
    }
}
