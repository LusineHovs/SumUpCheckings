using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Deleveled"));
        }
        public static bool IsPalindrome(string word)
        {
            string temp = word.ToLower();
            string sum = "";
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                sum += temp[i];
            }
            return (sum == temp);
        }
    }
}
