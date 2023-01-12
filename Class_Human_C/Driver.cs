using System;

namespace Class_Human_C
{
    sealed class Driver : Employee // запретила наследование от этого класса
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Driver(string surname, string name, string patronymic, DateTime date, string brand, string model)
            : base(surname, name, patronymic, date)
        {
            Brand = brand;
            Model = model;
        }

        ~Driver() // создала деструктор
        { 
            Console.WriteLine("Объекты {0}, {1} уничтожены", Brand, Model);
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine();
        }
    }
}