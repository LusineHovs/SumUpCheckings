using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestP1
{
    class A
    {
        public static bool compare(int a, int b)
        {
            return (a == b);
        }

        public static bool compare(string a, string b)
        {
            return (a == b);
        }

        public static bool compare(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        //continue;
                        return false;
                    }
                    //else
                    //{
                    //    return false;
                    //}

                }
                return true;
            }

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a.Length == b.Length && a[i] == b[i])
            //    {
            //        return true;
            //    }
            //    else return false;
            //} 

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 2, 3, 8, 5 };
            Console.WriteLine(A.compare(a, b));
        }
    }
}
