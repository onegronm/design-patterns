using AbstractFactoryPizzaStoreDemo.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPizzaStoreDemo
{
    public abstract class Pizza : IPizza
    {
        private string name;

        public IDough dough { get; set; }
        public ISauce sauce { get; set; }
        public IVeggies veggies { get; set; }
        public ICheese cheese { get; set; }
        public IPepperoni pepperoni { get; set; }
        public IClams clam { get; set; }

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

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public abstract void prepare();
    }
}
