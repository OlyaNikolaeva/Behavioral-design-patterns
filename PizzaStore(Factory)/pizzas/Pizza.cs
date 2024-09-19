using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Factory_.pizzas
{
    public abstract class Pizza
    {
        public string? Name;
        public string? Dough;
        public string? Sauce;
        public List<string> Toppings = new List<string>();

        public string? GetName()
        {
            return Name;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + Name);
        }

        public string Display()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + Name + " ----\n");
            display.Append(Dough + "\n");
            display.Append(Sauce + "\n");
            foreach (string topping in Toppings)
            {
                display.Append(topping + "\n");
            }
            return display.ToString();
        }
    }
}
