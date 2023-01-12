using System;

namespace Class_Human_C
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 1, 1);
            Employee obj = new Employee("Ivanov", "Ivan", "Ivanovich", Convert.ToDateTime("02.02.2020"));
            obj.Print(); // реализовала конструктор без параметров
        }

        {
            Driver obj = new Driver("Ivanov", "Ivan", "Ivanovich", 02.02,"BMW","x5");
            obj.Print();
        }
        
    }
}

        