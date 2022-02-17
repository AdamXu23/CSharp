using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_CMD
    {
        public Geek_RobotInfoMsg_CMD_header header = new Geek_RobotInfoMsg_CMD_header();
        public Geek_RobotInfoMsg_CMD_body body = new Geek_RobotInfoMsg_CMD_body();
        public Geek_RobotInfoMsg_CMD()
        {
        }
    }

}
