using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = (Console.ReadLine());
            string text = (Console.ReadLine());
            

            Console.WriteLine();
            Console.WriteLine("Times that your word occures: {0} times", CountStringOccurrences(text, word));
            Console.WriteLine();
        }

        public static int CountStringOccurrences(string text, string word)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            return count;
        }
    }
}
