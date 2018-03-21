using System;
using System.Collections.Generic;
using System.Text;

public class WaterMonument:Monument
{
    public int WaterAffinity { get; private set; }

    public WaterMonument(string name,int waterAffinity) : base(name)
    {
        WaterAffinity = waterAffinity;
    }

    public override double Bonus()
    {
        return WaterAffinity;
    }

    public override string ToString()
    {
        return $"###Water Monument: {base.Name}, Water Affinity: {WaterAffinity}";
    }
}
