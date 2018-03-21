using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle : IVehicle
{
    protected Vehicle(double fuel, double fuelPerKm,double tankCapacity)
    {
       this.Quantity= CheckTankCapacity(fuel, tankCapacity);
        Litter = fuelPerKm;
        TankCapacity = tankCapacity;

    }

    private double CheckTankCapacity(double fuel, double tankCapacity)
    {
        if (fuel>tankCapacity||fuel<0)
        {
            return 0;

        }
        return fuel;
    }


    public double Quantity { get; protected set; }
    public double Litter { get; protected set; }
    public double TankCapacity { get; protected set; }



    public abstract void Drive(double distens);

    public virtual void DriveEmpty(double distens) { }
    

    public abstract void Refuel(double distens);
    

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.Quantity:F}";
    }

}
