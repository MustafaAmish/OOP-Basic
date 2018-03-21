using System;
using System.Collections.Generic;
using System.Text;

public interface ITyre
{
    string Name { get; }
    double Hardness { get; }
    double Degradation { get; }
}
