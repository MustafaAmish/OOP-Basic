using System;
using System.Collections.Generic;
using System.Text;
using Ferrarii;


public class Ferrari :IFerrari
{
    public string Driver { get; private set; }
    public string Model => "488-Spider";
    public string Brakes()
    {
        return $"Brakes!";
    }

    public string PushGas()
    {
        return $"Zadu6avam sA!";
    }

    public Ferrari(string driver)
    {
        Driver = driver;
    }

    public override string ToString()
    {
        return $"{Model}/{Brakes()}/{PushGas()}/{Driver}";
    }
}

