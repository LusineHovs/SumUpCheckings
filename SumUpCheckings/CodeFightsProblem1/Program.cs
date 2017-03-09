using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFightsProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 2, 2, 5, 10, 7 };
            Console.WriteLine(replaceMiddle(arr));
        }
        public static int[] replaceMiddle(int[] arr)
        {

            if (arr.Length % 2 == 0)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length / 2 - 1)
                    {
                        list.Add(arr[i] + arr[i + 1]);
                    }
                    else if (i != arr.Length / 2)
                    {
                        list.Add(arr[i]);
                    }
                }
                return list.ToArray();
            }
            else
            {
                return arr;
            }
        }


        public static int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            int count = 0;
            for (int i = statues[0]; i <= statues[statues.Length - 1]; i++)
            {
                if (!statues.Contains(i))
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] metroCard(int lastNumberOfDays)
        {
            if (lastNumberOfDays == 28 || lastNumberOfDays == 30 || lastNumberOfDays == 31)
            {
                if (lastNumberOfDays == 28)
                    return new[] { 31 };
                else if (lastNumberOfDays == 30)
                    return new[] { 31 };
                else
                    return new[] { 28, 30, 31 };
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        bool isInfiniteProcess(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else if (a < b && (b - a == 1))
            { return true; }

            else
            { return false; }
        }


    }
}
