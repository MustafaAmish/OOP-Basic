using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    protected Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    private string name;
    private string favouriteFood;

    public string FavouriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }
}
