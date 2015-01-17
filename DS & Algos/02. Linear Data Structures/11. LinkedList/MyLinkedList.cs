using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LinkedList
{/* Implement the data structure linked list. 
  * Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>). 
  * Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
*/
    class MyLinkedList<T>:IEnumerable<T>
        where T : IComparable
    {
        public ListItem<T> FirstElement { get; set; }
        public ListItem<T> LastElement { get; set; }
        
        
        public void Add(T value)
        {
            var newItem = new ListItem<T>(value);
            if (this.FirstElement == null)
            {
                this.FirstElement = newItem;
                this.LastElement = this.FirstElement;
            }
            else
            {
                this.LastElement.NextItem = newItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var item = this.FirstElement;

            while (item!=null)
            {
                yield return item.Value;
                item = item.NextItem;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
