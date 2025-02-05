using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name , decimal baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
        }
        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"{Name}, Salary: {CalculateSalary():C}");
        }
    }
}
