using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factories.Foods
{
    public class Other : Food
    {
        private new const int PointsOfHappiness = -1;

        public Other() : base(PointsOfHappiness)
        {
        }
    }
}
