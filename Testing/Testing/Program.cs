using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    interface IAdd
    {
        void Add();
    }
    struct Test : IAdd
    {
        public int n;
        public Test(int n)
        {
            this.n = n;
        }
        public void Add()
        {
            n++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(3);
            t.Add();
            Console.WriteLine(t.n);
            Console.Beep();

            IAdd iadd = t;
            iadd.Add();
            Console.WriteLine(t.n);


            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);


        }
    }


}
