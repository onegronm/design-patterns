using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo
{
    /// <summary>
    /// Factory method:
    /// handles object creating and encapsulates it in a subclass. This decouples the client code in the superclass from the object creation code in the subclass.
    /// </summary>
    public abstract class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public PizzaStore()
        {

        }

        public IPizza orderPizza(string type)
        {
            IPizza pizza;

            pizza = createPizza(type); // createPizza() is a method in the PizzaStore

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        /// <summary>
        /// We've moved factory object to this method. Our factory method is now abstract in PizzaStore
        /// Each PizzaStore provides an implemenation of the createPizza() method overriding this abstract method. 
        /// All responsibility for instantiating Pizzas has been moved into a method that acts as a factory
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract IPizza createPizza(string type);
    }
}
