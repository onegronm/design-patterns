using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo
{
    /// <summary>
    /// Abstract decorator. First we need to be interchangeable with a Beverage so we extend the Beverage class
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public override double Cost()
        {
            throw new NotImplementedException();
        }

        public abstract string GetDescription();
    }
}
