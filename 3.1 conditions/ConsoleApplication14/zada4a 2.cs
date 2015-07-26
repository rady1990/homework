using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter points 1 to 9");
            int a = int.Parse(Console.ReadLine());
            if (a <= 3)
            {
                Console.WriteLine("your result is" + (a + 5));
            }
            else if (a >= 4 && a <= 6) 
            {
                Console.WriteLine("your result is" + (a*12));
            }
            else if (a >= 7 && a <= 9)
            {
                Console.WriteLine("your result is" + ((a * 50)/3));
            }
        }
    }
}
