using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPizzaStoreDemo.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IVeggies[] createVeggies();
        IPepperoni createPepperoni();
        IClams createClam();
    }
}
