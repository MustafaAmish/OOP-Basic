using System;
using System.Collections.Generic;
using System.Text;

public class Pet : IPet
{
    public string Name { get; private set; }
    public string Birthdate { get; private set; }

    public Pet(string name,string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }
}