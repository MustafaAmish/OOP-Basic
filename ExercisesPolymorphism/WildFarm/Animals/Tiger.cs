using System;
using System.Collections.Generic;
using System.Text;

public class Tiger:Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override void ProducingSound()
    {
        Console.WriteLine($"ROAR!!!");
    }

    public override void Eate( Food food)
    {
        if (food.GetType().Name.ToLower() != "meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        this.Weight += (food.Quantity * 1.00);
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}