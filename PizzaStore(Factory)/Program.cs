using System.Text;
using System.Xml.Linq;
using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }

    public class PizzaStore
    {
        //Передается ссылка.
        SimplePizzaFactory factory;

        //Сохраняет ссылку на фабрику в конструкторе.
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            else if (type.Equals("clam"))
                pizza = new ClamPizza();
            else if (type.Equals("veggie"))
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}
