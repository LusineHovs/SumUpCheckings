using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkings
{
    interface IA
    {
        void MethodA();
    }
    interface IB
    {
        void MethodB();
    }
    class A : IA
    {
        public void MethodA()
        {
            throw new NotImplementedException();
        }
    }
    class B : IB
    {
        public void MethodB()
        {
            throw new NotImplementedException();
        }
    }
    class C : IA, IB
    {
        A a = new A();
        B b = new B();

        public void MethodA()
        {
            a.MethodA();
            
        }

        public void MethodB()
        {
            b.MethodB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
