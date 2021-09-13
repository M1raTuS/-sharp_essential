namespace Lesson_10._3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly int length;
        private readonly TKey[] key;
        private readonly TValue[] value;

        public int Length
        {
            get
            {
                return length;
            }
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
    }
}
