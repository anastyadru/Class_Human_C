using System;

namespace Class_Human_C
{
    public class Human
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        // public DateTime Date;

        public Human(string surname, string name, string patronymic) // создала конструктор с параметрами
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            // Date = date;
        }
        public void Print()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}", Surname, Name, Patronymic);
        }
    }
}