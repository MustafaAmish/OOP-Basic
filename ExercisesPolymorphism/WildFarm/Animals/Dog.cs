using System;
using System.Collections.Generic;
using System.Text;

public class Dog :Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override void ProducingSound()
    {
        Console.WriteLine($"Woof!");
    }

    public override void Eate( Food food)
    {
        if (food.GetType().Name.ToLower() != "meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        this.Weight += (food.Quantity * 0.40);
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {FoodEaten}]";
    }
}
