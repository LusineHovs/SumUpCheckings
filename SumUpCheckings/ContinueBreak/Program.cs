using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueBreak
{
    class Program
    {
        static void Main(string[] args)
        {

            Method(5);
        }
        public static void Method(int a)
        {
            for (int i = 0; i < a; i++)
            {
                if (i >= 2)
                    continue;
            }
        }
    }
}
