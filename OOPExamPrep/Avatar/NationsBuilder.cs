using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NationsBuilder
{
    private Dictionary<string, List<Bender>> benders;
    private Dictionary<string, List<Monument>> monuments;
    private List<string> wars;

    public NationsBuilder()
    {
        benders = new Dictionary<string, List<Bender>>()
        {
            {"Water", new List<Bender>() },
            { "Air", new List<Bender>() },
            { "Fire", new List<Bender>() },
            { "Earth", new List<Bender>() },
        };

        monuments = new Dictionary<string, List<Monument>>()
        {
            { "Water", new List<Monument>() },
            { "Air", new List<Monument>() },
            { "Fire", new List<Monument>() },
            { "Earth", new List<Monument>() }
            
        };
        wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var bander = BenderFactory.Bender(benderArgs);
        benders[benderArgs[0]].Add(bander);
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var monument = MonumentFactory.Monument(monumentArgs);
        monuments[monumentArgs[0]].Add(monument);
    }
    public string GetStatus(string nationsType)
    {
        var sb=new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        if (benders[nationsType].Count==0)
        {
            sb.AppendLine($"Benders: None");
        }
        else
        {
            sb.AppendLine($"Benders:");
            foreach (var bender in benders[nationsType])
            {
                sb.AppendLine(bender.Tostring());
            }
        }
        if (monuments[nationsType].Count == 0)
        {
            sb.AppendLine($"Monuments: None");
        }
        else
        {
            sb.AppendLine($"Monuments:");
            foreach (var bender in monuments[nationsType])
            {
                sb.AppendLine(bender.ToString());
            }
        }
        return sb.ToString().Trim();
    }
    public void IssueWar(string nationsType)
    {
       var warpower=new Dictionary<string,double>()
       {
           {"Water", 0 },
           { "Air", 0 },
           { "Fire", 0 },
           { "Earth",0 },
       };
        foreach (var bender in benders)
        {
            
            warpower[bender.Key] += benders[bender.Key].Sum(x => x.GetPower()) + (benders[bender.Key].Sum(x => x.GetPower()) / 100) *
                  monuments[bender.Key].Sum(x => x.Bonus());
        }
        var winer = warpower.OrderByDescending(c => c.Value).First();
        foreach (var bender in benders)
        {
            if (bender.Key!=winer.Key)
            {
                bender.Value.Clear();
                monuments[bender.Key].Clear();
            }
        }
        wars.Add(nationsType);
    }
    public string GetWarsRecord()
    {
        var sb=new StringBuilder();
        var count = 1;
        foreach (var war in wars)
        {
            sb.AppendLine($"War {count} issued by {war}");
            count++;
        }
        return sb.ToString().Trim();
    }
}
