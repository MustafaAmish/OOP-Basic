using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Soldiers;

namespace MilitaryElite.Interface
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNUmber) : base(id, firstName, lastName)
        {
            CodeNUmber = codeNUmber;
        }

        public int CodeNUmber { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()} {Environment.NewLine}Code Number: {this.CodeNUmber}";
        }
    }
}
