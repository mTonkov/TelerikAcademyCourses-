using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedList
{
    class ListItem<T>
    {
        private T itemValue;
        private ListItem<T> nextItem;

        public ListItem(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get { return this.itemValue; }
            set { this.itemValue = value; }
        }

        public ListItem<T> NextItem
        {
            get { return this.nextItem; }
            set { this.nextItem = value; }
        }
    }
}
