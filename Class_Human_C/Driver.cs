﻿using System;

namespace Class_Human_C
{
    internal sealed class Driver : Employee // запретила наследование от этого класса
    {
        public string Brand { get; set; }
        
        public string Model { get; set; }
        
        public Driver() // создала конструктор без параметров
        {
        }
        
        public Driver(Driver previousDriver) // создала конструктор копирования
        {
            Brand = previousDriver.Brand;
            Model = previousDriver.Model;
        }
        
        public Driver(string surname, string name, string patronymic, DateTime  birth, string company, int salary, int experience, string brand, string model)
            : base(surname, name, patronymic, birth, company, salary, experience) // создала конструктор с параметрами
        {
            Brand = brand;
            Model = model;
        }
        
        ~Driver() // создала деструктор
        { 
            Console.WriteLine("Объект {0} уничтожен", Brand);
        }
        
        public override string ToString()
        {
            return $"{Print()}, Возраст: {CalculateAge()}, Компания: {Company}, ЗП: {Salary}, Опыт работы: {Experience}, Бренд: {Brand}, Модель: {Model}";
        }
        
    }
}