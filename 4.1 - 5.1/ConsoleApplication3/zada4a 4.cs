using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            Console.WriteLine("The numbers of array are: 2, 4, 6, 8, 10, 12, 14, 16, 18, 20");
            Console.WriteLine();
            Console.Write("Choose number :");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == n)
            Console.WriteLine("The index is " + i);
            }

        }
    }
}
