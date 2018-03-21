using System;
using System.Collections.Generic;
using System.Text;


class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double x;
    private double y;

    public double Y
    {
        get { return y; }
        private set { y = value; }
    }

    public double X
    {
        get { return x; }
        private set { x = value; }
    }

    public double Height
    {
        get { return height; }
        private set { height = value; }
    }

    public double Width
    {
        get { return width; }
        private set { width = value; }
    }

    public string Id
    {
        get { return id; }
        private set { id = value; }
    }

    public Rectangle(string id, double width, double height, double x, double y)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.X = x;
        this.Y = y;
    }

    
}

