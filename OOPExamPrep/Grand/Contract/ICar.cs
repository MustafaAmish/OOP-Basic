using System;
using System.Collections.Generic;
using System.Text;

public interface ICar
{
    int Hp { get; }
    double FuelAmount { get; }
    Tyre Tyre { get; }
    void ChenchTyre(Tyre tyre);
}