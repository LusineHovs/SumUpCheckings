using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class A
    {
        public event EventHandler myevent;
        private int x;


        public A(int x)
        {
            myevent = (obj, e) => Console.WriteLine("ctor method added");
            this.x = x;
        }

        public void Method2(int x)
        {

            if (x > this.x)
            {
                Console.WriteLine(new string('-', 28));
                myevent(this, null);
            }
        }



    }
    class B
    {
        public static void Me(object sender, EventArgs e)
        {
            Console.WriteLine("b class method");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(12);
            a.myevent += Method;
            a.myevent += B.Me;
            a.Method2(78);
        }

        public static void Method(object sender, EventArgs e)
        {
            Console.WriteLine("event occures");
        }

    }
}
