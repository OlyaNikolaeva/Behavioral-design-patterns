using DuckProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck__Strategy_pattern_
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackDuck();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
