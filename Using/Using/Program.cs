using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    class A : IDisposable
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
        void IDisposable.Dispose()
        {
            Console.WriteLine("sd");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            using (A a = new A())
            {
                a.Method();
            }

            FileStream fs = new FileStream(@"sdfs", FileMode.OpenOrCreate);
            fs.Dispose();

            A b = new A();
            ((IDisposable)b).Dispose();

            ;
        }
    }
}
