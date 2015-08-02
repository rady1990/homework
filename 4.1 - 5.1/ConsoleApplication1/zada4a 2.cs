using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how long array:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine();
            long[] Array = new long[n];
            Array[0] = 1;
            Array[1] = 1;

            for (int i = 2; i < Array.Length; i++)
            {
                Array[i] = Array[i - 1] + Array[i - 2];

            }
            foreach (long element in Array)
            {
                Console.WriteLine(element);

            }
        }
    }
}
