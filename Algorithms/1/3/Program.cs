using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a text: ");
            string text = Console.ReadLine();
            

            char[] marks = new char[] { '.', ',', '-', '!', '?', '(', ')', '"', ';', ':' };
            string newText = "";
            string[] tempText = text.Split(marks);

            for (int i = 0; i < tempText.Length; i++)
            {
                newText += tempText[i];
            } text = newText;

            string[] words = text.Split(' ');

            Array.Sort<string>(words);

            Console.WriteLine();
            Console.WriteLine("The words in your text in alphabetical order are: ");
            Console.WriteLine();

            for (int i = 0; i < words.Length; i++)
            {
            Console.WriteLine(words[i]);
            } 
            Console.WriteLine();
        }
    }
}
