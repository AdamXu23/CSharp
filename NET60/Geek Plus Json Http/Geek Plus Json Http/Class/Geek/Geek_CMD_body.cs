using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_CMD_body
    {

        public string msgType = "WorkflowStartMsg";//extraParam1
        public string taskCode = String.Empty;//extraParam1
        public string workflowCode = String.Empty;//extraParam1
        public string startPoint = String.Empty;//extraParam1
        public string locationCode = String.Empty;//extraParam1
        public string containerCategory = String.Empty;//extraParam1
        public string containerCode = String.Empty;//extraParam1
        public string nextPoint = String.Empty;//extraParam1
        public Geek_CMD_flowRuleCondition flowRuleCondition = new Geek_CMD_flowRuleCondition();


        public Geek_CMD_body(string _workflowCode)
        {
            this.workflowCode = _workflowCode;
        }
        public Geek_CMD_body()
        {
        }
    }
}
