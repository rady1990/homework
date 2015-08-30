using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class SchoolTeacher: Teacher
    {
        private string[] teachingClasses = new string[] { "class \"4 A\",", "class \"4 B\",", "class \"5 A\",", "class \"5 B\",", "class \"6 A\"." };

        public SchoolTeacher()
        {
        }

        public void TeachingClasses()
        {
            Console.Write("He/She teaches classes in:");

            for (int i = 0; i < teachingClasses.Length; i++)
            {
                Console.Write(" " + teachingClasses[i]);
            } Console.WriteLine();
        }

        public void EntertainKids()
        {
            Console.WriteLine("This school teacher has to find way to entertain kids!");
        }
    }
}
 
