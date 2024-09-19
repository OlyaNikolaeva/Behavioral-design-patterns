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

    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class CheesePizza: Pizza
    {
        
    }

    public class GreekPizza : Pizza
    {

    }

    public class PepperoniPizza : Pizza
    {

    }

    public class ClamiPizza : Pizza
    {

    }

    public class VeggiePizza : Pizza
    {

    }

    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("greek"))
                pizza = new GreekPizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            else if (type.Equals("clam"))
                pizza = new ClamiPizza();
            else if (type.Equals("veggie"))
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}
