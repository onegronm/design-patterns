using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeMenuItemsDemo
{
    public class MenuItem : MenuComponent
    {
        string name;
        string description;
        bool vegetarian;
        double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.vegetarian = vegetarian;
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override double getPrice()
        {
            return price;
        }

        public override bool isVegetarian()
        {
            return vegetarian;
        }

        public override void print()
        {
            Console.Write(" " + getName());
            if (isVegetarian())
            {
                Console.Write("(v)");
            }
            Console.Write(", " + getPrice());
            Console.Write("    -- " + getDescription());
        }
    }
}
