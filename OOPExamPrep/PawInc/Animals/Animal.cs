using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
     
    protected Animal(string name, int age, int commmand, string adoptetCenter)
    {
        Name = name;
        Age = age;
        Status = false;
        Commmand = commmand;
        AdoptetCenter = adoptetCenter;
    }


    public string Name { get;private set; }

    public int Age { get;private set; }
    public bool Status { get; set; }
    public int Commmand { get;private set; }
    public string AdoptetCenter { get;private set; }


}
