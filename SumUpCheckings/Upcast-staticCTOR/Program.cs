using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcast_staticCTOR
{
    class A
    {
        public A()
        {
            Console.WriteLine("ctorA");
            F();
        }
        public virtual void F()
        {
            Console.WriteLine("B.F");
        }

    }
    class B : A
    {
        static B()
        {
            Console.WriteLine("satic ctor b");

        }
        public override void F()
        {
            Console.WriteLine("D.F");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A b = new B();
        }
    }
}
