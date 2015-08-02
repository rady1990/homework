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
                 int n = int.Parse(Console.ReadLine());
                 int[] myArray = new int[n];

            int count = 0;
            int currentIndex = 0;

            if (n > 0 && n <= 100)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("Enter next element: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                } 
                    Console.WriteLine();

                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] == myArray[currentIndex])
                    {
                        count++;
                    }
                    if (n == 1)
                    {
                        currentIndex = i;
                        count = 1;
                    }
                }
                Console.WriteLine("The element is " + myArray[currentIndex] + " and occurs " + count + " times.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Enter other length!");
                Console.WriteLine();
            }   
         }
                    
       }  
    }
            

