using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello world";
            Console.WriteLine("Enter text ");
            string b = (Console.ReadLine());
            Console.WriteLine("result is ", (a == b));

        }
    }
}
