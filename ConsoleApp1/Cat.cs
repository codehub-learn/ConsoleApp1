using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : IPrintName, IComparable<Cat>
    {
        public int age { get; set; }
        public string name { get; set; }

        public string GetName()
        {
            return name;
        }

        public int CompareTo(Cat other)
        {
            if (other == null) return 0;
            else return age - other.age;
        }

      
    }
}
