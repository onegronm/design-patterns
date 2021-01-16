using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
