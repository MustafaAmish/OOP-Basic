using System;
using System.Collections.Generic;
using System.Text;

//title, author and price
public class Book
{
    private string title;
    private string author;
    private decimal price;  
    
    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentException($"Title not valid!");
            }
            title = value;
        }
    }

    public string Author
    {
        get { return author; }
        set
        {
            var fullName = value.Split();
            if (fullName.Length==2&&char.IsDigit(fullName[1][0]))
            {
                throw new ArgumentException($"Author not valid!");
            }
            author = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value<=0)
            {
                throw new ArgumentException($"Price not valid!");
            }
            price = value;
        }
    }

    public Book(string author,string title,decimal price)
    {
        Author = author;
        Title = title;
        Price = price;
    }

    public override string ToString()
    {
        var result=new StringBuilder();
        result.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:F}");
        string output = result.ToString().TrimEnd();

        return output;
    }
}

