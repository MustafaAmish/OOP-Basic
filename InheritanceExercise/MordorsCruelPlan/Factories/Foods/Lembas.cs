using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factories.Foods
{
    public class Lembas : Food
    {
        private const int PointsOfHappiness = 3;

        public Lembas() : base(PointsOfHappiness)
        {
        }
    }
}
