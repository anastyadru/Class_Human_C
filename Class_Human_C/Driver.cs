using System;

namespace Class_Human_C
{
    sealed class Driver : Employee // запретила наследование от этого класса
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Driver(string surname, string name, string patronymic, DateTime date, string company, int salary, int experience, string brand, string model)
            : base(surname, name, patronymic, date, company, salary, experience)
        {
            Brand = brand;
            Model = model;
        }
    }
}