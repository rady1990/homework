using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi simvol");
            string a = (Console.ReadLine());
            switch (a) 
            {
                case "2" : Console.WriteLine ("kartata e validna");break;
                case "3": Console.WriteLine("kartata e validna"); break;
                case "4": Console.WriteLine("kartata e validna"); break;
                case "5": Console.WriteLine("kartata e validna"); break;
                case "6": Console.WriteLine("kartata e validna"); break;
                case "7": Console.WriteLine("kartata e validna"); break;
                case "8": Console.WriteLine("kartata e validna"); break;
                case "9": Console.WriteLine("kartata e validna"); break;
                case "10": Console.WriteLine("kartata e validna"); break;
                case "a": Console.WriteLine("kartata e validna"); break;
                case "A": Console.WriteLine("kartata e validna"); break;
                case "q": Console.WriteLine("kartata e validna"); break;
                case "Q": Console.WriteLine("kartata e validna"); break;
                case "J": Console.WriteLine("kartata e validna"); break;
                case "j": Console.WriteLine("kartata e validna"); break;
                case "K": Console.WriteLine("kartata e validna"); break;
                case "k": Console.WriteLine("kartata e validna"); break;
                default: Console.WriteLine("invalid card"); break;
            }
            
        }
    }
}
