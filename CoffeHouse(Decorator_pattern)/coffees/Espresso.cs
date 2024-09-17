using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_.coffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
