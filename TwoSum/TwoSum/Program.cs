using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            int diff = 0; ;
            int a = 0;
            int b = 0;
            for (int i = 0; i < list.Count; i++)
            {
                diff = sum - list[i];
                if (list.Contains(diff))
                {
                    a = list.IndexOf(diff);
                    b = list.IndexOf(list[i]);
                }
            }
            return new Tuple<int, int>(b, a);


        }
    }
}
