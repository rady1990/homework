using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symmetric numbers between 10 <> 999 are:");
            Console.WriteLine();

            for (int i = 10; i <= 999; i++)
            {
                FunctionNum(i);
            }
            Console.WriteLine();
            }
        static int FunctionNum(int number)
        {
            if (number < 10 || number > 999)
            {
                Console.WriteLine("The number is out of range!");     
            }
            if (number % 11 == 0 && number < 100)
            {
                Console.WriteLine(number);
            }
            if (number >= 100)
            {
                int firstNumber = number / 100;
                int lastNumber = number % 10;

                if (firstNumber == lastNumber)
                {
                    Console.WriteLine(number);
                }
            }
    }
}
