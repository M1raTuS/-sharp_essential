using System;

namespace SoftServe
{
    class Program
    {
        static void Main(string[] args)
        {
            PetShop pet = new PetShop();
            try
            {
                pet.AddPet(new Cat("Ralf", "4ewir"));
                pet.AddPet(new Dog("malina", "staff"));
                pet.AddPet(new Cat("Blohastik", "Pers"));
                pet.AddPet(new Cat("rijik", "perevodnyak"));
                pet.AddPet(new Dog("Saymon", "taksa"));

                pet.AddPet(new Dog(Convert.ToInt32("sdf").ToString(), ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            pet.IntroduceAll();

            Console.ReadKey();
        }
    }
}
