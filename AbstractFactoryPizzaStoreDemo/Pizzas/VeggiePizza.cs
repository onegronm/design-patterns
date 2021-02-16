using AbstractFactoryPizzaStoreDemo.Ingredients;
using System;

namespace FactoryPizzaStoreDemo
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory factory)
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