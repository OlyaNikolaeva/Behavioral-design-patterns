using PizzaStore_Factory_.NYpizzas;
using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(String item)
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


}
