using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeMenuItemsDemo
{
    /*
     * The composite pattern allows us to build structures of objects in the form of trees that contain both compositions of objects and individual objects as nodes.
     * Using a composite structure, we can apply the same operations over both composites and individual objects, ignoring the differences between composites and individual objects.
     */
    public abstract class MenuComponent
    {
        #region composite methods
        public virtual void add (MenuComponent menuComponent){
            throw new InvalidOperationException();
        }

        public virtual void remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent getChild(int i)
        {
            throw new InvalidOperationException();
        }
        #endregion

        #region operation methods
        public virtual string getName()
        {
            throw new InvalidOperationException();
        }

        public virtual string getDescription()
        {
            throw new InvalidOperationException();
        }

        public virtual double getPrice()
        {
            throw new InvalidOperationException();
        }

        public virtual bool isVegetarian()
        {
            throw new InvalidOperationException();
        }

        public virtual void print()
        {
            throw new InvalidOperationException();
        }
        #endregion
    }
}
