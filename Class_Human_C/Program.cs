using System;

namespace Class_Human_C
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 01, 01);
            Human ex = new Human("Ivanov", "Ivan", "Ivanovich", 01.01.2000);
            ex.Print(); // реализовала конструктор с параметрами
            
            // DateTime nowDate = DateTime.Today; - возможность получить количество полных лет
            // int age = nowDate.Year - new DateTime;
            // if (new DateTime > nowDate.AddYears(-age))
            // age--;
            
            Console.ReadLine();
        }

        {
            Employee ex = new Employee();
            ex.Print(); // реализовала конструктор без параметров
            
            Console.ReadLine();
        }

        {
            string Brand = "BMW";
            Driver obj = new Driver();
            
            Console.WriteLine("\nКонец");

            Console.ReadLine();
        }
        
        {
            Student o1 = new Student ("Developer");
            Console.WriteLine(o1.GetValue());

            Student o2 = new Student(o1); // скопировала объект
            Console.WriteLine(o2.GetValue());
            Console.ReadKey();
            return 0;
        }
    }
}

//

        