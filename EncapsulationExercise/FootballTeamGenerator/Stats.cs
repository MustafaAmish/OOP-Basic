using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;


class Stats
{
    //endurance, sprint, dribble, passing and shooting
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    private int Shooting
    {
        get { return shooting; }
        set
        {
            if (value<0||value>100)
            {
               throw new ArgumentException($"Shooting should be between 0 and 100.");
            }
            shooting = value;
        }
    }
    
    private int Passing
    {
        get { return passing; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Passing should be between 0 and 100.");
            }
            passing = value;
        }
    }
    
    private int Dribble
    {
        get { return dribble; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Dribble should be between 0 and 100.");
            }
            dribble = value;
        }
    }


    private int Sprint
    {
        get { return sprint; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Sprint should be between 0 and 100.");
            }
            sprint = value;
        }
    }


    private int Endurance
    {
        get { return endurance; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Endurance should be between 0 and 100.");
            }
            endurance = value;
        }
    }

    public Stats(int endurance,int sprint,int dribble,int passing,int shooting)
    {
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public  int Average()
    {
        int average =(int)Math.Ceiling((double) (this.Endurance + Sprint + Dribble + Passing + Shooting) / 5);
        return average;
    }


}

