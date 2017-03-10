using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalNamedParamerts
{
    class Program
    {
        static void Main(string[] args)
        {
            Method(str: "asda", a: 12);
        }
        public static void Method(string str = "ggg", int a = 125)
        {
            Console.WriteLine(123);
        }
    }
}
