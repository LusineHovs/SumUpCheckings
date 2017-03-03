using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable h = new Hashtable();
            ArrayList ar = new ArrayList();
            ar.Add("asd");
            ar.Add(1525);
            ar.Add(12.56);
            Queue q = new Queue();
            q.Enqueue("asd");
            q.Dequeue();


            List<int> list = new List<int>();
            list.Insert(0, 10);

            Stack<int> stack = new Stack<int>();
            stack.Push(124);
            stack.Push(58354);
            stack.Push(3547554);
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            int[,] array = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }



            int[][] jagged = new int[5][];
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new int[i + 7];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
