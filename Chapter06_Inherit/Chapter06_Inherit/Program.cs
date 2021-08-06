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
            //宣告Ada_Car_Park物件為Car_Park類別，以Ada_Car屬性為Car_Park的屬性
            //Car_Park Total 自動+1
            Class.Car_Park Ada_Car_Park = new Class.Car_Park(Ada_Car);
            Console.WriteLine(Ada_Car_Park.ToString());//輸出Ada_Car_Park物件屬性
            Class.Car Aaliyah_Car = new Class.Car("Aaliyah", "Audi", true, 280, 0);//宣告Aaliyah_Car物件為Car類別，填入屬性
            Console.WriteLine(Aaliyah_Car.ToString());//輸出Aaliyah_Car物件屬性
            //宣告Aaliyah_Car_Park物件為Car_Park類別，以Aaliyah_Car屬性為Car_Park的屬性
            //Car_Park Total 自動+1
            Class.Car_Park Aaliyah_Car_Park = new Class.Car_Park(Aaliyah_Car);
            Console.WriteLine(Aaliyah_Car_Park.ToString());//輸出Ada_Car_Park物件屬性
            //=====================================================================================================================================================
            /*
            Console.WriteLine("Ada_Car.Price_Worth =={0}", Ada_Car.Price_Worth);
            Console.WriteLine("Aaliyah_Car_Park.Price_Worth =={0}", Aaliyah_Car_Park.Price_Worth);
            Ada_Car.Price_Worth = 10;
            Console.WriteLine("Ada_Car.Price_Worth = 10");
            Console.WriteLine("Ada_Car.Price_Worth =={0}", Ada_Car.Price_Worth);
            Console.WriteLine("Aaliyah_Car_Park.Price_Worth =={0}", Aaliyah_Car_Park.Price_Worth);
            Aaliyah_Car_Park.Price_Worth = 20;
            Console.WriteLine("Aaliyah_Car_Park.Price_Worth = 20");
            Console.WriteLine("Ada_Car.Price_Worth =={0}", Ada_Car.Price_Worth);
            Console.WriteLine("Aaliyah_Car_Park.Price_Worth =={0}", Aaliyah_Car_Park.Price_Worth);
            string str = Aaliyah_Car_Park.ToString();
            Console.WriteLine(str);
            */
            Employee E = new Employee();
            E.GetInfo();


            Console.Read();
        }
    }
    public class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "John L. Malgraine";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
        }
    }
    class Employee : Person
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }

}
