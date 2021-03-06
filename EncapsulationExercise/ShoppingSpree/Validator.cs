﻿using System;
using System.Collections.Generic;
using System.Text;

public class Validator
{
    public static void Price(decimal price)
    {
        if (price<0)
        {
            throw new ArgumentException($"Money cannot be negative");
        }
    }

    public static void Name(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"Name cannot be empty");
        }
    }
}

