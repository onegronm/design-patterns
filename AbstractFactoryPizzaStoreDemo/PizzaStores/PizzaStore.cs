using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo
{
    /// <summary>
    /// Factory method:
    /// defines an interface for creating an object, but lets subclasses decide which class to instantiate
    /// Factory Method lets a class defer instantiation to subclasses
    /// This decouples the client code in the superclass from the object creation code in the subclass
    /// </summary>
    public abstract class PizzaStore // the abstract creator
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public PizzaStore()
        {

        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza;

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
        public abstract Pizza createPizza(string type);
    }
}
