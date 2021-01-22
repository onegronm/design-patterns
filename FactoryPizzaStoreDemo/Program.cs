using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPizzaStoreDemo.PizzaStores;

namespace FactoryPizzaStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore myPizzaStore = new NYPizzaStore();
            myPizzaStore.orderPizza("cheese");
        }
    }
}
