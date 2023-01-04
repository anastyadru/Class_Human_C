using System;

namespace Class_Human_C
{
    public class Human
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
        public virtual void Print()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}", Surname, Name, Patronymic, Date);
        }
    }
}