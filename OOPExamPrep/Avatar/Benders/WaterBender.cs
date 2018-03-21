using System;
using System.Collections.Generic;
using System.Text;

public class WaterBender:Bender
{
    public double WaterClarity { get; private set; }

    public WaterBender(string name, int power,double waterClarity) : base(name, power)
    {
        WaterClarity = waterClarity;
    }

    public override double GetPower()
    {
        return base.Power * WaterClarity;
    }

    public override string Tostring()
    {
        return $"###Water Bender: {base.Name}, Power: {Power}, Water Clarity: {WaterClarity:F}";
    }
}
