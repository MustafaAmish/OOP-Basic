using System;
using System.Collections.Generic;
using System.Text;

public class AirMonument:Monument
{
    public int AirAffinity { get; private set; }

    public AirMonument(string name,int airAffinity) : base(name)
    {
        AirAffinity = airAffinity;
    }

    public override double Bonus()
    {
        return AirAffinity;
    }

    public override string ToString()
    {
        return $"###Air Monument: {base.Name}, Air Affinity: {AirAffinity}";
    }
}