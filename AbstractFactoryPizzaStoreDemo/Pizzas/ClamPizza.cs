using AbstractFactoryPizzaStoreDemo.Ingredients;
using System;

namespace FactoryPizzaStoreDemo
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory factory)
        {
            this.ingredientFactory = factory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + getName());
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClam();
        }
    }
}