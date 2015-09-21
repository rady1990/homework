using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> temp = new Dictionary<int, string>();
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            Console.WriteLine("Write your text: ");
            string text = Console.ReadLine();

            int key = 0;
            int occurrences = 0;
            char[] marks = new char[] { '.', ',', ' ','!', '?' };
            string[] split = text.Split(marks);

            foreach (string item in split)
            {
                key += 1;
                temp.Add(key, item);

                if (item == "")
                {
                    temp.Remove(key);
                    key--;
                }
            }

            foreach (var item in temp)
            {
                occurrences = 1;

                if (uniqueWords.ContainsKey(item.Value))
                {
                    uniqueWords.Remove(item.Value);
                    occurrences++;
                    uniqueWords.Add(item.Value, occurrences);
                }
                else
                {
                    uniqueWords.Add(item.Value, occurrences);
                }
                Console.WriteLine();
                Console.WriteLine("The unique words in your text are: ");
                Console.WriteLine();

                foreach (var item in uniqueWords)
                {
                    if (item.Value == 1)
                    {
                        Console.Write(item.Key + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}