using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Class1
    {
        public delegate void MyDelegate (int x);

        public static void ProcessInput(List<int> ints, MyDelegate operation)
        {
            foreach (int i in ints)
            {
                operation(i);
            }
                
        }
    }
}
