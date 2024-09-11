using DuckProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck__Strategy_pattern_
{
    public class Squek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squek");
        }
    }
}
