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
            Benz.Move(100, 200);//設定Benz的X、Y坐標
            Benz.__Speed = 198;//設定_Speed速度為198
            Console.WriteLine("_Speed={0}", Benz.__Speed);
            Benz.Accelerate_1();//Accelerate_1建立的方法速度+1
            Console.WriteLine("_Speed={0}", Benz.__Speed);
            Benz.Accelerate();//Accelerate_2建立的呼叫自身類別的方法速度+1
            Console.WriteLine("_Speed={0}", Benz.__Speed);
            Benz.Accelerate();//Accelerate建立的呼叫自身類別的方法速度+1
            Console.WriteLine("_Speed={0}", Benz.__Speed);
            Benz.__Speed = 0;//設定_Speed速度為0
            Console.WriteLine("_Speed={0}", Benz.__Speed);
            Benz.Accelerate(10);//使用方法2加速
            Console.WriteLine("_Speed+=10,_Speed={0}", Benz.__Speed);
            Benz.Accelerate("STOP");//使用方法3加速
            Console.WriteLine("_Speed=STOP,_Speed={0}", Benz.__Speed);
            //建構函式
            Benz = new Class.Car();
            Benz.Get_Speed_range();
            Benz = new Class.Car(400);
            Benz.Get_Speed_range();
            Benz = new Class.Car(500,100);
            Benz.Get_Speed_range();
            //物件初始設定式
            Benz = new Class.Car("Benz_CAR");
            Console.WriteLine("Name={0}", Benz.Get_Name());
            Console.Read();//讓命令提示字窗維持住
        }

    }
}
