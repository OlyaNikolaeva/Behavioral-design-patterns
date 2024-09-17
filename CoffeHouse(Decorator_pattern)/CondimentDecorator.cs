using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
        public Size GetSize()
        {
            return beverage.GetSize();
        }
    }
}
