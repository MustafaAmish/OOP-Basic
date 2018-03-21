using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal:IAnimal
{
    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
        FoodEaten = 0;
    }

    public string Name { get; }
    public double Weight { get; protected set; }
    public int FoodEaten { get; protected set; }
    public abstract void ProducingSound();


    public abstract void Eate( Food food);

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, ";
    }
}
