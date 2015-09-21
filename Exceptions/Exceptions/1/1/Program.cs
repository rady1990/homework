using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string news = null;
            ReadFile("newspaper.txt");
            WriteFile("br.txt", news);
        }

        static void ReadFile(string filename)
        {
            using (StreamReader read = new StreamReader(filename))
            {
                string text = read.ReadToEnd();

                Console.WriteLine("New level for our social politic is:");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
            }
        }

        static void WriteFile(string filename, string news)
        {
            using (StreamWriter write = new StreamWriter(filename))
            {
                news = "Gypsies emigrated to Germany and the state continues to pay them social benefits!";
                write.Write(news);

                Console.WriteLine(news);
                Console.WriteLine();
            }
        }
    }
}