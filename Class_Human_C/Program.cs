using System;

namespace Class_Human_C
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human ex = new Human("Ivanov", "Ivan", "Ivanovich");
            ex.Print(); // реализовала конструктор с параметрами
            
            Console.ReadLine();
        }

        {
            Employee ex = new Employee();
            ex.Print(); // реализовала конструктор без параметров
            
            Console.ReadLine();
        }
        
        
    }
}

        // {
            // Student_01 = new Student ("developer");
            // Console.WriteLine(O1.GetValue());

            // Student_02 = new Student(01); // скопировала объект
            // Console.WriteLine(O2.GetValue());
            // Console.ReadKey();
            // return 0;
        // }