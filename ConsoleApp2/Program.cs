using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            while (true)
            {
                Console.WriteLine("\nВведите команду:");
                Console.WriteLine("1 - Добавить сотрудника");
                Console.WriteLine("2 - Удалить сотрудника");
                Console.WriteLine("3 - Показать всех сотрудников");
                Console.WriteLine("4 - Выйти");

                string command = Console.ReadLine();

                if (command == "1")
                {
                    
                    Console.WriteLine("Выберите тип сотрудника:");
                    Console.WriteLine("1 - Полный");
                    Console.WriteLine("2 - Неполный");
                    Console.WriteLine("3 - Подрядчик");

                    string type = Console.ReadLine();
                    IEmployee newEmployee = null;

                    Console.WriteLine("Введите имя сотрудника:");
                    string name = Console.ReadLine();

                    if (type == "1")
                    {
                        Console.WriteLine("Введите зарплату сотрудника:");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        newEmployee = new FullTimeEmployee(name, salary);
                    }
                    else if (type == "2")
                    {
                        Console.WriteLine("Введите почасовую ставку сотрудника:");
                        double hourlyRate = Convert.ToDouble(Console.ReadLine());
                        newEmployee = new PartTimeEmployee(name, hourlyRate);
                    }
                    else if (type == "3")
                    {
                        Console.WriteLine("Введите детали контракта сотрудника:");
                        string contractDetails = Console.ReadLine();
                        newEmployee = new Contractor(name, contractDetails);
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                        continue;
                    }

                    company.AddEmployee(newEmployee);
                }
                else if (command == "2")
                {
                   
                    Console.WriteLine("Введите имя сотрудника для удаления:");
                    string nameToRemove = Console.ReadLine();
                    IEmployee employeeToRemove = null;

                    foreach (var employee in company.employees)
                    {
                        if (employee is FullTimeEmployee fullTime && fullTime.Name == nameToRemove)
                        {
                            employeeToRemove = fullTime;
                            break;
                        }
                        else if (employee is PartTimeEmployee partTime && partTime.Name == nameToRemove)
                        {
                            employeeToRemove = partTime;
                            break;
                        }
                        else if (employee is Contractor contractor && contractor.Name == nameToRemove)
                        {
                            employeeToRemove = contractor;
                            break;
                        }
                    }

                    if (employeeToRemove != null)
                    {
                        company.RemoveEmployee(employeeToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Сотрудник не найден.");
                    }
                }
                else if (command == "3")
                {
                    
                    company.DisplayAllEmployees();
                }
                else if (command == "4")
                {
                   
                    Console.WriteLine("Выход из программы...");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверная команда.");
                }
            }
        }
            
        

        
    }
}
