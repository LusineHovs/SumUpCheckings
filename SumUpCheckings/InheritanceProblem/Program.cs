using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProblem
{
    public class TextInput
    {
        string s = "";
        public virtual void Add(char c)
        {

            s += c;
        }
        public virtual string GetValue()
        {
            return s;

        }
    }
    public class NumericInput : TextInput
    {
        string s1 = "";
        public override void Add(char c)
        {
            char[] a = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < a.Length; i++)
            {
                if (c == a[i])
                {
                    s1 += c;
                }
            }
        }


        public override string GetValue()
        {
            return s1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}
