using System;
using System.Collections.Generic;
using System.Text;

public class Citizen :Society
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get; private set; }
    public string Birthdate { get; private set; }


    public Citizen(string name,int age,string id,string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
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
