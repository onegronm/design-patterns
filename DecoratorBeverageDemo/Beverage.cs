using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo
{
    /// <summary>
    /// The Decorator Pattern attaches additional responsibilites to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// </summary>
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
