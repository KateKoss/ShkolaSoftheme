using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    class Item<TItem> where TItem : IComparable<TItem>
    {
        public TItem value { get; }
        public Item<TItem> nextItem { get; set; }
        public Item<TItem> previousItem { get; set; }

        public Item(TItem value, Item<TItem> previousItem, Item<TItem> nextItem)
        {
            this.value = value;
            this.previousItem = previousItem;
            this.nextItem = nextItem;
        }

        public bool Equals(TItem compareValue)
        {
            return value.Equals(compareValue);
        }
    }
}
