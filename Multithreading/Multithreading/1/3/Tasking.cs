using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _3
{
    class Tasking
    {
        public void DoTask1()
        {
            for (int i = 0; i < 25001; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task 1 is waiting for Task 2...");
        }
        public void DoTask2()
        {
            Console.WriteLine();
            Console.WriteLine("Task 2 is start:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            }
        }
        public void DoTask3()
        {
            for (int i = 25000; i < 50001; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Job finnished!");
            Console.WriteLine();
        }
    }
}
