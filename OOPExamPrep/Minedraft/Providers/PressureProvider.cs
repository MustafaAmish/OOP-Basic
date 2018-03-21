using System;
using System.Collections.Generic;
using System.Text;

public class PressureProvider:Provider
{
    private const double PercentageEnergyOutputIncreasement = 1.5;
    public string Type => "Pressure";
    public PressureProvider(string id, double energyOutput)
        : base(id, IncreasedEnergy(energyOutput))
    {
    }

    private static double IncreasedEnergy(double energyOutput) => energyOutput * PercentageEnergyOutputIncreasement;

    public override string Check()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Type} Provider - {this.Id}").AppendLine($"Energy Output: {EnergyOutput}");
        var result = sb.ToString().Trim();
        return result;
    }
}
