using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Chef:Employee
    {
        public Chef(string name ,  decimal baseSalary) : base(name , baseSalary) { }
        public override decimal CalculateSalary()
        {
            return BaseSalary * 0.15M;
        }
    }
}
