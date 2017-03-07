using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodefightsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 6, 2, 3, 8 };
            //Console.WriteLine(makeArrayConsecutive2(a));
            //Console.WriteLine(String.CompareOrdinal("Barev", "Barek"));
            Console.WriteLine(isMAC48Address("00-1B-63-84-45-E6"));
        }
        public static int rectangleRotation(int a, int b)
        {
            // if (a > 2 && b > 2)
            // {
            //     return ((a - 1) * (b - 1) + (a - 2) * (b - 2));
            // }
            // if (a > 2 && b == 2)
            // {
            //     return ((a - 1) * b + (a - 2));
            // }
            // if (a == 2 && b > 2)
            // {
            //     return ((b - 1) * a + (b - 2));
            // }
            //else if (a == 2 && b == 2)
            // {
            //     return a * b + 1;
            // }

            var r = 0;
            for (var x = -a - b; x <= a + b; x++)
            {
                for (var y = -a - b; y <= a + b; y++)
                {
                    if (2 * (x - y) * (x - y) <= a * a && 2 * (x + y) * (x + y) <= b * b) r++;
                }
            }
            return r;

        }
        // int[] a = { 6, 2, 3, 8 };

        public static int makeArrayConsecutive2(int[] statues)
        {
            int count = 0;
            Array.Sort(statues);
            for (int i = statues[0]; i <= statues[statues.Length - 1]; i++)
            {
                if (!statues.Contains(i))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool isMAC48Address(string inputString)
        {
            if (inputString.Length != 17)
            {
                return false;
            }
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            for (int i = 0; i < inputString.Length; i++)
            {
                if (arr.Contains(inputString[i]) && i % 3 != 2)
                {
                    continue;
                }
                else
                {
                    if (!(i % 3 == 2 && inputString[i] == '-'))
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public static bool isUnstablePair(string filename1, string filename2)
        {
            return Math.Sign(String.Compare(filename1, filename2, StringComparison.OrdinalIgnoreCase)) != Math.Sign(String.Compare(filename1, filename2, StringComparison.Ordinal));
        }

       
    }
}
