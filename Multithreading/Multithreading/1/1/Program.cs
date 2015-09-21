using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread new1 = new Thread(new ThreadStart(new Job().Running));
            Console.WriteLine(new1.Name = "Thread 1 running...");
            new1.Start();
            new1.Join();
            Console.WriteLine("The tread is compleete!");
            Console.WriteLine();

            Thread new2 = new Thread(new ThreadStart(new Job().Running));
            Console.WriteLine(new2.Name = "Thread 2 running...");
            new2.Start();
            new2.Join();
            Console.WriteLine("The tread is compleete!");
            Console.WriteLine();

            Thread new3 = new Thread(new ThreadStart(new Job().Running));
            Console.WriteLine(new3.Name = "Thread 3 running...");
            new3.Start();
            new3.Join();
            Console.WriteLine("The tread is compleete!");
            Console.WriteLine();

            Thread new4 = new Thread(new ThreadStart(new Job().Running));
            Console.WriteLine(new4.Name = "Thread 4 running...");
            new4.Start();
            new4.Join();
            Console.WriteLine("The tread is compleete!");
            Console.WriteLine();

            Thread new5 = new Thread(new ThreadStart(new Job().Running));
            Console.WriteLine(new5.Name = "Thread 5 running...");
            new5.Start();
            new5.Join();
            Console.WriteLine("The tread is compleete!");
            Console.WriteLine();
        }
    }
}
