using System;

namespace Class_Human_C
{
    public class Student : Human
    {
        string Faculty { get; set; }
        int Course { get; set; }
        string Group { get; set; }

        public Student(string surname, string name, string patronymic, DateTime date, string faculty, int course, string group)
            : base(surname, name, patronymic, date)
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        public override void Print()
        {
            Console.WriteLine();
        }
    }
}