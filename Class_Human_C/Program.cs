using System;

namespace Class_Human_C
{
    public class Program
    {
        static void Main(string[] args)

        {
            DateTime date = new DateTime(2000, 1, 1);
            Employee ex = new Employee("Ivanov", "Ivan", "Ivanovich", 01.01.2000);
            ex.Print(); // реализовала конструктор без параметров
        }

        {
            string Brand = "BMW";
            Driver obj = new Driver("Ivanov", "Ivan", "Ivanovich", 01.01,"BMW","x5");
            obj.Print();
        }
        
    }
}

// DateTime nowDate = DateTime.Today; - возможность получить количество полных лет
// int age = nowDate.Year - new DateTime;
// if (new DateTime > nowDate.AddYears(-age))
// age--;

        