using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1
{
    class Job
    {
        internal void Running()
        {
            Random rand = new Random();
            Thread.Sleep(rand.Next(1000, 10000));
        }
    }
}
