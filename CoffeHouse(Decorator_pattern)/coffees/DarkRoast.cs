using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_.coffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffe";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
