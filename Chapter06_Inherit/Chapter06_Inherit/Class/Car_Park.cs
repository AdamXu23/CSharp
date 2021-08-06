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

        public int No { get; set; }//No屬性記錄是第幾部車
        public static int Total { get; set; }//Total靜態屬性記錄車子總數

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
        public Car_Park(Car vCar)
        {
            Set_Car(vCar);
            Total++;//總共記錄數量+1
            No = Total;//記錄是第多少輛；
            _Parking_Time = System.DateTime.Now;
        }
        public override string ToString()
        {
            return "No = " + No.ToString()+
                "\tName=" + Get_Name() + 
                "\tBrands=" + Brands + 
                "\tTurbo=" +GetTurbo().ToString() + Get_Speed_range()+ 
                "\tParking_Time="+_Parking_Time.ToString()+ 
                "\tDeparture_Time="+ _Departure_Time.ToString();
        }
    }
}
