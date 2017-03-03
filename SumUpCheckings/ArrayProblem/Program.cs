using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int[] c = Method(k, a);

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] Method(int indexNumber, int[] a)
        {
            //a = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    while (i<=k)
            //    {
            //        a[i] = a[n - 1];
            //       // a[i + 1] = a[i];
            //    }
            //}

            int[] b = new int[a.Length];

            for (int i = indexNumber; i <= 0; i--)
            {
                if (i != 0)
                {
                    b[i - 1] = a[i];
                }
                else
                {
                    b[a.Length - 1] = a[0];
                    b[0] = a[a.Length - 1];
                }
            }

            return b;
        }
    }
}
