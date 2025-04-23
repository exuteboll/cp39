using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Contractor : IEmployee
    {
        public string Name { get; set; }
        public string ContractDetails { get; set; }

        public Contractor(string name, string contractDetails)
        {
            Name = name;
            ContractDetails = contractDetails;
        }

        public string GetInfo() => $"Подрядчик: {Name}, контракт: {ContractDetails}";
    }
}
