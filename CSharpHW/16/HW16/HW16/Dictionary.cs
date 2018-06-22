using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class Dictionary<TKey, TValue>
    {
        private DictionaryItem<TKey, TValue>[] dictionaryItems;
        private int size;
        public Dictionary()
        {
            
        }

        public void Add(TKey key, TValue value)
        {
            try
            {
                if (size == 0)
                {
                    dictionaryItems = new DictionaryItem<TKey, TValue>[1];
                }
                else if (GetIndex(key) < 0 && size > 0)
                {
                    var tmpArr = dictionaryItems;
                    dictionaryItems = new DictionaryItem<TKey, TValue>[size + 1];
                    Array.Copy(tmpArr, 0, dictionaryItems, 1, tmpArr.Length);
                }
                else
                {
                    throw new InvalidOperationException("Such key already exists.", null);
                }
                dictionaryItems[0] = new DictionaryItem<TKey, TValue>(key, value);
                size++;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Could not add.", ex);
            }
        }

        public void Remove(TKey key)
        {
            try
            {
                int keyIndex = GetIndex(key);
                var tmpArr = dictionaryItems;
                dictionaryItems = new DictionaryItem<TKey, TValue>[size - 1];
                Array.Copy(tmpArr, 0, dictionaryItems, 0, keyIndex);
                Array.Copy(tmpArr, keyIndex + 1, dictionaryItems, keyIndex, tmpArr.Length - keyIndex - 1);
                size--;
            }
            catch (InvalidOperationException ex)
            {
                new InvalidOperationException("Could not delete.", ex);
            }
        }

        private int GetIndex(TKey key)
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Dictionary is empty.", null);
            }
            for (int i = 0; i < size; i++)
            {
                if (dictionaryItems[i].key.Equals(key))
                {
                    return i;
                }

            }
            return -1;
        }

        override
        public string ToString()
        {
            var str = string.Empty;
            for (int i = 0; i < dictionaryItems.Length; i++)
            {
                str += string.Format($"Key: { dictionaryItems[i].key.ToString() } Value: { dictionaryItems[i].value.ToString() } \n");
            }
            return str;
        }
    }
}
