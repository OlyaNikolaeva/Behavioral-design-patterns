using System.Text;
using System.Xml.Linq;

namespace PizzaStore_Factory_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public abstract class Pizza
    {
        string? Name;
        string? Dough;
        string? Sauce;
        List<string> Toppings = new List<string>();

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
