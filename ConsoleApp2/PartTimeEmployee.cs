using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }

        public PartTimeEmployee(string name, double hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }

        public string GetInfo() => $"Неполный рабочий день: {Name}, Почасовая ставка: {HourlyRate}";

    }
}
