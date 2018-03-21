using System;
using System.Collections.Generic;
using System.Text;

public class HardTyre:Tyre,IHardTyre
{
    public HardTyre( double hardness) : base( hardness)
    {
    }

    public override string Name => "Hard";
}