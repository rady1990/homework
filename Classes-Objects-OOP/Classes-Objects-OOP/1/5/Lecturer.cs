using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Lecturer : Person
    {
        private string university;

        public string University
        {
            get { return university; }
            set { university = value; }
        }
        public Lecturer()
        {
        }
        public Lecturer(string name, string lastName, int workExperience, string university)
            : base(name, lastName, workExperience)
        {
            this.university = university;
            Console.WriteLine("Fist, Last name: {0}, {1} \nExperience in years: {2} \nUniversity: {3}",
                                                            name, lastName, workExperience, university);

        }
        public virtual void Checkss()
        {
            Console.WriteLine("Ability to check homeworks");
        }
        public void GoodDay()
        {
            Console.WriteLine("Good Day!");
        }
        private int lecturesNum;

        public int LecturesNum
        {
            get { return lecturesNum; }
            set { lecturesNum = value; }
        }
        public void Lectures()
        {
            this.lecturesNum = 10;
            Console.WriteLine("Number of lectures per week: {0}", lecturesNum);
            ObCount++;
        }
    }
}
