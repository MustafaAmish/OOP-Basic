using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

public class FoodFactory
{
    public static Food GetFood(string type, int quantity)
    {
        switch (type)
        {
            case "Vegetable": var vegetable = new Vegetable(quantity);
                return vegetable;
            case "Fruit": var fruit=new Fruit(quantity);
                    return fruit;
            case "Meat": var meat=new Meat(quantity);
                return meat;
            case "Seeds": var seeds=new Seeds(quantity);
                return seeds;
                default: return null;

        }
    }
}