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
        public IDough? Dough;
        public ISauce? Sauce;
        public IVeggies[]? Veggies;
        public ICheese? Cheese;
        public IPepperoni? Pepperoni;
        public IClams? Clams;

        public abstract void Prepare();

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

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string ToString()
        {
            return "";
        }
    }
}
