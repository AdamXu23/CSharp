using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Class.Class
{
    class Car
    {
        ///宣告Speed為public共用變數
        ///public共用變數可以隨意更改
        public int Speed;
        ///宣告_Speed為private共用變數
        ///private為class Car 範圍内的變數
        private int _Speed;
        ///定義GetSpeed方法來傳回_Speed
        public int GetSpeed()
        {
            return _Speed;
        }
        ///定義SetSpeed方法來設定_Speed
        public void SetSpeed(int vSpeed)
        {
            if (vSpeed<0)
            {
                Console.WriteLine("Speed < 0,Speed = 0");
                vSpeed = 0;
            }
            if (vSpeed > 200)
            {
                Console.WriteLine("Speed > 200,Speed = 200");
                vSpeed = 200;
            }
            _Speed = vSpeed;
        }
    }
}
