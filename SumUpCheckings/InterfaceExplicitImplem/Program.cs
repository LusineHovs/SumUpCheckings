using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExplicitImplem
{
    interface IExample
    {
        int Method(int e);
    }
    class A : IExample
    {
        int IExample.Method(int a)
        {
            return a * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            ((IExample)a).Method(10);
        }
    }
}
