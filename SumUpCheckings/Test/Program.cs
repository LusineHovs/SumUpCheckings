using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
     enum e { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    class Person
    {


        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int g = (int)e.Saturday;
            Console.WriteLine(g);
            //var anthony = new Person("Martial", 21);
            //SendPersonByValue(anthony);
            //anthony.Display();


            //string a = "aaa";
            //string b = a;
            //b.ToUpper();
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //string a = "aaa";
            //string b = a;
            //M(ref a);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            string a1 = "aaa";
            string b1 = a1;
            Console.WriteLine(b1);
            a1 = "xxx";
            Console.WriteLine(b1);


            //string[] a1 = { "aaa", "bbb" };
            //string[] b1 = a1;
            //Console.WriteLine(b1[0]);
            //a1[0] = "xxx";
            //Console.WriteLine(b1[0]);


            int a = 10;
            int b = a;
            Console.WriteLine(b);
            a = 15;
            Console.WriteLine(b);


            int[] c = { 12, 15, 45 };
            var query = from x in c
                        select (x % 2 == 0);

        }
        static void SendPersonByValue(Person p)
        {
            p.age = 100;
            p = new Person("Nikki", 20);
        }

        public static void M(ref string a)
        {
            a = "changed";
        }
    }
}
