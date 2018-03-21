using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle:Shape
{
    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    private double width;
    private double height;

    public double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("avav");
            }
            height = value;
        }
    }


    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("avav");
            }
            width = value;
        }
    }

    public override double CalculatePerimeter()
    {
        double result = (this.Width * this.Height)*2;
        return result;
    }

    public override double CalculateArea()
    {
        double result = Width * Height;
        return result;
    }

    public override string Draw()
    {
        return base.Draw()+$"Rectangle";
    }
}
