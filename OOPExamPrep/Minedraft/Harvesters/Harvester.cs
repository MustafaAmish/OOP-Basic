using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester
{
    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    private string id;
    private double oreOutput;
    private double energyRequirement;

    public double EnergyRequirement
    {
        get => energyRequirement;
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
            }
            energyRequirement = value;
        }
    }


    public double OreOutput
    {
        get => oreOutput;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(OreOutput)}");
            }
            oreOutput = value;
        }
    }


    public string Id
    {
        get => id;
        protected set => id = value;
    }

    public abstract string Check();

}

