using System;
using System.Collections.Generic;
using System.Text;

public class SolarProvider:Provider
{
    public string Type => "Solar";
    public SolarProvider(string id, double energyOutput) : base(id, energyOutput)
    {
    }

    public override string Check()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Type} Provider - {this.Id}").AppendLine($"Energy Output: {EnergyOutput}");
        var result = sb.ToString().Trim();
        return result;
    }
}
