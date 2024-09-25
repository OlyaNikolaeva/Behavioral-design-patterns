using PizzaStore_Factory_.CHpizzas;
using PizzaStore_Factory_.factories;
using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_.stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        Pizza? pizza = null;
        IPizzaIngredientFactory ingredientFactory = new Ch
        protected override Pizza? CreatePizza(string item)
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


}
