using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int> { 9, 8, 7, 6 };
            List<int> sorted = bubblesort(unsorted);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> bubblesort(List<int> a)
        {
            int temp;
            for (int i = 1; i <= a.Count; i++)
                for (int j = 0; j < a.Count - i; j++)
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            return a;

        }
    }
}
