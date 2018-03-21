using System;
using System.Collections.Generic;
using System.Text;

public interface IDriver
{
    string Name { get; }
    double TotalTime { get; }
    Car Car { get; }
    double FuelConsumptionPerKm { get; }
    double Speed { get; }
}
