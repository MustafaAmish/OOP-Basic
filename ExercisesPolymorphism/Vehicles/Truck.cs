using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    private const double Air_Conditioners = 1.6;
    public Truck(double fuel, double fuelPerKm, double tankCapacity) : base(fuel, fuelPerKm, tankCapacity)
    {
    }

    public override void Drive(double distens)
    {
        double fullNeed = (this.Litter + Air_Conditioners) * distens;
        if (fullNeed > this.Quantity)
        {
            throw new ArgumentException($"Truck needs refueling");
        }
        this.Quantity -= fullNeed;
        Console.WriteLine($"{this.GetType().Name} travelled {distens} km");

    }

    public override void Refuel(double distens)
    {
        this.Quantity += ValidatorRefuel.RefuelValidator(distens,this.TankCapacity) * 0.95;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.Quantity:F}";
    }
}

