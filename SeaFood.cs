using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class SeaFood:FoodItem
    {
        public SeaFood(string name , decimal basePrice ):base(name , basePrice) { }
        public override decimal FinalCalculatedPrice()
        {
            if(BasePrice > 30)
            {
                return BasePrice * 0.15M;
            }
            return BasePrice;
        }
    }
}
