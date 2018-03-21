using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            string inputLine;
            while ((inputLine=Console.ReadLine())!="End")
            {
                try
                {
                    var input = inputLine.Split();
                    if (input.Length==2)
                    {
                        var foodName = input[0];
                        var quantity = int.Parse(input[1]);
                        var food= FoodFactory.GetFood(foodName, quantity);
                        var animal = animals.Last();
                        animal.Eate(food);
                        continue;
                    }
                    var animalType = input[0];
                    var animalName = input[1];
                    var animalWeight = double.Parse(input[2]);
                    var livingRegion = input[3];
                    string breed = null;
                    if (input.Length==5)
                    {
                        breed = input[4];
                    }
                    animals.Add( AnimalFactory.GetAnimal(animalType, animalName, animalWeight, livingRegion, breed));
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
    }
}
