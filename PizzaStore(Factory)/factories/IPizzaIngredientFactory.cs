using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
