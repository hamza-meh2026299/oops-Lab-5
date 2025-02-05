using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class FastFood: FoodItem
    {
        public FastFood(string name , decimal basePrice):base(name , basePrice) { }

        public override decimal FinalCalculatedPrice()
        {
            return BasePrice * 0.9M ;
        }
    }
}
