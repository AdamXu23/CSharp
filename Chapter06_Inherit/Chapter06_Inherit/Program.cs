using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06_Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Class.Car Ada_Car = new Class.Car("Ada", "Benz", true, 380, 0);//宣告Ada_Car物件為Car類別，填入屬性
            Console.WriteLine(Ada_Car.ToString());//輸出Ada_Car物件屬性
            Class.Car_Park Ada_Car_Park = new Class.Car_Park(Ada_Car);//宣告Ada_Car_Park物件為Car_Park類別，以Ada_Car屬性為Car_Park的屬性
            Console.WriteLine(Ada_Car_Park.ToString());//輸出Ada_Car_Park物件屬性
            Console.Read();
        }
    }
}
