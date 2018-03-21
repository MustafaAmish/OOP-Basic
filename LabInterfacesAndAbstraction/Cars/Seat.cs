using System;
using System.Collections.Generic;
using System.Text;


public class Seat : ICar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public Seat(string model,string color)
    {
        Model = model;
        Color = color;
    }

    public override string ToString()
    {
        var sb=new StringBuilder();
        sb.AppendLine($"{Color} {this.GetType().Name} {Model}")
            .AppendLine($"{Start()}")
            .AppendLine(Stop());
        var result = sb.ToString().TrimEnd();
        return result;
    }
}

