using System;
using System.Collections.Generic;
using System.Text;

public class ValidatorRefuel
{
    public static double RefuelValidator(double fuel, double tankCapasity)
    {
        if (tankCapasity< ValiFuel(fuel))
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        return fuel;
    }

    private static double ValiFuel(double fuel)
    {
        if (fuel<=0)
        {
            throw new ArgumentException($"Fuel must be a positive number");
        }
        return fuel;
    }
}
