using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Factory_.pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Crust";
            Sauce = "Marinara sauce";
            Toppings.Add("Shredded mozzarella");
            Toppings.Add("Grated parmesan");
            Toppings.Add("Diced onion");
            Toppings.Add("Sliced mushrooms");
            Toppings.Add("Sliced red pepper");
            Toppings.Add("Sliced black olives");
        }
    }
}
