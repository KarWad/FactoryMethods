using System;

namespace FactoryMethods
{
    public interface Animals
    {
        string GetName();
    }
    public class Carnivores : Animals
    {
        public string GetName()
        {
            return "Carnivore Animal";
        }
    }
    public class Herbivores : Animals
    {
        public string GetName()
        {
            return "Herbivore Animal";
        }
    }
    public enum AnimalType
    {
        Big,
        Small
    }

    public class FactoryMethod
    {
        public Animals GetAnimals(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Big:
                    return new Carnivores();
                case AnimalType.Small:
                    return new Herbivores();
                default:
                    throw new NotSupportedException();
            }
        }

        public abstract class bikeAbstractFactory
        {
            protected abstract Animals Makebike();

            public Animals GetObject()
            {
            return this.Makebike();
            }
        }
        static void Main(string[] args) 
        {
            Animals Animal = new Carnivores();
            Animals Animal2 = new Herbivores();
            

        }
    }
}

