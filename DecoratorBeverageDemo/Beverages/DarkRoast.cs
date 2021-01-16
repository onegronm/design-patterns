using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
