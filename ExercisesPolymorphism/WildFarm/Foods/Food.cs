using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food :IFood
{
    public int Quantity { get; }

    protected Food(int quantity)
    {
        Quantity = quantity;
    }
}