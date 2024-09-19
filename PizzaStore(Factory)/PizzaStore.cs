using PizzaStore_Factory_.pizzas;

namespace PizzaStore_Factory_
{
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
        protected abstract Pizza? CreatePizza(string type);
    }


}
