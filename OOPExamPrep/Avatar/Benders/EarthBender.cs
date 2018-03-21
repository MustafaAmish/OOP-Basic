using System;
using System.Collections.Generic;
using System.Text;

public class EarthBender:Bender
{
    public double GroundSaturation { get; private set; }

    public EarthBender(string name, int power,double groundSaturation) : base(name, power)
    {
        GroundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return base.Power * GroundSaturation;
    }

    public override string Tostring()
    {
        return $"###Earth Bender: {base.Name}, Power: {base.Power}, Ground Saturation: {GroundSaturation:F}";
    }
}
