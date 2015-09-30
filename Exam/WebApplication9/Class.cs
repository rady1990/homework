using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9
{
    public class Countries
    {

        private string capital;
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private long cityzens;
        public long Cityzens
        {
            get { return Cityzens; }
            set { Cityzens = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.capital, this.country, this.Cityzens);
        }
    }
}