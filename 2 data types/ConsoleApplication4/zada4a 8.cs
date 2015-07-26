using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second text ");
            string b = Console.ReadLine();
            Console.WriteLine(a.Contains (b));
        }
    }
}
