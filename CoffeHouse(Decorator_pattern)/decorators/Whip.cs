using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_.decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            double cost = beverage.Cost();
            if (beverage.GetSize() == Size.TALL)
                cost += .5;
            if (beverage.GetSize() == Size.GRANDE)
                cost += .10;
            if (beverage.GetSize() == Size.VENTI)
                cost += .15;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
