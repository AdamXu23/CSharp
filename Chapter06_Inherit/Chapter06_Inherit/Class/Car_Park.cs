using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06_Inherit.Class
{
    class Car_Park:Car
    {
        private DateTime Parking_Time;
        private DateTime Departure_Time;
        public void Park(DateTime dt)
        {
            Parking_Time = dt;
        }
        public void Departure(DateTime dt)
        {
            Departure_Time = dt;
        }
    }
}
