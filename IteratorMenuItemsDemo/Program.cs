using IteratorMenuItemsDemo.Menus;
using System;
using System.Collections.Generic;

namespace IteratorMenuItemsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMenu> menus = new List<IMenu>(){
                new PancakeHouseMenu(), new DinerMenu()
            };

            Waitress waitress = new Waitress(menus);
            waitress.printMenu();

            Console.Read();
        }
    }
}
