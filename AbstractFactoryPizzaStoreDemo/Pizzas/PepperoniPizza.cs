using AbstractFactoryPizzaStoreDemo.Ingredients;
using System;

namespace FactoryPizzaStoreDemo
{
    public class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory factory)
        {
            this.ingredientFactory = factory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + getName());
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            pepperoni = ingredientFactory.createPepperoni();
        }
    }
}