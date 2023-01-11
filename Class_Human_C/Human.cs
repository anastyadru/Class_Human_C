using System;

namespace Class_Human_C
{
    abstract class Human
    {
        abstract public string Surname { get; set; }
        abstract public string Name { get; set; }
        abstract public string Patronymic { get; set; }
        abstract public DateTime Date { get; set; }

        public Human(string surname, string name, string patronymic, DateTime date) // создала конструктор с параметрами
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;
        }
        public void Print()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}"); 
        }
    }
}