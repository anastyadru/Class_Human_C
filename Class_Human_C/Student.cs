using System;

namespace Class_Human_C
{
    public class Student : Human
    {
        public string Faculty;
        public int Course;
        public string Group;

        public Student(string surname, string name, string patronymic, DateTime date, string faculty, int course, string group)
            : base(surname, name, patronymic, date)
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }


    }
}