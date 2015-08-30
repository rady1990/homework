using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimensions of the triangle`s cathetus:");
            Triangle triangle = new Triangle();
            triangle.Hypotenuse();
            triangle.Angles();
            Console.WriteLine();
        }
    }
}
