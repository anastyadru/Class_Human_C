using System;

namespace Class_Human_C
{
    public class Employee : Human
    {
        public string Company;
        public int Salary;
        public int Experience;

        public Employee(string surname, string name, string patronymic, DateTime date) // создала конструктор без параметров
            : base(surname, name, patronymic, date)
        {
            Company = " ";
            Salary = 1000;
            Experience = 2;
        }
        public override void Print()
        {
            Console.WriteLine($"Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nКомпания: {Company}\nЗарплата: {Salary}\nОпыт: {Experience}");
        }
    }
}