using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo.PizzaStores.Chicago
{
    /// <summary>
    /// Encapsulates all the knowledge about how to make Chicago style pizzas
    /// </summary>
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            if (type == "cheese")
                return new ChicagoStyleCheesePizza();
            else return null;
        }
    }
}
