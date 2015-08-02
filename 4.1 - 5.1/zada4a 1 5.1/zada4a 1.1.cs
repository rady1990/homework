using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the first number:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number:");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Enter the third number:");
                int c = int.Parse(Console.ReadLine());
                Console.Write("The max number is:");
                Console.WriteLine(MaxNumber(MaxNumber(a, b), c));
            }
        }
        private static int MaxNumber(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
    }
}
