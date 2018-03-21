using System;
using System.Collections.Generic;
using System.Text;

public class Robot : Society
{
    public string Model { get; private set; }
    public string Id { get; private set; }

    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }
    public override bool IdCheck(string number)
    {
        return this.Id.EndsWith(number);
    }
    public override string Print()
    {
        return $"{this.Id}";
    }
}
