using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore_Factory_.pizzas
{
    public abstract class Pizza
    {
        public string? Name;
        public string? Dough;
        public string? Sauce;
        public List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Prepare " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string? GetName()
        {
            return Name;
        }
    }
}
