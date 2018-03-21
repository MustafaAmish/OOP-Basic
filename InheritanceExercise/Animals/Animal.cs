using System;
using System.Collections.Generic;
using System.Text;

public class Animal : ISoundProducable
{
    private const string ERRORMESEG = "Invalid input!";

    private string name;
    private int age;
    private string gender;
   

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException(ERRORMESEG);
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException(ERRORMESEG);

            }
            age = value;
        }
    }
    
    public string Gender
    {
        get { return gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException(ERRORMESEG);
            }
            gender = value;
        }
    }

    public Animal(string name,int age,string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual string ProduceSound()
    {
        return "mamam!!!!!";
    }

    public override string ToString()
    {
        var sb=new StringBuilder();
        sb.AppendLine($"{this.GetType().Name}")
            .AppendLine($"{this.Name} {this.Age} {this.Gender}")
            .AppendLine($"{this.ProduceSound()}");
        string result = sb.ToString().TrimEnd();
        return result;
    }

   
}

