using System;

namespace Class_Human_C
{
    public class Human
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public DateTime Date;

        public Human(string surname, string name, string patronymic, DateTime date)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;
        }
        public void Print()
        {
            Console.WriteLine("Фамилия: {surname}\nИмя: {name}\nОтчество: {patronymic}\Дата рождения: {date}\"Surname, Name, Patronymic, Date);
        }
    }
}