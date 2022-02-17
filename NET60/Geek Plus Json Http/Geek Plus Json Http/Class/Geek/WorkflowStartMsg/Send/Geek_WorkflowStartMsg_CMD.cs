using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_WorkflowStartMsg_CMD
    {
        public Geek_WorkflowStartMsg_CMD_header header = new Geek_WorkflowStartMsg_CMD_header();
        public Geek_WorkflowStartMsg_CMD_body body = new Geek_WorkflowStartMsg_CMD_body();
        public Geek_WorkflowStartMsg_CMD(Geek_WorkflowStartMsg_CMD_header _GeekCMDHeader, Geek_WorkflowStartMsg_CMD_body _body)
        {
            this.header = _GeekCMDHeader;
            this.body = _body;
        }
        public Geek_WorkflowStartMsg_CMD(Geek_WorkflowStartMsg_CMD_body _body)
        {
            this.body = _body;
        }
    }

}
