namespace Lesson_5._1
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] value1 = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; value1[0] = "kniga";
            key[1] = "ручка"; value[1] = "pen"; value1[1] = "ry4ka";
            key[2] = "солнце"; value[2] = "sun"; value1[2] = "solnce";
            key[3] = "яблоко"; value[3] = "apple"; value1[3] = "yabloko";
            key[4] = "стол"; value[4] = "table"; value1[4] = "stol";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + " - " + value1[i];
                    if (value[i] == index)
                        return value[i] + " - " + key[i] + " - " + value1[i];
                    if (value1[i] == index)
                        return value1[i] + " - " + key[i] + " - " + value[i];
                }
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + value1[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

    }
}
