using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_CMD_flowRuleCondition
    {
        public string extraParam1 = String.Empty;//extraParam1

        public Geek_RobotInfoMsg_CMD_flowRuleCondition( string _extraParam1)
        {
            this.extraParam1 = _extraParam1;
        }
        public Geek_RobotInfoMsg_CMD_flowRuleCondition( )
        {
        }
    }

}
