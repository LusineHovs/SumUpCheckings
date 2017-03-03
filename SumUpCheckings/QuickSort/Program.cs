using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int> { 9, 8, 7, 6 };
            List<int> b = quicksort(unsorted);
            foreach (var item in b)
            {
                Console.WriteLine(item);

            }

        }

        public static List<int> quicksort(List<int> a)
        {
            Random r = new Random();
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            if (a.Count <= 1) return a;
            int position = r.Next(a.Count);

            int pivot = a[position];
            a.RemoveAt(position);
            foreach (var item in a)
            {
                if (item <= pivot) less.Add(item);
                else
                {
                    greater.Add(item);
                }
            }
            return concat(quicksort(less), pivot, quicksort(greater));

        }

        public static List<int> concat(List<int> less, int pivot, List<int> greater)
        {
            List<int> sorted = new List<int>(less);
            sorted.Add(pivot);
            foreach (int i in greater)
            {

                sorted.Add(i);
            }

            return sorted;
        }
    }
}
