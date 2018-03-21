using System;
using System.Collections.Generic;
using System.Text;

public class EarthMonument : Monument
{
    public int EarthAffinity { get; private set; }

    public EarthMonument(string name,int earthAffinity) : base(name)
    {
        EarthAffinity = earthAffinity;
    }

    public override double Bonus()
    {
        return EarthAffinity;
    }

    public override string ToString()
    {
        return $"###Earth Monument: {base.Name}, Earth Affinity: {EarthAffinity}";
    }
}