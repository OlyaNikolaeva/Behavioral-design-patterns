using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_.coffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffe";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
