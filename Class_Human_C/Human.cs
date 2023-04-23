using System;

namespace Class_Human_C
{
    public abstract class Human // запретила возможность создавать класс, только наследников
    {
        public abstract string Surname { get; set; }
        
        public abstract string Name { get; set; }
        
        public abstract string Patronymic { get; set; }
        
        public abstract DateTime BirthDate { get; set; }
        
        protected Human() // создала конструктор без параметров
        {
        }
        
        protected Human(Human previousHuman) // создала конструктор копирования
        {
            Surname = previousHuman.Surname;
            Name = previousHuman.Name;
            Patronymic = previousHuman.Patronymic;
            BirthDate = previousHuman.BirthDate;
        }
        
        protected Human(string surname, string name, string patronymic, DateTime birth) // создала конструктор с параметрами
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birth;
        }

        ~Human() // создала деструктор
        {
            Console.WriteLine("Объект {0} уничтожен", Surname);
        }

        public virtual int CalculateAge() // высчитала возраст на данный момент
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        protected virtual void Print()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}");
        }

    }
}