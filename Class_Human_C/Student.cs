using System;

namespace Class_Human_C
{
    public class Student : Human
    {
        public string Faculty { get; set; }
        
        public int Course { get; set; }
        
        public int Group { get; set; }
        
        public Student() // создала конструктор без параметров
        {
        }
        
        public Student(Student previousStudent) // создала конструктор копирования
        {
            Faculty = previousStudent.Faculty;
            Course = previousStudent.Course;
            Group = previousStudent.Group;
        }
        
        public Student(string surname, string name, string patronymic, DateTime birth, string faculty, int course, int group)
            : base(surname, name, patronymic, birth) // создала конструктор с параметрами
        {
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        ~Student() // создала деструктор
        {
            Console.WriteLine("Объект {0} уничтожен", Faculty);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Faculty}, {Course}, {Group}";
        }
        
    }
}

