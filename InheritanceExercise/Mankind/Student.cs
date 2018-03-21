using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


public class Student:Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
           
            if (value.Length<=5||value.Length>=10|| !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException($"Invalid faculty number!");
            }
            facultyNumber = value;
        }

    }

    public Student(string firstName, string lastname,string facultyNumber):base(firstName,lastname)
    {
        FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        var concatResult=new StringBuilder();
        concatResult.AppendLine($"First Name: {base.FirstName}")
            .AppendLine($"Last Name: {base.Lastname}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
        var result = concatResult.ToString().TrimEnd();
        return result;
    }
}

