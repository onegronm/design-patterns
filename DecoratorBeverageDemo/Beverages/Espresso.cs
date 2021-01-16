using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            // we compute the cost of an Espresso. We don't need to worry about adding in condiments in this class
            return 1.99;
        }
    }
}
