using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_Response_header
    {
        public string responseId;//requestId

        public string msgType;//channelId

        public string code;//clientCode

        public string msg;//requestTime
        public Geek_RobotInfoMsg_Response_header()
        {
        }
    }
}
