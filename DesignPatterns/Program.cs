using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // The strategy pattern defines a family of algorithms,
            // encapsulates each one, and makes them interchangeable.
            // Strategy lets the algorithm vary independently from 
            // clients that use it.

            Duck mallard = new MallardDuck();

            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();

            model.performFly();

            model.setFlyBehavior(new FlyRocketPowered());

            model.performFly();

            Console.Read();
        }
    }
}
