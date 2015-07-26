using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int result = x % y;
            Console.WriteLine("Result: " + result);
            Console.WriteLine();
        }
    }
}
