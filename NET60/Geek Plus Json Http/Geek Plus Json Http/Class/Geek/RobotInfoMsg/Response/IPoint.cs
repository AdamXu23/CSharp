using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Plus_Json_Http
{
    public class IPoint
    {
        public double z;
        public double x;
        public double y;
        public IPoint()
        {

        }

        public override string ToString()
        {
            return "z:" + z.ToString() + ",x:" + x.ToString() + ",y:" + y.ToString();
        }
    }
}
