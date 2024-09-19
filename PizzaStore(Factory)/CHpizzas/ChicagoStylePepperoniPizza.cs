using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_.CHpizzas
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Black Olives");
            Toppings.Add("Spinach");
            Toppings.Add("Eggplant");
            Toppings.Add("Sliced Pepperoni");
        }

        void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }


}
