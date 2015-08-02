using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("{0}", n);
            Console.WriteLine("! = " + Faktoriel(n));
            Console.WriteLine();
        }

        private static int Faktoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Faktoriel(n - 1);
        }
    }
}
