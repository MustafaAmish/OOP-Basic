﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factories.Foods
{
    public class Apple : Food
    {
        private const int PointsOfHappiness = 1;

        public Apple() : base(PointsOfHappiness)
        {
        }
    }
}
