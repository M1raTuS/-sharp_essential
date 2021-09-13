namespace Lesson_10._4
{
    static class ExtensionMyList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
