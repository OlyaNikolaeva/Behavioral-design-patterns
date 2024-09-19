using PizzaStore_Factory_.NYpizzas;
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

    public abstract class PizzaStore
    {
        // Все субклассы используют метод.
        public Pizza? OrderPizza(string type)
        {
            Pizza? pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        //Каждый субкласс переопределяет метод.
        public abstract Pizza? CreatePizza(string type);
    }

    public class NYPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            return null;
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza? CreatePizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            return null;
        }
    }


    public class SimplePizzaFactory
    {
        public Pizza? CreatePizza(string type)
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
