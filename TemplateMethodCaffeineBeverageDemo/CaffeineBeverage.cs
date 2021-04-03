using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodCaffeineBeverageDemo
{
    public abstract class CaffeineBeverage
    {
        /// <summary>
        /// This is the template method. It serves as a template for an algorithm
        /// </summary>
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }

        public abstract void brew();

        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        
        /// <summary>
        /// Hook method. Subclasses are free to override these BUT DON'T HAVE TO.
        /// </summary>
        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
