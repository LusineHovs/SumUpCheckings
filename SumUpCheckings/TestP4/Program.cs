using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestP4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b =Method(15, 17, 5);
            Console.WriteLine(b);
        }
        public static int Method(int a, int k, int p)
        {
            int count = 0;
            if (a-k>=0)
            {
                return -1;
            }
            else
            {
                count++;
                while (k - a <= p)
                {
                    count++;
                    p = p - k - a;
                }
                return count;
            }
        }
    }
}
