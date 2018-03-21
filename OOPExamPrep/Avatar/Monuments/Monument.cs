using System;
using System.Collections.Generic;
using System.Text;

public abstract class Monument
{
    public string Name { get; private set; }

    protected Monument(string name)
    {
        Name = name;
    }

    public abstract double Bonus();
    public abstract string ToString();
}