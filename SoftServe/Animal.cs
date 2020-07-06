using System;

namespace SoftServe
{
    public abstract class Animal
    {
        private string Name, Breed;
        protected abstract string GetAnimalType();

        public Animal(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Introduce()
        {
            Console.WriteLine($"I’m {Name} of {Breed}.I’m a {GetAnimalType()}");
        }
    }
}
