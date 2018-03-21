using System;
using System.Collections.Generic;
using System.Text;


public class Worker:Human
{
    private const decimal Min_Salary = 10m;
    private const decimal Min_Hours = 1;
    private const decimal Max_Hours = 12;

    private decimal salary;
    private decimal hours;

    public decimal Hours
    {
        get { return hours; }
        private set
        {
            if (value < Min_Hours || value > Max_Hours)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            hours = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        private set
        {
            if (value <= Min_Salary)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
            salary = value;
        }
    }

    public Worker(string firstName,string lastName,decimal salary,decimal hours):base(firstName,lastName)
    {
        Salary = salary;
        Hours = hours;
        SalaryPerHour = Salary / (Hours * 5);
    }

    private decimal salaryPerHour;  

    public decimal SalaryPerHour
    {
        get { return salaryPerHour; }
        set { salaryPerHour =value; }
    }

    public override string ToString()
    {
        var concatResult = new StringBuilder();
        concatResult.AppendLine($"First Name: {base.FirstName}")
            .AppendLine($"Last Name: {base.Lastname}")
            .AppendLine($"Week Salary: {this.Salary:F}")
            .AppendLine($"Hours per day: {this.Hours:F}")
            .AppendLine($"Salary per hour: {this.SalaryPerHour:F}");
        var output = concatResult.ToString().TrimEnd();
        return output;
    }
}

