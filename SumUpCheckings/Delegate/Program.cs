using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Mydel();
    class A
    {

    }

    class Program
    {
        public static void Method()
        {
            Console.WriteLine("Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }
        static void Main(string[] args)
        {
            Mydel my = new Mydel(Method);
            my += Method2;
            my();
        }
    }
}
