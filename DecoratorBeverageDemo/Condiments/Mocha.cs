using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo.Condiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage; // an instance variable to hold the beverage we are wrapping

        // pass beverage we are wrapping to the decorator's constructor
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = GetDescription();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
