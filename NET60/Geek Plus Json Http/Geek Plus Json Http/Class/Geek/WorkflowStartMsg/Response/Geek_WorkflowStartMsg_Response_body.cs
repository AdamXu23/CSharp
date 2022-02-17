using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Plus_Json_Http
{
    public class Geek_WorkflowStartMsg_Response_body
    {
        public string workflowCode;//requestId
        public string taskCode;//channelId
        public int instanceId;//clientCode
        public int instancePriority;//requestTime
        public string containerCode;//requestTime
        public int taskId;//requestTime
        public string locationFrom;//requestTime
        public string locationTo;//requestTime
        public string areaFrom;//requestTime
        public string areaTo;//requestTime
        public string stationFrom;//requestTime
        public string stationTo;//requestTime
    }
}
