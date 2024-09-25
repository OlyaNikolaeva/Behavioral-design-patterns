using PizzaStore_Factory_.factories;
using PizzaStore_Factory_.NYpizzas;
using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_.stores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string item)
        {
            Pizza? pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Pepperoni Pizza");
            }
            return pizza;
        }
    }


}
