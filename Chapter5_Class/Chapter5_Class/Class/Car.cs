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
        private int _Speed = 0;//(private)建立私有屬性_Speed，初始值為0
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

        private int _X, _Y;//(private)建立私有屬性_X, _Y坐標位置
        public void Move(int vX,int vY)//定義Move方法用來設定_X, _Y坐標位置
        {
            _X = vX;
            _Y = vY;
        }

        public int __Speed//定義Speed可讀可寫屬性
        {
            get
            {
                return _Speed;
            }
            set
            {
                if (value < 0) value = 0;//速度不可小於0
                if (value > 200) value = 200;//速度不可大於200
                _Speed = value;//設定速度
            }
        }
        public void Accelerate_1()//定義Accelerate_1速度加1方法
        {
            _Speed++;//速度+1
            if (_Speed > 200) _Speed = 200;//速度不能大於200
        }
        public void Accelerate()//定義Accelerate速度加1,呼叫自身類別的方法,方法1
        {
            __Speed++;
        }

        ///方法多載
        public void Accelerate(int addSpeed)//定義Accelerate加速度方法2
        {
            __Speed+= addSpeed;
        }
        public void Accelerate(string s)//定義Accelerate加速度方法2
        {
            if (s == "STOP") __Speed = 0;
        }
    }
}
