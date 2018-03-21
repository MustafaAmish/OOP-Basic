using System;
using System.Collections.Generic;
using System.Text;

public class FireMonument:Monument
{
    public int FireAffinity { get; private set; }

    public FireMonument(string name,int fireAffinity) : base(name)
    {
        FireAffinity = fireAffinity;
    }

    public override double Bonus()
    {
        return FireAffinity;
    }

    public override string ToString()
    {
        return $"###Fire Monument: {base.Name}, Fire Affinity: {FireAffinity}";
    }
}