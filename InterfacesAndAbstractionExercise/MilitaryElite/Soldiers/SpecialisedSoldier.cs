using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interface;

namespace MilitaryElite.Soldiers
{
  public  class SpecialisedSoldier:Private,ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary,string corps) : base(id, firstName, lastName, salary)
        {
           GetCoprs(corps);
        }

        public Corps Corps { get; private set; }
        public void GetCoprs(string type)
        {
            bool check = Enum.TryParse(typeof(Corps), type, out object corpResult);
            if (!check)
            {
               throw new ArgumentException("sdfa");
            }
            Corps = (Corps)corpResult;
        }
    }
}
