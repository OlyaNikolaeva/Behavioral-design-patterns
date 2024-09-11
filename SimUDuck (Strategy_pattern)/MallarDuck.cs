using DuckProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck__Strategy_pattern_
{
    public class MallarDuck : Duck
    {
        public MallarDuck()
        {
            quackBehavior = new QuackDuck();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallar duck");
        }
    }
}
