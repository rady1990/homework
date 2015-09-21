using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The process has started:");
            Console.WriteLine();
            ThreadPool.SetMaxThreads(7, 5);
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new
                    WaitCallback(PrintThreads));
            }
            Console.WriteLine("Press Enter for program end!");
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void PrintThreads(object aParam)
        {
            Random rand = new Random();
            Thread.CurrentThread.Name = Convert.ToString(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("Thread {0} is running...", Thread.CurrentThread.Name);
            Thread.Sleep(rand.Next(1000, 10000));
            Console.WriteLine("Thread {0} complete!", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
