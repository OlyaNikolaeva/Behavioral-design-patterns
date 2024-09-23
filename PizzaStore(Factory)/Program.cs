using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza? pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

        }
    }

    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClaim()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }

    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public IVeggies[] CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClams CreateClaim();
    }

    public class ThinCrustDough : IDough
    {
        public String ToString()
        {
            return "Thin Crust Dough";
        }
    }

    public class MarinaraSauce : ISauce
    {
        public String ToString()
        {
            return "Marinara Sauce";
        }
    }

    public class ReggianoCheese : ICheese
    {
        public String ToString()
        {
            return "Reggiano Cheese";
        }
    }

    public class SlicedPepperoni : IPepperoni
    {
        public String ToString()
        {
            return "Sliced Pepperoni";
        }
    }

    public class FreshClams : IClams
    {
        public String ToString()
        {
            return "Fresh Clams from Long Island Sound";
        }
    }
    public class Garlic : IVeggies
    {
        public String ToString()
        {
            return "Garlic";
        }
    }

    public class Onion : IVeggies
    {
        public String ToString()
        {
            return "Onion";
        }
    }

    public class Mushroom : IVeggies
    {
        public String ToString()
        {
            return "Mashroom";
        }
    }

    public class RedPepper : IVeggies
    {
        public String ToString()
        {
            return "Red pepper";
        }
    }

    public interface IDough
    {
        public string ToString();
    }
    public interface ISauce
    {
        public string ToString();
    }
    public interface ICheese
    {
        public string ToString();
    }
    public interface IVeggies
    {
        public string ToString();
    }
    public interface IPepperoni
    {
        public string ToString();
    }
    public interface IClams
    {
        public string ToString();
    }
}
