using IteratorMenuItemsDemo.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorMenuItemsDemo
{
    public class Waitress
    {
        List<IMenu> menus;

        public Waitress(List<IMenu> menus) // IMenu pancakeHouseMenu, IMenu dinerMenu
        {
            this.menus = menus;
        }

        public void printMenu()
        {
            /*
             * Can we manage these together?
             */
            //IEnumerable dinerIterator = dinerMenu.createIterator();
            //IEnumerable pancakeIterator = pancakeHouseMenu.createIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            foreach (var menu in menus)
                printMenu(menu.createIterator());

            //Console.WriteLine("MENU\n----\nBREAKFAST");
            //printMenu(pancakeIterator);
            //Console.WriteLine("\nLUNCH");
            //printMenu(dinerIterator);
        }

        private void printMenu(IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                MenuItem menuItem = (MenuItem)item;
                Console.Write(menuItem.getName() + ", ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
            }
        }
    }
}
