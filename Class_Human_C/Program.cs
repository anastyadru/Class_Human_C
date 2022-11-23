using System;

namespace Class_Human_C
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human ivan = new Human("Ivanov", "Ivan", "Ivanovich", 01.01.2001); 
            ivan.Print(); // реализовала конструктор с параметрами

            Console.ReadLine();
        }

        {
            Student_01 = new Student ("developer");
            Console.WriteLine(O1.GetValue());

            Student_02 = new Student(01); // скопировала объект
            Console.WriteLine(O2.GetValue());
            Console.ReadKey();
            return 0;
        }

        {
            var employee = new Employee();
            Console.WriteLine($"Company:{employee.company}, Salary{employee.salary}, Experience{employee.experience}");
        }
    }
}