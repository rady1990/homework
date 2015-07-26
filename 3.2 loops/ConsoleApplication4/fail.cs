using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N). *

            Console.Write("n = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            decimal factorial2 = 1;
            if (1 < k && k < n)
            {
                do
                {
                    factorial *= n;
                    factorial2 *= k;
                   do
                       n--;
                   while (n==1);
                    do
                    {
                    k--;
                    while (k==1);
                        do k--;
               
                while ((k >=1 ) && (n >=1))
                    Console.WriteLine(" N!/K! = " + (factorial / factorial2));
                         }
                    }               
                    }
                            else (Console.WriteLine ("invalid sintaxis"));
            


        }
    }
    }
}
