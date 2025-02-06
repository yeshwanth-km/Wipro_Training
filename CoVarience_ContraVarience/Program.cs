using CoVarience_ContraVarience;

namespace CoVarience_ContraVarience
{
    // Covariant delegate (return type)
    delegate Animal GetAnimalDelegate();

    // Contravariant delegate (parameter type)
    delegate void ProcessPetDelegate(PetDog dog);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Shelter Demo");

            AnimalShelter shelter = new AnimalShelter();
            GetAnimalDelegate getAnimal = shelter.CreateAnimal;

            // Covariance demonstration
            PetDog dogHandler = new PetDog();
            getAnimal = dogHandler.CreateDog;  // Derived type assignment

            Animal newAnimal = getAnimal();
            Console.WriteLine($"Created: {newAnimal.GetType().Name}");

            // Contravariance demonstration
            ProcessPetDelegate processPet = shelter.DisplayAnimal;
            processPet += dogHandler.DisplayDogDetails;

            PetDog myDog = new PetDog();
            processPet(myDog);  // Accepts base type where derived expected
        }
    }


}

