using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06_Inherit.Class
{
    delegate void DangerEvent(int vMax_Speed, int vSpeed);//宣告DangerEvent委派
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
            if (vSpeed < _Min_Speed)
            {
                Console.WriteLine("Speed < {0},Speed = {1}", _Min_Speed, _Min_Speed);
                vSpeed = _Min_Speed;
            }
            if (vSpeed > _Max_Speed)
            {
                Console.WriteLine("Speed > {0},Speed = {1}", _Max_Speed, _Max_Speed);
                vSpeed = _Max_Speed;
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
        public void Move(int vX, int vY)//定義Move方法用來設定_X, _Y坐標位置
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
                if (value < _Min_Speed) value = _Min_Speed;//速度不可小於Min_Speed
                if (value > _Max_Speed) value = _Max_Speed;//速度不可大於Max_Speed
                _Speed = value;//設定速度
            }
        }
        public void Accelerate_1()//定義Accelerate_1速度加1方法
        {
            _Speed++;//速度+1
            if (_Speed > _Min_Speed) _Speed = _Min_Speed;//速度不能大於200
        }
        public void Accelerate()//定義Accelerate速度加1,呼叫自身類別的方法,方法1
        {
            __Speed++;
        }
        //方法多載
        public void Accelerate(int addSpeed)//定義Accelerate加速度方法2
        {
            __Speed += addSpeed;
        }
        public void Accelerate(string s)//定義Accelerate加速度方法2
        {
            if (s == "STOP") __Speed = 0;
        }
        //建構函式
        private int _Max_Speed, _Min_Speed;
        public Car()
        {
            _Max_Speed = 200;
            _Min_Speed = 0;
        }
        public Car(int vMax_Speed)
        {
            _Max_Speed = vMax_Speed;
            _Min_Speed = 0;
        }
        public Car(int vMax_Speed, int vMin_Speed)
        {
            _Max_Speed = vMax_Speed;
            _Min_Speed = vMin_Speed;
        }
        public string Get_Speed_range()
        {
            //Console.WriteLine("Max_Speed = {0}", _Max_Speed);
            //Console.WriteLine("Min_Speed = {0}", _Min_Speed);
            return "\tMax_Speed=" + _Max_Speed.ToString() +
                "\tMin_Speed=" + _Min_Speed.ToString();
        }
        //物件初始設定式
        private string _Name { set; get; }
        public Car(string vName) { _Name = vName; }
        public string Get_Name()
        {
            return _Name;
        }
        //事件的建立
        //在class外宣告DangerEvent委派delegate void DangerEvent(int vSpeed);
        public event DangerEvent DangerSpeed;//宣告事件
        public int Forcibly_Speed
        {
            get
            {
                return _Speed;
            }
            set
            {
                if (value > _Max_Speed)
                {
                    if (DangerSpeed != null) DangerSpeed(_Max_Speed, value);//啓動事件
                }
                _Speed = value;
            }
        }
        //Other New
        private string _Brands;
        public string Brands 
        { 
            get
            {
                return _Brands;
            }
        }
        public Car(string vName , string vBrands, bool vTurbo, int vMax_Speed, int vMin_Speed)
        {
            _Max_Speed = vMax_Speed;
            _Min_Speed = vMin_Speed;
            _Name = vName;
            _Brands = vBrands;
            _Turbo = vTurbo;
        }
        public void Set_Car(string vName, string vBrands, bool vTurbo, int vMax_Speed, int vMin_Speed)
        {
            _Max_Speed = vMax_Speed;
            _Min_Speed = vMin_Speed;
            _Name = vName;
            _Brands = vBrands;
            _Turbo = vTurbo;
        }
        public void Set_Car(Car vCar)
        {
            _Max_Speed = vCar._Min_Speed;
            _Min_Speed = vCar._Min_Speed;
            _Name = vCar._Name;
            _Brands = vCar._Brands;
            _Turbo = vCar._Turbo;
        }
        public Car(Car vCar)
        {
            _Max_Speed = vCar._Min_Speed;
            _Min_Speed = vCar._Min_Speed;
            _Name = vCar._Name;
            _Brands = vCar._Brands;
            _Turbo = vCar._Turbo;
        }
        public bool GetTurbo()
        {
            return _Turbo;
        }
        //===============================================================================================================================
        protected int _Price_Worth;//宣告_Price_Worth為保護成級，此欄位可以在子類別中使用。  
        public virtual int Price_Worth//父類別的屬性准許被覆寫
        {
            get
            {
                return _Price_Worth;
            }
            set
            {
                if (value>=100)
                {
                    _Price_Worth = value;
                }
                else
                {
                    _Price_Worth = 100;
                }
            }
        }
        //覆寫 ToString 方法
        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return ("Name="+ _Name + "\tBrands="+ _Brands + "\tTurbo="+ _Turbo.ToString() + "\tMax_Speed="+ _Max_Speed.ToString() + "\tMin_Speed="+ _Min_Speed.ToString());
        }
    }
}
