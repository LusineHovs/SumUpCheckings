using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    class Element
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Element(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
    class A
    {
        //in case of private, must implement IEnumerable, IEnumerator interfaces
        public Element[] arr = new Element[2];
        public A()
        {
            arr[0] = new Element(17, "Lus");
            arr[1] = new Element(18, "Lu");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            foreach (var item in a.arr)
            {
                Console.WriteLine(item.Name, item.Age);
            }
        }
    }
}
