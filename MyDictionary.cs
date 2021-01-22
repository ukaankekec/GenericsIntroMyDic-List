using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{

    public class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            // contsructor function starts when the class calls
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {

            // a control that the new key is in existing keys or not
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    throw new ArgumentException("can not be used the same key on an another key!!");
                }
            }

            // we're creating new temporary arrays, because when we expand length of the arrays we miss the values that the arrays have
            TKey[] tempKey = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            // we're giving the values to arrays back
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];

            }
            // arrays get the new values
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void WriteLine()
        {

            // Foreach loop is not working in this situation
            int i = 0;
            while (i<keys.Length)
            {
                Console.WriteLine($"[{keys[i]},{values[i]}]");
                i++;
            }
        }
    }

}