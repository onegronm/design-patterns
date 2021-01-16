using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo.Condiments
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = GetDescription();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }
}
