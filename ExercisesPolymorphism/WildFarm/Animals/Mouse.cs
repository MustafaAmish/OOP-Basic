using System;
using System.Collections.Generic;
using System.Text;

public class Mouse:Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override void ProducingSound()
    {
        Console.WriteLine($"Squeak");
    }

    public override void Eate( Food food)
    {
        if (food.GetType().Name.ToLower()!= "vegetable" && food.GetType().Name.ToLower() != "fruit")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        this.Weight += (food.Quantity * 0.10);
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {FoodEaten}]";
    }
}
