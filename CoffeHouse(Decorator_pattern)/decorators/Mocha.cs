using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_.decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            double cost = beverage.Cost();
            if (beverage.GetSize() == Size.TALL)
                cost += .15;
            if (beverage.GetSize() == Size.GRANDE)
                cost += .20;
            if (beverage.GetSize() == Size.VENTI)
                cost += .25;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
