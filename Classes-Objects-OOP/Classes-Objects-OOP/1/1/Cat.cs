﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Cat
    {  private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Cat()
        {
        }

        public void allCat()
        {
            Console.WriteLine("The cat {0} is {1} years old.", name, age);
        }
    }
    }

