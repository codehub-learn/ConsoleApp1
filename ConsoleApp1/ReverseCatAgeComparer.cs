using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReverseCatAgeComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        { 
            return y.age - x.age;
        }
    }
}
