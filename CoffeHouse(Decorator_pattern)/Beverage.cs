using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeHouse_Decorator_pattern_
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        Size size = Size.TALL;
        public string Description = "Unknown beverage";

        public virtual string GetDescription()
        {
            return Description;
        }
        public void SetSize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return this.size;
        }
        public abstract double Cost();
    }
}
