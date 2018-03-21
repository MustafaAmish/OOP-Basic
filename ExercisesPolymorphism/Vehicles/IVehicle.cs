using System;
using System.Collections.Generic;
using System.Text;

public interface IVehicle
{
    double Quantity { get; }
    double Litter { get; }
    double TankCapacity { get; }

    void Drive(double distens);
    void Refuel(double distens);
}

