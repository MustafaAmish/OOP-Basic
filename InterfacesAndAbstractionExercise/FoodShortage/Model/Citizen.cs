﻿using System;
using System.Collections.Generic;
using System.Text;

public class Citizen :Society
{
   
    public string Id { get; private set; }
    public string Birthdate { get; private set; }
    



    public Citizen(string name,int age,string id,string birthdate):base(name,age)
    {
       
        Id = id;
        Birthdate = birthdate;
       
    }

    public override void BuyFood()
    {
       base.Food += 10;
    }
}
