using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    class DoublyLinkedList<TItem> where TItem : IComparable<TItem>
    {
        private Item<TItem> currentElement;
        private Item<TItem> head;
        private int size;
        public DoublyLinkedList(TItem value)
        {
            head = new Item<TItem>(value, null, null);
            size = 1;
        }

        public void InsertTail(TItem value)
        {
            if (head.nextItem != null)
            {
                currentElement = head.nextItem;
                while (currentElement.nextItem != null)
                {
                    currentElement = currentElement.nextItem;
                }
                currentElement.nextItem = new Item<TItem>(value, currentElement, null);
            }
            else
            {
                head.nextItem = new Item<TItem>(value, head.nextItem, null);
            }
            size++;
        }

        public void InsertHead(TItem value)
        {
            var newHead = new Item<TItem>(value, null, head);
            head = newHead;
            size++;
        }

        public void DeleteTail()
        {
            if (head != null)
            {
                currentElement = head.nextItem;
                while (currentElement.nextItem != null)
                {
                    currentElement = currentElement.nextItem;
                }
                currentElement = null;
                size--;
            }
            else
            {
                throw new InvalidOperationException("Could not delete non-existent list item.", null);
            }
        }

        public void DeleteHead()
        {
            head = head.nextItem;
            head.previousItem = null;
            size--;
        }

        public bool Contains(TItem value)
        {
            if (head.Equals(value))
            {
                return true;
            }
            else
            {
                currentElement = head.nextItem;
                while (currentElement != null)
                {
                    if (currentElement.value.Equals(value))
                    {
                        return true;
                    }
                    currentElement = currentElement.nextItem;
                }
            }
            return false;
        }

        public int GetListSize()
        {
            return size;
        }

        public TItem[] ToArray()
        {
            var resultArray = new TItem[size];
            currentElement = head;
            resultArray[0] = currentElement.value;
            for (int i = 1; i < size; i++)
            {
                currentElement = currentElement.nextItem;
                resultArray[i] = currentElement.value;
            }
            return resultArray;
        }
    }
}
