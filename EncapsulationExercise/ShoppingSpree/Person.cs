using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> Products { get; set; }

    public Person()
    {
        Products=new List<Product>();
    }

    public Person(string name, decimal money):this()
    {
        Name = name;
        Money = money;
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            Validator.Price(value);
            money = value;
        }
    }


    public string Name
    {
        get { return name; }
        set
        {
            Validator.Name(value);
            name = value;
        }
    }

    public string TryBoughtPoduct(Product product)
    {
        if (this.Money<product.Price)
        {
            return $"{this.Name} can't afford {product.Name}";
        }
        this.Money -= product.Price;
        this.Products.Add(product);
        return $"{this.Name} bought {product.Name}";
    }

    public override string ToString()
    {
        if (Products.Count==0)
        {
            return $"{this.Name} - Nothing bought";
        }


        return $"{this.Name} - {string.Join(", ",Products)}";
    }
}

