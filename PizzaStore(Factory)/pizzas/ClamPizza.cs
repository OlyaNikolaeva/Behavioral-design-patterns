using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_Factory_.pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Thin crust";
            Sauce = "White garlic sauce";
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
