using Playground.Shared.Domain;

namespace Playground.Protocol
{
    /// <summary>
    /// Messages relating to AnimalActor.
    /// </summary>
    public static class AnimalProtocol
    {
        public abstract class AnimalMessage
        {
            public abstract string AnimalName { get; }
        }

        public class AddAnimal : AnimalMessage
        {
            public override string AnimalName { get; }
            public string Species { get; }

            public AddAnimal(string animalName, string species)
            {
                AnimalName = animalName;
                Species = species;
            }
        }

        public abstract class AnimalCreationResponseMessage : AnimalMessage
        {
        }

        public class FindAnimal : AnimalMessage
        {
            public FindAnimal(string animalName)
            {
                AnimalName = animalName;
            }

            public override string AnimalName { get; }
        }

        public abstract class FindAnimalResponseMessage : AnimalMessage
        {
        }

        public class FoundAnimalResponse : FindAnimalResponseMessage
        {
            public override string AnimalName => Animal.Name;
            public Animal Animal { get; }

            public FoundAnimalResponse(Animal animal)
            {
                Animal = animal;
            }
        }

        public class CouldNotFindAnimalResponse : FindAnimalResponseMessage
        {
            public override string AnimalName { get; }

            public CouldNotFindAnimalResponse(string animalName)
            {
                AnimalName = animalName;
            }
        }

        public class AnimalAdded : AnimalCreationResponseMessage
        {
            public override string AnimalName => Animal.Name;
            public Animal Animal { get; }

            public AnimalAdded(Animal animal)
            {
                Animal = animal;
            }
        }

        public class AnimalAlreadyAdded : AnimalCreationResponseMessage
        {
            public override string AnimalName => Animal.Name;
            public Animal Animal { get; }

            public AnimalAlreadyAdded(Animal animal)
            {
                Animal = animal;
            }
        }
    }
}