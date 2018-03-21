using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private double oreOut;
    private double energi;
    private string mode;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private ProviderFactory providerFactory;
    private HarvesterFactory harvesterFactory;

    public DraftManager()
    {
        this.mode = "Full";
        this.oreOut = 0;
        this.energi = 0;
        this.harvesters=new List<Harvester>();
        this.providers=new List<Provider>();
        providerFactory=new ProviderFactory();
        harvesterFactory=new HarvesterFactory();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            harvesterFactory=new HarvesterFactory();
            var type = arguments[0];
            var id = arguments[1];

            var harvester = harvesterFactory.CreateHarvester(arguments);
            harvesters.Add(harvester);
            return $"Successfully registered {type} Harvester - {id}";
        }
        catch (Exception e)
        {
            return e.Message;

        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            providerFactory=new ProviderFactory();
            var type = arguments[0];
            var id = arguments[1];

            var provider = providerFactory.CreateProvider(arguments);
            providers.Add(provider);
            return $"Successfully registered {type} Provider - {id}";
        }
        catch (Exception e)
        {
            return e.Message;

        }
    }
    public string Day()
    {
        double energiNeed = 0;
        double engprovaid = providers.Sum(e => e.EnergyOutput);
        double ore = 0;
        foreach (var provider in providers)
        {
            energi += provider.EnergyOutput;
        }
        switch (mode)
        {
            case "Full":
                energiNeed = harvesters.Sum(x => x.EnergyRequirement);
                if (energiNeed<=energi)
                {
                    energi -= energiNeed;
                    ore= harvesters.Sum(o => o.OreOutput);
                    oreOut += ore;
                }
                break;
            case "Half":
                energiNeed = harvesters.Sum(x => x.EnergyRequirement);
                if (energiNeed <= energi)
                {
                    energi -= energiNeed*0.60;
                    ore = harvesters.Sum(o => o.OreOutput)*0.50;
                    oreOut += ore;
                }
                break;
            case "Energy":
               
                break;
        }
        var sb=new StringBuilder();
        sb.AppendLine($"A day has passed.").AppendLine($"Energy Provided: {engprovaid}")
            .AppendLine($"Plumbus Ore Mined: {ore}");
        var result = sb.ToString().Trim();
        return result;
    }

    

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string  Check(List<string> arguments)
    {
        if (providers.Any(n=>n.Id.Contains(arguments[0])))
        {
            var provider = providers.First(n => n.Id == arguments[0]);
            return provider.Check().ToString();
        }
        else if(harvesters.Any(n => n.Id.Contains(arguments[0])))
        {
            var harvester = harvesters.First(n => n.Id == arguments[0]);
            return harvester.Check();
        }
        else
        {
            return $"No element found with id - {arguments[0]}";
        }

       
    }
    public string ShutDown()
    {
        var sb=new StringBuilder();
        sb.AppendLine($"System Shutdown").AppendLine($"Total Energy Stored: {energi}")
            .AppendLine($"Total Mined Plumbus Ore: {oreOut}");
        var result = sb.ToString().Trim();

        return result;
    }

    

}
