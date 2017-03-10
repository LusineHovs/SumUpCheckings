using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTryParse
{
  
    class Program
    {
        static void Main(string[] args)
        {
            //Parse
            string s = "45";
            int i = int.Parse(s);

            //TryParse
            int i1;
            bool i2 = int.TryParse(s, out i1);
            Console.WriteLine(i1);
        }
    }
}
