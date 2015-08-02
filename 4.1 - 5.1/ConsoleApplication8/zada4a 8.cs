using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[n, n];

            int row = 0;
            int col = 0;
            int Numbers = n * n;
            string direction = "right";

            for (int i = 1; i <= Numbers; i++)
            {
                if (direction == "right" && (col > n - 1 || myMatrix[col, row] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || myMatrix[col, row] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || myMatrix[col, row] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || myMatrix[col, row] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                myMatrix[col, row] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your matrix is : ");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myMatrix[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
