using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(linearSearch(array, 7));
            Console.ReadKey();
        }
        public static int linearSearch(int[] a, int b)
        {
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    index = i;
                    break;
                }
            }
            return index;

        }
    }
}
