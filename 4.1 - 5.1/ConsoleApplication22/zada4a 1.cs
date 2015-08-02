using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the vallues :");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] % 2 == 0)
                {
                    sum = array[i] + sum;
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}
