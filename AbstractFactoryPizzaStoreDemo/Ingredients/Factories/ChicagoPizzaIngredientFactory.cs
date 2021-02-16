using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizzaStoreDemo.Ingredients.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }

        public IClams createClam()
        {
            return new FreshClams();
        }

        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] createVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
