using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Pizza: FoodItem
    {
        public int Toppings { get; set;  }
        public Pizza(string name , decimal basePrice , int toppings) : base(name , basePrice) 
        {
            this.Toppings = toppings;
        }
        public override decimal FinalCalculatedPrice()
        {
            return BasePrice + (Toppings * 1);
        }
    }
}
