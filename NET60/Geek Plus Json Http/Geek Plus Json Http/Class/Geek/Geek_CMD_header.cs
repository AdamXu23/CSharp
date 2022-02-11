using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_CMD_header
    {
        public string requestId;//requestId

        public string channelId;//channelId

        public string clientCode;//clientCode

        public string requestTime;//requestTime

        public Geek_CMD_header( string _channelId, string _clientCode)
        {
            this.requestId = Guid.NewGuid().ToString();
            this.channelId = _channelId;
            this.clientCode = _clientCode;
            this.requestTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        public Geek_CMD_header( )
        {
            this.requestId = Guid.NewGuid().ToString();
            this.channelId = "client-01";
            this.clientCode = "geekplus";
            this.requestTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }

}
