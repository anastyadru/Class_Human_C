using System;

namespace Class_Human_C
{
    public class Student : Human
    {
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }

        public Student(string surname, string name, string patronymic, DateTime date, string faculty, int course, string group)
            : base(surname, name, patronymic, date)
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine();
        }
    }
}