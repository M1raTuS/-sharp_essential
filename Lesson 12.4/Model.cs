//Model

namespace Lesson_12._4
{
    class Model
    {
        public string Add(int a, int b)
        {
            return (a + b).ToString();
        }
        public string Sub(int a, int b)
        {
            return (a - b).ToString();
        }
        public string Mul(int a, int b)
        {
            return (a * b).ToString();
        }
        public string Div(int a, int b)
        {
            if (b != 0)
                return ((double)a / b).ToString();
            return "На нoль делить нельзя";
        }
    }
}
