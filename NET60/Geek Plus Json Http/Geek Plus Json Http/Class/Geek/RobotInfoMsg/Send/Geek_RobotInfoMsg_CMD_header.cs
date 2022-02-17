using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_CMD_header
    {
        public string requestId;//requestId

        public string channelId;//channelId
        public Geek_RobotInfoMsg_CMD_header( )
        {
            this.requestId = Guid.NewGuid().ToString();
            this.channelId = "11111";
        }
    }
}
