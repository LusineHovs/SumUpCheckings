using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCtorInheritance
{
    class A
    {
        static A()
        {
            Console.WriteLine("Base");
        }
    }
    class B : A
    {
        static B()
        {
            Console.WriteLine("Derived");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();

        }
    }
}
