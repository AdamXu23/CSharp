using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_example
{
    public class Person
    {
        public string Name;//姓名

        public DateTime DT;//時間

        public bool Sex;//性别，是否是男

        public Person(string name, bool sex, DateTime dateTime)

        {
            this.Name = name;

            this.Sex = sex;

            this.DT = dateTime;
        }

        public override string ToString()

        {
            return "姓名：" + this.Name + "\t性别：" + (this.Sex ? "男" : "女");

        }
    }
}
