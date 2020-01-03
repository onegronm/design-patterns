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
