namespace SoftServe
{
    class Dog : Animal
    {
        public Dog(string name, string breed) : base(name, breed)
        {
        }

        protected override string GetAnimalType()
        {
            return GetType().Name.ToString();
        }
    }
}
