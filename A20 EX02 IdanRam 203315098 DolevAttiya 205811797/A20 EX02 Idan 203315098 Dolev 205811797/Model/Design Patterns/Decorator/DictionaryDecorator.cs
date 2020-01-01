using System;
using System.Collections;
using System.Collections.Generic;

namespace A20_EX02_Idan_203315098_Dolev_205811797.Model.Design_Patterns.Decorator
{
    public class DictionaryDecorator<TK, TV> : IDictionary<TK, TV>
    {
        // The array of items
        protected readonly IDictionary<TK, TV> r_Dictionary;

        // Construct the SimpleDictionary with the desired number of items.
        // The number of items cannot change for the life time of this SimpleDictionary.
        public DictionaryDecorator(IDictionary<TK, TV> i_Dictionary)
        {
            r_Dictionary = i_Dictionary;
        }

        public IEnumerator<KeyValuePair<TK, TV>> GetEnumerator()
        {
            return r_Dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)r_Dictionary).GetEnumerator();
        }

        public void Add(KeyValuePair<TK, TV> i_Item)
        {
            r_Dictionary.Add(i_Item.Key, i_Item.Value);
        }

        public void Clear()
        {
            r_Dictionary.Clear();
        }

        public bool Contains(KeyValuePair<TK, TV> i_Item)
        {
            return r_Dictionary.Contains(i_Item);
        }

        public void CopyTo(KeyValuePair<TK, TV>[] i_Array, int i_ArrayIndex)
        {
            if(i_Array.Length - i_ArrayIndex < r_Dictionary.Count)
            {
                throw new IndexOutOfRangeException("Not enough place");
            }

            foreach(KeyValuePair<TK, TV> item in r_Dictionary)
            {
                i_Array[i_ArrayIndex++] = item;
            }
        }

        public bool Remove(KeyValuePair<TK, TV> i_Item)
        {
            return r_Dictionary.Remove(i_Item.Key);
        }

        public int Count => r_Dictionary.Count;

        public bool IsReadOnly => false;

        public bool ContainsKey(TK i_Key)
        {
            return r_Dictionary.ContainsKey(i_Key);
        }

        public void Add(TK i_Key, TV i_Value)
        {
            r_Dictionary.Add(i_Key, i_Value);
        }

        public bool Remove(TK i_Key)
        {
            return r_Dictionary.Remove(i_Key);
        }

        public bool TryGetValue(TK i_Key, out TV i_Value)
        {
            return r_Dictionary.TryGetValue(i_Key, out i_Value);
        }

        public TV this[TK i_Key]
        {
            get => r_Dictionary[i_Key];
            set => r_Dictionary[i_Key] = value;
        }
        
        public ICollection<TK> Keys => r_Dictionary.Keys;

        public ICollection<TV> Values => r_Dictionary.Values;
    }
}