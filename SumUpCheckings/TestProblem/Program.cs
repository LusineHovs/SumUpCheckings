using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblem
{
    internal class A
    {
        private int i = initA();
        public static int initA() { return 2; }

        public A()
        { print(); }

        public virtual void print()
        { Console.Write(i + " "); }
    }
    internal class B : A
    {
        private int i = initB();
        public static int initB() { return 8; }

        public override void print()
        { Console.Write(i + " "); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.print();
        }
    }
}
