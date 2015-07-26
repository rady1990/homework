using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        //N!*K!/(N-K)! 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            int sum = n - k;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK *= i;
            }
            Console.WriteLine(factorialN * factorialK / sum); 
        }
        }
    }

