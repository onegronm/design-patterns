using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeMenuItemsDemo
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            // all you have to do is print the entire menu hierarchy by calling print() on the top level menu
            allMenus.print();
        }
    }
}
