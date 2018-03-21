using System;
using System.Collections.Generic;
using System.Text;


public class Company
{
    private string name;
    private decimal salary;
    private string depatment;

    public string Depatment { get { return this.depatment; } }
    public decimal Salary { get { return this.salary; } }
    public string Name { get { return this.name; } }

    public Company(string name, decimal salary, string depatment)
    {
        this.name = name;
        this.salary = salary;
        this.depatment = depatment;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Depatment} {this.Salary:F}";
    }
}

