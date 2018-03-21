using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factories.Foods
{
    public class Melon : Food
    {
        private const int PointsOfHappiness = 1;

        public Melon() : base(PointsOfHappiness)
        {
        }
    }
}
