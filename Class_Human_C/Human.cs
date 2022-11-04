using System;

namespace Class_Human_C
{
    public class Human
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime Date { get; set; }

        public Human(string surname, string name, string patronymic, DateTime date)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;
        }
        public void Print()
        {
            Console.WriteLine(Surname, Name, Patronymic, Date);
        }
    }
}