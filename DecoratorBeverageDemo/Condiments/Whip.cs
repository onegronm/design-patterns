using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo.Condiments
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = GetDescription();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
