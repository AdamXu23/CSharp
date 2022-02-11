using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Geek_Plus_Json_Http
{
    public class Geek_CMD
    {
        public Geek_CMD_header header = new Geek_CMD_header();
        public Geek_CMD_body body = new Geek_CMD_body();
        public Geek_CMD(Geek_CMD_header _GeekCMDHeader, Geek_CMD_body _body)
        {
            this.header = _GeekCMDHeader;
            this.body = _body;
        }
        public Geek_CMD(Geek_CMD_body _body)
        {
            this.body = _body;
        }
    }

}
