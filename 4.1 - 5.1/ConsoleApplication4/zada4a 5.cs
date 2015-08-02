using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] Array = new int[n];
            int[] SecondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element of first array: ");
                Array[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element of second array: ");
                SecondArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            bool a = Array.SequenceEqual(SecondArray);
            Console.WriteLine("First array is the same like second array: " + a);
            Console.WriteLine();
                }

            }
        }


  


