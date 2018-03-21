using System;
using System.Collections.Generic;
using System.Text;

public class Owl:Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override void ProducingSound()
    {
        Console.WriteLine($"Hoot Hoot");
    }

    public override void Eate( Food food)
    {
        if (food.GetType().Name.ToLower() != "meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        this.Weight += (food.Quantity * 0.25);
        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return base.ToString() + $"{WingSize}, {this.Weight}, {FoodEaten}]";
    }
}