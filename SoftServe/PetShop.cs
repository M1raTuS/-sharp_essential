using System.Collections.Generic;

namespace SoftServe
{
    public class PetShop
    {
        List<Animal> list = new List<Animal>();

        public void AddPet(Animal animal)
        {
            list.Add(animal);
        }

        public void IntroduceAll()
        {
            foreach (var q in list)
            {
                q.Introduce();
            }
        }
    }
}
