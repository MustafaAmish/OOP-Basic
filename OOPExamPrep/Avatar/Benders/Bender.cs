using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bender:IBender
{
    public string Name { get; private set; }
    public int Power { get; private set; }

    protected Bender(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public abstract double GetPower();
    public abstract string Tostring();
}
