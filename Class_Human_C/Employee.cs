using System;

namespace Class_Human_C
{
    public class Employee : Human
    {
        public string Company;
        public int Salary;
        public int Experience;

        public Employee(string surname, string name, string patronymic) // создала конструктор без параметров
            : base(surname, name, patronymic)
        {
            Company = " ";
            Salary = 1000;
            Experience = 2;
        }
    }
}