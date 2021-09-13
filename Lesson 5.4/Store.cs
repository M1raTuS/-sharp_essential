using System;

namespace Lesson_5._4
{
    class Store
    {
        private Article[] article;
        public Store(int size)
        {
            article = new Article[size];
        }

        public void AddArticle(Article article, int index)
        {
            if (index >= 0 && index < this.article.Length)
                this.article[index] = article;
            else
                Console.WriteLine("Попытка записи за пределами массива.");
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < article.Length)
                    return article[index].Info();
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

        public string this[string index] //Перегрузка индексатора
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                    if (article[i] != null && article[i].productName == index)
                        return article[i].Info();

                return string.Format("\"{0}\" нет в наличии.", index);
            }
        }

        public void Show()
        {

            for (int i = 0; i < article.Length; i++)
                if (article[i] != null)
                    Console.WriteLine(article[i].Info());
        }
    }
}
