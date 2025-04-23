using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public FullTimeEmployee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string GetInfo() => $"Полный рабочий: {Name}, Зарплата: {Salary}";
        
    }
}
