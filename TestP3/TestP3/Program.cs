using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            while (++i <= 10)
            {
                j++;
            }
            Console.WriteLine(i + " " + j);
        }
    }
}
