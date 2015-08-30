using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Person
    {
        private string name;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string lastName;

        protected string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int workExperience;

        protected int WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }
        protected Person()
        {
        }
        protected Person(string name, string lastName, int workExperience)
        {
            this.name = name;
            this.lastName = lastName;
            this.workExperience = workExperience;
        }
        static int obC;

        public static int ObCount
        {
            get { return Person.obC; }
            set { Person.obC = value; }
        }
        public void Counter(int objectCount)
        {
            ObCount = 0;
        }

        internal static string GetPersonCount()
        {
            throw new NotImplementedException();
        }
    }
}