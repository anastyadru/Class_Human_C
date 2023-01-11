using System;

namespace Class_Human_C
{
    public abstract class Human
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public DateTime Date;

        public Human(string surname, string name, string patronymic, DateTime date) // создала конструктор с параметрами
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;
        }

        public abstract void Print();
    }
}