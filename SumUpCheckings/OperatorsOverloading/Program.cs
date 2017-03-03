using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    class A
    {
        public int F1 { get; set; }



        public static A operator +(A a, A b)
        {
            A ins = new A();
            ins.F1 = a.F1 + b.F1;
            return ins;
        }
    }
    class B
    {
        public int F2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            a1.F1 = 10;
            a2.F1 = 10;
            A a3 = a1 + a2;

            Console.WriteLine(a3.F1);

        }




    }
}
