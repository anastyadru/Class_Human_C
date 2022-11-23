using System;

namespace Class_Human_C
{
    public class Employee : Human
    {
        public string Company;
        public int Salary;
        public int Experience;

        public Employee(string surname, string name, string patronymic, DateTime date, string company, int salary, int experience)
            : base(surname, name, patronymic, date)
        {
            Company = company;
            Salary = salary;
            Experience = experience;
        }
    }
}