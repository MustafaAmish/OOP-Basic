using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interface;

namespace MilitaryElite.Soldiers
{
    public abstract class Soldier : ISoldier
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
