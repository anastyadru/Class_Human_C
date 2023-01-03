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
            Console.WriteLine($"Компания: {Company}\n Зарплата: {Salary}\n Опыт: {Experience}");
        }
    }
}

//