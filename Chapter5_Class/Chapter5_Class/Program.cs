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
            Console.Read();//讓命令提示字窗維持住
        }

    }
}
