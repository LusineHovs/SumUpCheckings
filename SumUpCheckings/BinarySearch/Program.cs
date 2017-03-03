using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("acorn");      // 0
            l.Add("apple");      // 1
            l.Add("banana");     // 2
            l.Add("cantaloupe"); // 3
            l.Add("lettuce");    // 4
            l.Add("onion");      // 5
            l.Add("peach");      // 6
            l.Add("pepper");     // 7
            l.Add("squash");     // 8
            l.Add("tangerine");  // 9

            int i = l.BinarySearch("onion");
            Console.WriteLine(i);

        }
    }
}
