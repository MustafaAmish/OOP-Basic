using System;
using System.Collections.Generic;
using System.Text;

public class Circle:Shape
{
    public Circle(double redius)
    {
        this.Radius = redius;
    }

    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException("avav");
            }
            radius = value;
        }
    }



    public override double CalculatePerimeter()
    {
        double result = 2 * Math.PI * Radius;
        return result;
        
    }

    public override double CalculateArea()
    {
        double result = Math.PI * Radius * Radius;
        return result;
    }

    public override string Draw()
    {
        return base.Draw()+$"Circle";
    }
}
