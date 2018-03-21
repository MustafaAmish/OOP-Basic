using System;
using System.Collections.Generic;
using System.Text;

class Car
{
    private string model;
    private Engine engine;
    private int? weight;
    private string color;

    public Car(string model,Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = null;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine,int weight):this( model, engine)
    {
        this.Weight = weight;
    }

    public Car(string model, Engine engine,string color):this(model, engine)
    {
        this.Color = color;
    }

    public Car(string model, Engine engine, int weight,string color) : this(model, engine)
    {
        this.Weight = weight;
        this.Color = color;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }


    public int? Weight
    {
        get { return weight; }
        set { weight = value; }
    }



    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }


    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public override string ToString()
    {
        var result = $"{this.model}:";
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.engine.ToString());
        result = string.Concat(result, this.weight == null ? "  Weight: n/a" : $"  Weight: {this.weight}");
        result = string.Concat(result, Environment.NewLine);
        result = string.Concat(result, this.color == null ? "  Color: n/a" : $"  Color: {this.color}");
       // result = string.Concat(result, Environment.NewLine);

        return result;
    }
}

