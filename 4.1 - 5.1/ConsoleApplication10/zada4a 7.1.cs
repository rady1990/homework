using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[100];

            for (int i = 1; i <= n; i++)
            {
                myArray[i] = i;
            }

            Console.WriteLine();
            Console.WriteLine("Permutations are:");
            Console.WriteLine();

            Permutate(1, n, myArray);
            Console.WriteLine();
        }

        private static void Permutate(int a, int b, int[] nums)
        {
            int temp;

            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                {
                    temp = nums[i];

                    for (int j = i; j > a; j--)
                    {
                        nums[j] = nums[j - 1];
                    }

                    nums[a] = temp;
                    Permutate(a + 1, b, nums);

                    for (int j = a; j < i; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    nums[i] = temp;
                }
            }
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    Console.Write("{0} ", nums[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
