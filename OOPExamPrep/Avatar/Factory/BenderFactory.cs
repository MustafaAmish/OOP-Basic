using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class BenderFactory
{
    private enum TypeNation
    {
        Air,
        Water,
        Fire,
        Earth
    }

    public static Bender Bender(List<string> bender)
    {
        var type = Enum.Parse(typeof(TypeNation),bender[0],false);
        var name = bender[1];
        var power = int.Parse(bender[2]);
        var integrity = double.Parse(bender[3]);
        switch ((TypeNation)type)
        {
            case TypeNation.Air:return new AirBender(name,power,integrity);
               
            case TypeNation.Water:
                return new WaterBender(name, power, integrity);
            case TypeNation.Fire:
                return  new FireBender(name, power, integrity);
            case TypeNation.Earth:
               return new EarthBender(name, power, integrity);
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
