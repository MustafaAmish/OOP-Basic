using System;
using System.Collections.Generic;
using System.Text;


public class VehicleFactory
{
    public static Vehicle GetVahicle(string[] vihicle)
    {
        var type = vihicle[0];
        double fuel = double.Parse(vihicle[1]);
        double fuelPerKm = double.Parse(vihicle[2]);
        double tankCapacity = double.Parse((vihicle[3]));

        switch (type.ToLower())
        {
            case "car":
                return new Car(fuel, fuelPerKm,tankCapacity);
            case "truck": return new Truck(fuel, fuelPerKm,tankCapacity);
            case "bus":return  new Bus(fuel, fuelPerKm, tankCapacity);
            default:
                return null;



        }
    }
}

