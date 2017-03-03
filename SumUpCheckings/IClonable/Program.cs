using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    class Program
    public class Point : ICloneable
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}", X, Y);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Point p1 = new Point(100, 100);
        //Point p2 = (Point)p1.Clone();

        int? x = null;
        Console.WriteLine(x.HasValue);
    }
}
