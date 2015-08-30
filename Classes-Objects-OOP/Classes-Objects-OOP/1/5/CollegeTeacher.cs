using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class CollegeTeacher : Teacher
    {
        private string teachCollege;
        public string FirstName;
        public string FamilyName;
        public string TeachCollege
        {
            get { return teachCollege; }
            set { teachCollege = value; }
        }

        public CollegeTeacher(string firstName, string familyName, int workingExperience, string teachSubject, string teachCollege)
            : base(firstName, familyName, workingExperience, teachSubject)
        {
            this.teachCollege = teachCollege;
        }
    }
}