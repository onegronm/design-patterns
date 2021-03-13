using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorMenuItemsDemo.Iterators
{
    /// <summary>
    /// Implemention our own iterator since it's not supported by arrays
    /// </summary>
    public class DinerMenuIterator : IEnumerable
    {
        MenuItem[] items;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < items.Length; index++)
            {
                if(items[index] != null)
                    yield return items[index];
            }
        }
    }
}
