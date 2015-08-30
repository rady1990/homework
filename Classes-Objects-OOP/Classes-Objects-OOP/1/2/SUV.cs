﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class SUV:Car
    {
        private bool highRoad;
        public bool HighRoad
        {
            get { return highRoad; }
            set { highRoad = value; }
        }

        public SUV(int price, bool highRoad)
            : base(price)
        {
            this.highRoad = highRoad;
        }
    }
}
