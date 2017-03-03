using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 2, 5, 8, 7 };

            // Array.Reverse(a);
            //foreach (var item in a)
            //{
            //    Console.Write(item + " ");
            //}
            Console.WriteLine(Method("hello"));
        }

        public static string Method(string a)
        {
            char[] b = a.ToCharArray();
            Array.Reverse(b);


            return new string(b);
        }
    }
}
