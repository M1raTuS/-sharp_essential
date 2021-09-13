namespace Lesson_4._1
{
    abstract class Part
    {

        protected string content; //доступ к этому полю можно получить только из кода в том же классе, либо в производном классе
        abstract public string Content { get; set; } //абстрактное свойство
        abstract public void Show(); //абстрактный метод
    }
}
