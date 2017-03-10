using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous types are only "placeholders", it can contain only Properties//
            var anonymtype = new { Team = "MicArmenia", Duration = 15 };
        }
    }
}
