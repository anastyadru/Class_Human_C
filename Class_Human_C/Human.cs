using System;

namespace Class_Human_C
{
    public abstract class Human // запретила возможность создавать класс, только наследников
    {
        protected abstract string Surname { get; set; }
        protected abstract string Name { get; set; }
        protected abstract string Patronymic { get; set; }
        protected abstract DateTime Date { get; set; }

        protected Human(string surname, string name, string patronymic, DateTime date) // создала конструктор с параметрами
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;
        }
        public virtual void Print()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}");
        }
    }
}