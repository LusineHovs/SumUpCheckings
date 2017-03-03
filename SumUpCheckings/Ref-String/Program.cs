using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = "aaa";
            Console.WriteLine(g);
            Method(ref g);
            Console.WriteLine(g);

            Console.WriteLine(@"C:\MyApp\bin\Debug");

            string c = "hello";
            Console.WriteLine(c.ToUpper());
            Console.WriteLine(c);
        }

        public static void Method(ref string a)
        {
            a = "bbb";
            Console.WriteLine(a);
        }
    }
}
