using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立一個Benz 物件類別為Car
            Class.Car Benz = new Class.Car();
            //設定Benz 的速度為100
            Benz.Speed = 100;
            Console.WriteLine("Benz.Speed = {0}",Benz.Speed);
            //設定Benz 的速度為500
            Benz.SetSpeed(500);
            Console.WriteLine("Benz._Speed = {0}", Benz.GetSpeed());
            Console.WriteLine("Benz.Angle = {0}", Benz.Angle);//Angle屬性只能讀不能寫
            Benz.Turbo = true;//Turbo屬性只能寫不能讀
            Console.Read();//讓命令提示字窗維持住
        }

    }
}
