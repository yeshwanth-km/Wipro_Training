using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoVarience_ContraVarience
{
    public class Animal
    {
        public virtual Animal CreateAnimal()
        {
            Console.WriteLine("Generic animal created");
            return new Animal();
        }

        public void DisplayAnimal(Animal animal)
        {
            Console.WriteLine($"Displaying {animal.GetType().Name}");
        }
    }

    public class PetDog : Animal
    {
        public PetDog CreateDog()
        {
            Console.WriteLine("Specific dog breed created");
            return new PetDog();
        }

        public void DisplayDogDetails(PetDog dog)
        {
            Console.WriteLine($"Dog details: {dog.GetType().Name}");
        }
    }

    public class AnimalShelter
    {
        // Covariant method to create an animal
        public virtual Animal CreateAnimal()
        {
            Console.WriteLine("Generic animal created in shelter");
            return new Animal();
        }

        // Contravariant method to display an animal
        public void DisplayAnimal(Animal animal)
        {
            Console.WriteLine($"Displaying animal in shelter: {animal.GetType().Name}");
        }
    }
}
