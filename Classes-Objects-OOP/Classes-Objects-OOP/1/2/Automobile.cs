using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Automobile : Car
    {
        
        private float fuel;
        public float Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public Automobile(int price, float fuel)
            : base(price)
        {
            this.fuel = fuel;
        }

        public string FuelCon { get; set; }
    }
    }
