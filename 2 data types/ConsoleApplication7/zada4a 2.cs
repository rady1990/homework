﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Result is: ");
            Console.WriteLine(c);
        }
    }
}
