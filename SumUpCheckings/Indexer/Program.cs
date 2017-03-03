using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class A
    {
        private string[] days = { "Sunday", "Monday" };

        public string this[int index]
        {
            get { return days[index]; }
            set { days[index] = value; }
        }
    }
    //static class B
    //{
    //    public static void F(this int a)
    //    {
    //        Console.WriteLine(a * 10);
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a[0]);
            //int tiv = 10;
            //tiv.F();
        }

    }
}
