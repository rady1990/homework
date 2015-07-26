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
            Console.WriteLine("To input integer enter 1");
            Console.WriteLine("To input double enter 2");
            Console.WriteLine("To input string enter 3");

            Console.WriteLine();
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter integer: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (a + 1));
                    break;
                case 2:
                    Console.Write("Enter double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (b + 1));
                    break;
                case 3:
                    Console.Write("Enter string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Result: " + c + "*");
                    break;
                default:  Console.WriteLine("Int , double and string"); break;
            } Console.WriteLine();

        }
    }
}
