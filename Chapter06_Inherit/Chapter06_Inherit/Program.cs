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
            Class.Car Ada_Car = new Class.Car("Ada", "Benz", true, 380, 0);
            Console.WriteLine(Ada_Car.ToString());
            Class.Car_Park Ada_Car_Park = new Class.Car_Park(Ada_Car);
            Console.WriteLine(Ada_Car_Park.ToString());
            Console.Read();
        }
    }
}
