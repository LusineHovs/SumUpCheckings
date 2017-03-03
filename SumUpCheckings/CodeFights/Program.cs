using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(centuryFromYear(2000));
            // Console.WriteLine(checkPalindrome("abba"));
            //int[] a = { 3, 6, -2, -5, 7, 3 };
            //Console.WriteLine(adjacentElementsProduct(a));
            Console.WriteLine(PagesNumberingWithInk(1, 5));
        }
        public static int centuryFromYear(int year)
        {
            int century;
            if (year % 100 == 0)
            {
                century = year / 100;
            }
            else
            {
                century = year / 100 + 1;
            }
            return century;
        }

        public static bool checkPalindrome(string inputString)
        {
            string a = inputString.ToLower();
            string sum = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                sum += a[i];
            }

            return (sum == a);
        }


        public static int adjacentElementsProduct(int[] a)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < a.Length - 1; i++)
            {
                list.Add(a[i] * a[i + 1]);
            }

            int temp = 0;

            if (list.Count == 1)
            {
                return list[0];
            }

            else
            {
                temp = list[0];

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > temp)
                    {
                        temp = list[i];
                    }
                }

                return temp;
            }
        }


        public static int PagesNumberingWithInk(int current, int numberOfDigits)
        {

            if (GetCount(current) > numberOfDigits)
            {
                return 0;
            }

            int pagesNumber = 0;

            int count = GetCount(current);

            numberOfDigits -= count;

            bool isComlete = true;

            while (isComlete)
            {
                current++;

                if (GetCount(current) - numberOfDigits < 0)
                {
                    return pagesNumber;
                }

                pagesNumber++;
            }

            return pagesNumber;

        }


        public static int GetCount(int number)
        {
            // determines the number of digits, ex. 457 has 3 digits
            int counter = 0;

            while (number >= 0)
            {
                counter++;
                number /= 10;
            }

            return counter;
        }

    }
}
