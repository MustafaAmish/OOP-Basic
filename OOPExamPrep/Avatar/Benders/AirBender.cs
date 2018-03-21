using System;
using System.Collections.Generic;
using System.Text;

public class AirBender:Bender
{
    public double AerialIntegrity { get; private set; }

    public AirBender(string name, int power,double aerialIntegrity) : base(name, power)
    {
        AerialIntegrity = aerialIntegrity;
    }

    public override double GetPower()
    {
        return base.Power * AerialIntegrity;
    }

    public override string Tostring()
    {
        return $"###Air Bender: {base.Name}, Power: {base.Power}, Aerial Integrity: {this.AerialIntegrity:F}";
    }
}
