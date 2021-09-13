namespace Lesson_10._4
{
    public class MyList<T>
    {
        private readonly int length;
        private readonly T[] arr;



        public int Length
        {
            get
            {
                return length;
            }
        }
        public MyList(int n)
        {
            arr = new T[n];
            length = arr.Length;
        }

        public T this[int i]
        {
            get
            {
                return arr[i];
            }
        }
        public void Add(int i, T k)
        {
            arr[i] = k;
        }
    }
}