using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
                        List<int> sequence = new List<int>();

            string line;

            while (true)
            {
                line = Console.ReadLine();
                int number;

                if (int.TryParse(line, out number))
                {
                    sequence.Add(number);
                }
                else if (line == "")
                {
                    break;
                }
            }

            Console.WriteLine(sequence.Sum());
            Console.WriteLine(sequence.Average());


          
            Console.WriteLine();
        }
    }
}
