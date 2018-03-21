using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mammal : Animal, IMammal
{
    protected Mammal(string name, double weight,string livingRegion) : base(name, weight)
    {
        LivingRegion = livingRegion;
    }

    public string LivingRegion { get; }
}
