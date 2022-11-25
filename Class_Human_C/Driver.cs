using System;

namespace Class_Human_C
{
    sealed class Driver : Employee // запретила наследование от этого класса
    {
        public string Brand;
        public string Model;

        public Driver(string surname, string name, string patronymic, string brand, string model)
            : base(surname, name, patronymic)
        {
            Brand = brand;
            Model = model;
        }
        
        ~Driver() // создала деструктор
        {
            Console.WriteLine("Объекты {0}, {1} уничтожены", Brand, Model);
        }
        
        public void ObjectGenerator(string Brand, string Model)
        {
            Driver ob = new Driver(Surname, Name, Patronymic, Brand, Model);
        }
    }
}