using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -100;
            int b = 100;
            Method(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void Method(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
