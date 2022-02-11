using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_example
{
    public class Programmer: Person
    {
        public List<string> Languages;//编程语言

        public Programmer(string name, bool sex, List<string> languages) : base(name, sex,DateTime.UtcNow)

        {
            this.Languages = languages;
        }

        public override string ToString()

        {
            StringBuilder str = new StringBuilder();

            str.Append(base.ToString() + "\t编程语言：");

            foreach (string l in this.Languages)

            {
                str.Append(l + " ");

            }

            return str.ToString();

        }
    }
}
