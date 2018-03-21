using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public List<Person> ReserveTeam
    {
        get { return reserveTeam; }

    }


    public List<Person> FirstTeam
    {
        get { return firstTeam; }

    }

    public Team(string name)
    {
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
        this.name = name;
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }

}

