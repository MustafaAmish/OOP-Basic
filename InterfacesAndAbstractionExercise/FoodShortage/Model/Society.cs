using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class Society :IBuyer
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Food { get; set; }   

    public Society(string name,int age)
    {
        Name = name;
        Age = age;
        Food = 0;
    }


    public virtual void BuyFood()
    {
        Food += 0;
    }
}

