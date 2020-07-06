namespace SoftServe
{
    class Cat : Animal
    {
        public Cat(string name, string breed) : base(name, breed)
        {

        }

        protected override string GetAnimalType()
        {
            return GetType().Name.ToString();
        }

    }
}
