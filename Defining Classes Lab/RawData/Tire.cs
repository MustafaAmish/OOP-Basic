using System;
using System.Collections.Generic;
using System.Text;


public class Tire
{
    private double tirePressure;
    private double tireAge;
 

    public double TirePressure { get { return this.tirePressure; } private set { this.tirePressure = value; }}
    public double TireAge { get { return this.tireAge; } private set { this.tireAge = value; }}
   
    public Tire(double tireAge, double tirePressure)
    {
        this.TirePressure = tirePressure;
        this.TireAge = tireAge;
    
    }
}

