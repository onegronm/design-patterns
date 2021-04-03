using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodCaffeineBeverageDemo
{
    public class Tea : CaffeineBeverage
    {        
        /// <summary>
        /// The brew() method
        /// </summary>
        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        /// <summary>
        /// The addCondiments() method
        /// </summary>
        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
