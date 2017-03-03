using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAs
{
    class A
    {
        public void Method()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public void Method()
        {
            Console.WriteLine("B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // A a = new A();
            // B b = new B();

            //A a1 = b;
            //a1.Method();

            string d = "10";
            bool s = d is string;
            Console.WriteLine(s);

        }
    }
}
