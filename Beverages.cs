using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Beverages:FoodItem
    {
        public Beverages(string name , decimal basePrice ): base(name , basePrice) { }
        public override decimal FinalCalculatedPrice()
        {
            return BasePrice + 2;
        }
    }
}
