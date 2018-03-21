using System;
using System.Collections.Generic;
using System.Text;


class Engine
{
    //model, power, displacement and efficiency.
    private string model;
    private int power;
    private int? displanement;
    private string efficiency;

    public Engine(string model,int power)
    {
        this.Model = model;
        this.Power = power;
        this.Displanement = null;
        this.Efficiency = "n/a";

    }

    public Engine(string model, int power,int displanement):this(model,power)
    {
        this.Displanement = displanement;
    }

    public Engine(string model, int power,string efficiency):this(model,power)
    {
        this.Efficiency = efficiency;
    }

    public Engine(string model, int power, int displanement,string efficiency):this(model,power)
    {
        this.Displanement = displanement;
        this.Efficiency = efficiency;
    }

    public string Efficiency
    {   
        get { return efficiency; }
        private set { efficiency = value; }
    }


    public int? Displanement
    {
        get { return displanement; }
        private set { displanement = value; }
    }

    public int Power
    {
        get { return power; }
        private set { power = value; }
    }


    public string Model
    {
        get { return model; }
        private set { model = value; }
    }

    public override string ToString()
    {
        var result = $"  {this.model}:";
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, $"    Power: {this.power}");
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.displanement == null ? "    Displacement: n/a" : $"    Displacement: {this.displanement}");
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {this.efficiency}");
        result = string.Concat(result, Environment.NewLine);

        return result;
    }
}

