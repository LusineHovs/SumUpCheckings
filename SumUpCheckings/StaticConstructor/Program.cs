using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class A
    {
        private static int a1;

        static A()
        {
            a1 = 125;
            Console.WriteLine(a1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b = new A();

        }
    }
}
