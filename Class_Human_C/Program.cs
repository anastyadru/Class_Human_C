using System;
using System.Collections.Generic;

namespace Class_Human_C
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Human> people = new List<Human>();
        
            Console.Write("Выберите, какое действие хотите выполнить:\n1) Добавить \n2) Изменить \n3) Удалить \nВаше решение: ");
            var action = int.Parse(Console.ReadLine());
            
            switch (action)
            {
            
            }
        }
        
        
        
        
        {
            Console.WriteLine("Введите фамилию: ");
            var surname = Console.ReadLine();
            
            Console.WriteLine("Введите имя: ");
            var name = Console.ReadLine();
            
            Console.WriteLine("Введите отчество: ");
            var patronymic = Console.ReadLine();
            
            Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ: ");
            var birth = Convert.ToDateTime(Console.ReadLine());
            
            List<Human> people = new List<Human>();

            Console.Write("Выберите, кого добавить:\n1) student \n2) employee \n3) driver \nВаше решение: ");
            var a = int.Parse(Console.ReadLine());
            
            switch (a)
            {
                case 1:
                    Console.Write("Введите факультет");
                    var faculty = Console.ReadLine();

                    Console.Write("Введите курс");
                    var course = int.Parse(Console.ReadLine());

                    Console.Write("Введите группу");
                    var group = int.Parse(Console.ReadLine());

                    Student student = new Student(surname, name, patronymic, birth, faculty, course, group);

                    people.Add(student);

                    break;

                case 2:
                    Console.Write("Введите название компании");
                    var company = Console.ReadLine();

                    Console.Write("Введите заработную плату");
                    var salary = int.Parse(Console.ReadLine());

                    Console.Write("Введите опыт работы");
                    var experience = int.Parse(Console.ReadLine());

                    Employee employee = new Employee(surname, name, patronymic, birth, company, salary, experience);

                    people.Add(employee);
                    
                    break;

                case 3:
                    Console.Write("Введите название компании");
                    var company = Console.ReadLine();

                    Console.Write("Введите заработную плату");
                    var salary = int.Parse(Console.ReadLine());

                    Console.Write("Введите опыт работы");
                    var experience = int.Parse(Console.ReadLine());

                    Console.Write("Введите бренд");
                    var brand = Console.ReadLine();

                    Console.Write("Введите модель");
                    var model = Console.ReadLine();

                    Driver driver = new Driver(surname, name, patronymic, birth, company, salary, experience, brand, model);
                    
                    people.Add(driver);
                    
                    break;
            }

            for (var i = 0; i < people.Count; i++) // вывела на экран список людей и их индексы в списке
            {
                Console.WriteLine($"{i}. {people[i].Surname} ({people[i].BirthDate} лет)");
            }
            
            Console.Write("Введите номер человека, чьи данные Вы хотите изменить или удалить: ");
            var index = int.Parse(Console.ReadLine());
            
            Console.Write("Выберите, что вы хотите изменить:\n1) Фамилию \n2) Имя \n3) Отчество \n4) Дату рождения" +
                          "\n5) Факультет \n6) Курс \n7) Группу \n8) Компанию \n9) Заработную плату" +
                          "\n10) Опыт работы \n11) Бренд \n12) Модель \n13) Ничего не меняем \nВаше решение: ");
            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите новую фамилию: ");
                    people[index].Surname = Console.ReadLine();
                    break;
                
                case 2:
                    Console.Write("Введите новое имя: ");
                    people[index].Name = Console.ReadLine();
                    break;
                
                case 3:
                    Console.Write("Введите новое отчество: ");
                    people[index].Patronymic = Console.ReadLine();
                    break;
                
                case 4:
                    Console.Write("Введите новую дату рождения в формате ДД.ММ.ГГГГ: ");
                    people[index].BirthDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                
                case 5:
                    Console.Write("Введите новый факультет: ");
                    people[index].Faculty = Console.ReadLine();
                    break;
                
                case 6:
                    Console.Write("Введите новый курс: ");
                    people[index].Course = int.Parse(Console.ReadLine());
                    break;
                
                case 7:
                    Console.Write("Введите новую группу: ");
                    people[index].Group = int.Parse(Console.ReadLine());
                    break;
                
                case 8:
                    Console.Write("Введите новое название компании: ");
                    people[index].Company = Console.ReadLine();
                    break;
                
                case 9:
                    Console.Write("Введите новую заработную плату: ");
                    people[index].Salary = int.Parse(Console.ReadLine());
                    break;
                
                case 10:
                    Console.Write("Введите новый опыт работы: ");
                    people[index].Experience = int.Parse(Console.ReadLine());
                    break;
                
                case 11:
                    Console.Write("Введите новое название бренда: ");
                    people[index].Brand = Console.ReadLine();
                    break;
                
                case 12:
                    Console.Write("Введите новую модель: ");
                    people[index].Model = Console.ReadLine();
                    break;
                
                case 13:
                    // Ничего не меняем;
                    ;
                    break;
            }

            if (index >= 0 && index < people.Count) 
            {
                people.RemoveAt(index);
                Console.WriteLine("Информация о человеке успешно удалена!");
            } 
            
            else 
            {
                Console.WriteLine("Некорректный индекс");
            }
        }
        
    }
}

