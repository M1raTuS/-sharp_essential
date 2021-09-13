using System.Collections;
using System.Collections.Generic;

namespace Lesson_14._3
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private readonly int length;
        private readonly TKey[] key;
        private readonly TValue[] value;
        int position = -1;

        public int Length
        {
            get
            { return length; }
        }

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            length = n;
        }

        public void Add(int i, TKey k, TValue v)
        {
            key[i] = k;
            value[i] = v;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + value[index];
                }
                return "Попытка обращения за пределы массива";
            }
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return key[position] + " " + value[position]; }
        }

        object IEnumerator.Current
        {
            get { return key[position] + " " + value[position]; }
        }
    }
}
