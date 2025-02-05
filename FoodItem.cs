using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class FoodItem
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        
        public FoodItem(string name , decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public virtual decimal FinalCalculatedPrice()
        {
            return BasePrice;
        }
        public virtual void DisplayDetails ()
        {
            Console.WriteLine($"Name: {Name} , Final-Price: {FinalCalculatedPrice() :C} ");
        }
    }
}
