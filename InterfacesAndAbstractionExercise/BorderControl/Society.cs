using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class Society : IRobot,ICitizen
{
    private int _id;
    public string Model { get; }
    public string Name { get; }
    public int Age { get; }

    public string Id { get; }
    public string Birthdate { get; }

    public virtual bool IdCheck(string number)
    {
        return this.Id.EndsWith(number);
    }

    public virtual string Print()
    {
        return $"{this.Id}";
    }

    
}

