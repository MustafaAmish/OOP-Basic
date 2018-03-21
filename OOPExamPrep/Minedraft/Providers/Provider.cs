using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider
{
    public Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    private string id;
    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
      protected  set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            energyOutput = value;
        }
    }


    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public abstract string Check();
}