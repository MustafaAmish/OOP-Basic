using System;
using System.Collections.Generic;
using System.Text;

public class FireBender:Bender
{
    public double HeatAggression { get; private set; }

    public FireBender(string name, int power,double heatAggression) : base(name, power)
    {
        HeatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return base.Power * HeatAggression;
    }

    public override string Tostring()
    {
        return $"###Fire Bender: {base.Name}, Power: {base.Power}, Heat Aggression: {HeatAggression:F}";
    }
}