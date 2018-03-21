﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Family
{
    private List<Person> people;
 public Family()
    {
        this.people=new List<Person>();
    }
    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }

   

    public void AddMember(Person member)
    {
       this.people.Add(member);
    }
  public IOrderedEnumerable<Person> GetOldestMember()
  {
      return this.people.Where(x => x.Age>30).OrderBy(x=>x.Name);
  }
}
