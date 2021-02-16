using AbstractFactoryPizzaStoreDemo.Ingredients;
using AbstractFactoryPizzaStoreDemo.Ingredients.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        /// <summary>
        /// This subclass handles object instantiation for us in the createPizza() method
        /// Encapsulates all the knowledge about how to make Chicago style pizzas
        /// </summary>
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
                new ChicagoPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza.");
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("Chicago Style Veggie Pizza.");
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza.");
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("Chicago Style Pepperoni Pizza.");
            }
            return pizza;
        }
    }
}