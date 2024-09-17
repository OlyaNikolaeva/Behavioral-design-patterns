using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_.coffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
