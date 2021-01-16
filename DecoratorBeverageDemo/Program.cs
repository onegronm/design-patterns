using DecoratorBeverageDemo.Beverages;
using DecoratorBeverageDemo.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();

            Console.WriteLine(beverage.GetDescription() + ": " + beverage.Cost().ToString());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage2.GetDescription() + ": " + beverage2.Cost().ToString());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);

            Console.WriteLine(beverage3.GetDescription() + ": " + beverage3.Cost().ToString());

            Console.ReadKey();
        }
    }
}
