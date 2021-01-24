using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo
{
    public abstract class Pizza : IPizza
    {
        public string name { get; set; }
        public string dough { get; set; }
        public string sauce { get; set; }

        public List<string> toppings = new List<string>();

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public virtual void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }
    }
}
