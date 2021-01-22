using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        /// <summary>
        /// This subclass handles object instantiation for us in the createPizza() method
        /// </summary>
        public override IPizza createPizza(string type)
        {
            if (type == "cheese")
                return new NYStyleCheesePizza();
            else if (type == "veggie")
                return new NYStyleVeggiePizza();
            else if (type == "clam")
                return new NYStyleClamPizza();
            else if (type == "pepperoni")
                return new NYStylePepperoniPizza();
            else return null;
        }
    }
}
