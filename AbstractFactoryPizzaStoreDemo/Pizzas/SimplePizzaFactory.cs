using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo
{
    /// <summary>
    /// Encapsulates the object creation of all pizzas
    /// </summary>
    public class SimplePizzaFactory // (static factory if made static)
    {
        /// <summary>
        /// Defining a simple factory as a static method is a common technique and is often called a static factory
        /// The benefit is you don't need to instantiate an object to make use of the method.
        /// However, as static, you cant subclass and change the behavior of the create method
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IPizza createPizza(string type)
        {
            IPizza pizza = null;

            //switch (type)
            //{
            //    case "cheese":
            //        pizza = new CheesePizza();
            //        break;
            //    case "pepperoni":
            //        pizza = new PepperoniPizza();
            //        break;
            //    case "clam":
            //        pizza = new ClamPizza();
            //        break;
            //    case "veggie":
            //        pizza = new VeggiePizza();
            //        break;
            //}

            return pizza;
        }
    }
}
