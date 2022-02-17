using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_Response
    {
        public Geek_RobotInfoMsg_Response_header header = new Geek_RobotInfoMsg_Response_header();
        public List<Geek_RobotInfoMsg_Response_body> body = new List<Geek_RobotInfoMsg_Response_body>();//路径
    } 
}
