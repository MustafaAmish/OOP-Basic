using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factories.Foods
{
    public class HoneyCake : Food
    {
        private const int PointsOfHappiness = 5;

        public HoneyCake() : base(PointsOfHappiness)
        {
        }
    }
}
