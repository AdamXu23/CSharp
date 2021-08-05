using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Class.Class
{
    class Car
    {
        public int Speed;//(public)建立公共屬性Speed
        private int _Speed;//(private)建立私有屬性_Speed
        public int GetSpeed()//定義GetSpeed方法來傳回_Speed
        {
            return _Speed;
        }
        public void SetSpeed(int vSpeed)//定義SetSpeed方法來設定_Speed
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

        private int _Angle = 10;//(private)建立私有屬性_Angle，初始值為10
        public int Angle//定義Angle唯讀屬性
        {   
            //Angle屬性只有get沒有set
            get
            {
                return _Angle;
            }
        }

        private bool _Turbo = false;//(private)建立私有屬性_Turbo，初始值為false
        public bool Turbo//定義Turbo唯寫屬性
        {
            //Turbo屬性只有set沒有get
            set
            {
                _Turbo = value;
            }
        }
    }
}
