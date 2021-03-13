using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorMenuItemsDemo.Menus
{
    public interface IMenu
    {
        public IEnumerable createIterator();
    }
}
