using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Temperature in Celsius °C to convert: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;

            Console.WriteLine();
            Temperature degrees = new Temperature();
            degrees.Degrees = a;
            degrees.ConvertDegrees(a, b);
            Console.WriteLine();
        }
    }
}
