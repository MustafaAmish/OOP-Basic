﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factories.Foods
{
    public class Cram : Food
    {
        private const int PointsOfHappiness = 2;

        public Cram() : base(PointsOfHappiness)
        {
        }
    }
}
