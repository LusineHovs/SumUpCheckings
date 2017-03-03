using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestP2
{
    class Program
    {
        public static int M(int num)
        {
            string a = num.ToString();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '4' || a[i] == '6' || a[i] == '9')
                {
                    ++count;
                }
                if (a[i] == '8')
                {
                    count += 2;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(M(869));
        }
    }
}
