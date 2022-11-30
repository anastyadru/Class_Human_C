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
        public void Print()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}", Surname, Name, Patronymic, Date);
        }
    }
}

// static int FullYears(DateTime dt1, DateTime dt2) - возможность получить количество полных лет
// {
    // if (dt2.Year <= dt1.Year)
       // return 0;
    // int n = dt2.Year - dt1.Year;
    // if (dt1.DayOfYear > dt2.DayOfYear)
       // --n;
    // return n;
// }