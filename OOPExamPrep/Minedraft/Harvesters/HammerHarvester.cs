using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester:Harvester
{
    public string Type => "Hammer";
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput*3, energyRequirement*2)
    {
        //this.EnergyRequirement = energyRequirement * 2;
        //this.OreOutput = oreOutput * 3;
    }

    public override string Check()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Type} Harvester - {this.Id}").AppendLine($"Ore Output: {OreOutput}").AppendLine($"Energy Requirement: {EnergyRequirement}");
        var result = sb.ToString().Trim();
        return result;
    }
}