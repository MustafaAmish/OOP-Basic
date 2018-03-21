﻿using System;
using System.Collections.Generic;
using System.Text;


public class Circle : IDrawable
{
    private double radius;

    public double Radius
    {
        get { return radius; }
       private set { radius = value; }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Draw()
    {
        double rIn = Radius - 0.4;
        double rOut = Radius + 0.4;

        for (double y = Radius ; y >= -Radius; --y)
        {
            for (double x = -Radius; x < rOut; x+=0.5)
            {
                double value = x * x + y * y;
                if (value>=rIn*rIn&&value<+rOut*rOut)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
