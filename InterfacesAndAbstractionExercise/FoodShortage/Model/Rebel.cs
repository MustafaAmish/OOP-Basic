using System;
using System.Collections.Generic;
using System.Text;


public class Rebel :Society
{
    public string Group { get; private set; }
    

    public Rebel(string name, int age,string group) : base(name, age)
    {
        Group = group;
    }

    public override void BuyFood()
    {
        base.Food += 5;
    }
}

