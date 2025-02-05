using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Waiter: Employee
    {
        public Waiter (string name , decimal baseSalary):base(name , baseSalary) { }
        public override decimal CalculateSalary()
        {
            return BaseSalary + 100;
        }
    }
}
