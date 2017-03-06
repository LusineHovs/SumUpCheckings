using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem
{
    interface A
    {
        void Method();
    }
    class B : A
    {
        public int f1;
        private B()
        {

        }
        public B(int f1)
        {
            this.f1 = f1;
        }
        void A.Method()
        {
            throw new NotImplementedException();
        }
        public static IEnumerable M(int a)
        {
             yield return a * 2;
                Console.WriteLine("asd");
            yield return a * 5;
            // return a * 5;
        }
    }
    class C : B
    {
        public C(int f1) : base(f1)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B b1 = new B(12);
            foreach (var item in B.M(12))
            {
                Console.WriteLine(item);
                Console.WriteLine("aaaaa");
            }
            

            Person p1 = new Person();
            Person p2 = new Person("Aram");
            Person p3 = new Person(27);
            p3.SetPersonName("Gvidon");
            Person p4 = new Person("Narek", 26);
            Person p5 = new Person(); //default ctor is called, not the one with optional parameters
            Person p6 = new Person(anotherField: true, age: 55);
           
            Console.ReadKey();
        }
    }

    class Person
    {
        private string name;
        private int age;
        private bool anotherField;
        private static string yardName;
        #region Constructors
        public Person(string name, int age) //master contstructor
        {
            Console.WriteLine("Master Ctor");
            this.name = name;
            if (age < 0) age = 0;
            this.age = age;
        }

        public Person(int age) : this("", age) //when chaining ctors with "this" we put all the work on one ctor - master ctor which will be called firstly, after master will be called the ctor with one parameter
        {
            Console.WriteLine("Ctor with int");
        }

        public Person(string name) : this(name, 0)
        {
            Console.WriteLine("Ctor with string");
        }

        public Person()
        {
            Console.WriteLine("Default ctor");
        }

        public Person(string name = "Babo", int age = 40, bool anotherField = false)
        {
            Console.WriteLine("Ctor with optional parameters");
        }
        #endregion
        static Person()
        {
            Console.WriteLine("Static ctor is the first!");
            yardName = "Masiv";
        }
        public void SetPersonName(string value)
        {
            name = value;
        }
    }
}
