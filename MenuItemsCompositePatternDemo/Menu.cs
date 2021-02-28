using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeMenuItemsDemo
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return menuComponents[i];
        }

        public override string getDescription()
        {
            return description;
        }

        public override void print()
        {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("----------");

            // Implement iterator here
            //IEnumerator<MenuComponent> iterator = menuComponents.iterator();
            //while (iterator.hasNext())
            //{
            //    MenuComponent menuComponent = iterator.MoveNext();
            //    menuComponent.print();
            //}
        }
    }
}
