using System;
using System.Collections.Generic;
using System.Text;

public class SonicHarvester:Harvester
{
    public string Type => "Sonic";
    public SonicHarvester(string id, double oreOutput, double energyRequirement,int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        SonicFactor = sonicFactor;
        this.EnergyRequirement /= SonicFactor;
    }

    private int SonicFactor { get; set; }
    public override string Check()
    {
       var sb= new StringBuilder();
        sb.AppendLine($"{Type} Harvester - {this.Id}").AppendLine($"Ore Output: {OreOutput}").AppendLine($"Energy Requirement: {EnergyRequirement}");
        var result = sb.ToString().Trim();
        return result;
    }
}
