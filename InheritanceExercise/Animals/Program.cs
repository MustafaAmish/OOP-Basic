using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    ReadInputs(animalType, animals);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void ReadInputs(string animalType, List<Animal> animals)
        {
            var inputAnimal = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = inputAnimal[0];
            var age = int.Parse(inputAnimal[1]);
            string gender = null;
            if (inputAnimal.Length == 3)
            {
                gender = inputAnimal[2];
            }
            switch (animalType)
            {
                case "Dog":
                    var dog = new Dog(name, age, gender);
                    animals.Add(dog);
                    break;
                case "Cat":
                    var cat = new Cat(name, age, gender);
                    animals.Add(cat);
                    break;
                case "Frog":
                    var frog = new Frog(name, age, gender);
                    animals.Add(frog);
                    break;
                case "Tomcat":
                    var tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                    break;
                case "Kitten":
                    var kittens = new Kitten(name, age);
                    animals.Add(kittens);
                    break;
                default: throw new ArgumentException($"Invalid input!");
            }
        }
    }
}
