using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MonumentFactory
{
    private enum TypeNation
    {
        Air,
        Water,
        Fire,
        Earth
    }

    public static Monument Monument(List<string> monument)
    {
        var type = Enum.Parse(typeof(TypeNation), monument[0], false);
        var name = monument[1];
        var affinity = int.Parse(monument[2]);
        switch ((TypeNation)type)
        {
            case TypeNation.Air:
               return new AirMonument(name,affinity);
            case TypeNation.Water:
               return  new WaterMonument(name, affinity);
            case TypeNation.Fire:
               return  new FireMonument(name, affinity);
            case TypeNation.Earth:
               return new EarthMonument(name, affinity);
                default: return null;
        }
    }
}