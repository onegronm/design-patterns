using AbstractFactoryPizzaStoreDemo.Ingredients;
using System;

namespace FactoryPizzaStoreDemo
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory factory)
        {
            this.ingredientFactory = factory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + getName());
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}