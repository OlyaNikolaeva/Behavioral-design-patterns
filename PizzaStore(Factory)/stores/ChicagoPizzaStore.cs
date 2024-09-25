using PizzaStore_Factory_.factories;
using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_.stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        Pizza? pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        protected override Pizza? CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chigago Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chigago Style Veggie Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chigago Style Clam Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chigago Style Pepperoni Pizza");
            }
            return pizza;
        }
    }


}
