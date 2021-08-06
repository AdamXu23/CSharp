using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06_Inherit.Class
{
    //Car_Park繼承Car類別
    class Car_Park :Car
    {
        private DateTime _Parking_Time;//加入停車時間屬性
        private DateTime _Departure_Time;//加入離開時間

        public DateTime Parking_Time 
        { 
            get
            {
                return _Parking_Time;
            }
        }
        public DateTime Departure_Time 
        { 
            get
            {
                return _Departure_Time;
            }
        }

        public string Show_Log()
        {
            string str = "Parking_Time:\t" + _Parking_Time.ToString()+ "\tDeparture_Time:\t"+ _Departure_Time.ToString();
            return str;
        }

        public Car_Park()
        {
            _Parking_Time = System.DateTime.Now;
        }
        public Car_Park(Car vCar)
        {
            Set_Car(vCar);
            _Parking_Time = System.DateTime.Now;
        }
        public override string ToString()
        {
            return "Name=" + Get_Name() + 
                "\tBrands=" + Brands + 
                "\tTurbo=" +GetTurbo().ToString() + Get_Speed_range()+ 
                "\tParking_Time="+_Parking_Time.ToString()+ 
                "\tDeparture_Time="+ _Departure_Time.ToString();
        }
    }
}
