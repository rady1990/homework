using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Press a number a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Press a number b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Press a number c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int result1 = Multi(a, b, c);
                Console.Write("The result is");
                Console.WriteLine(result1);
                Console.WriteLine();
            }
        }
        private static int Multi(int num, int num1, int num2)
        {
            int result = num * num1 * num2;
            return result;
        }
        }
    }

