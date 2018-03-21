using System;
using System.Collections.Generic;
using System.Text;

public class Cat:Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override void ProducingSound()
    {
        Console.WriteLine($"Meow");
    }

    public override void Eate( Food food)
    {
        if (food.GetType().Name.ToLower() != "vegetable" && food.GetType().Name.ToLower() != "meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        this.Weight += (food.Quantity * 0.30);
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
