using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bird:Animal,IBird
{
    protected Bird(string name, double weight, double wingSize) : base(name,weight)
    {
        WingSize = wingSize;
    }

    public double WingSize { get; }

}