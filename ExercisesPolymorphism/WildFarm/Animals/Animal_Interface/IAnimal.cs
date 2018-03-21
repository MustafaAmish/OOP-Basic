using System;
using System.Collections.Generic;
using System.Text;

public interface IAnimal
{
    //string Name, double Weight, int FoodEaten
    string Name { get; }
    double Weight { get; }
    int FoodEaten { get; }
    void ProducingSound();
    void Eate( Food food);

}