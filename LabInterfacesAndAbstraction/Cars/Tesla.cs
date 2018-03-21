using System;
using System.Collections.Generic;
using System.Text;

public class Tesla:ICar,IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Battery { get; private set; }
    public Tesla(string model, string color,int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Color} {this.GetType().Name} {Model} with {Battery} {nameof(Battery)}")
            .AppendLine($"{Start()}")
            .AppendLine(Stop());
        var result = sb.ToString().TrimEnd();
        return result;
    }
}