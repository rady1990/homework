using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                PrNumber(num);
                Console.WriteLine();
            }
        }

        private static void PrNumber(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is Even!");
            }
            if (num % 2 == 1)
            {
                Console.WriteLine("The number is Odd!");
            }
        }
    }
}
