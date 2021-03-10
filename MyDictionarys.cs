using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionarys<T,X>
    {
        T[] keys;
        X[] values;
        T[] geciciKeys;
        X[] geciciValues;
        public MyDictionarys()
        {
            keys = new T[0];
            values = new X[0];
        }
        public void Add(T key,X value)
        {
            geciciKeys = keys;
            keys = new T[keys.Length + 1];
            geciciValues = values;
            values = new X[values.Length + 1];
            for (int i = 0; i < geciciKeys.Length; i++)
            {
                keys[i] = geciciKeys[i];
                values[i] = geciciValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }
        }
        public T[] Keys
        {
            get { return keys; }
        }
        public X[] Values
        {
            get { return values; }
        }

    }
}
