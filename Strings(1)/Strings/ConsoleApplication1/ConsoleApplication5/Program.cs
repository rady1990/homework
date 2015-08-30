using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a mathematical expression: ");
            string mathExpr = Console.ReadLine();

            bool correct = true;
            int open = 0;
            int close = 0;

            for (int i = 0; i < mathExpr.Length; i++)
            {
                char symbol = mathExpr[i];

                if (symbol == '(')
                {
                    open++;
                }
                else if (symbol == ')')
                {
                    close++;

                    if (close > open)
                    {
                        correct = false;
                        break;
                    }
                }
                else if (symbol == mathExpr.Length - 1 && (close == open))
                {
                    correct = true;
                }
            }
            Console.WriteLine("Your mathematical expression has correct brackets: " + correct);
            Console.WriteLine();
        }
    }
}
