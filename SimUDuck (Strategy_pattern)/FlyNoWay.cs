using DuckProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck__Strategy_pattern_
{
    public class FlyNoWay : IFlyBehavior
    {
        // Реализация поведения
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
