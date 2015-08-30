using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Triangle
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public void Hypotenuse()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            this.a = A;
            this.b = B;

            this.c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine();
            Console.WriteLine("Length of the hypotenuse: {0}", Math.Round(c, 1));
            Console.WriteLine();
        }
        public void Angles()
        {
            a = Math.Asin(b / c) * 180 / Math.PI;
            b = 90 - a;

            Console.WriteLine("Angles value: alpha: {0} / beta: {1}", Math.Round(a, 1), Math.Round(b, 1));
        }
    }
}