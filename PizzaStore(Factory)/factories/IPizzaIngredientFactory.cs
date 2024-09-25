using PizzaStore_Factory_.ingredients.interfaces;

namespace PizzaStore_Factory_.factories
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public IVeggies[] CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClams CreateClaim();
    }
}
