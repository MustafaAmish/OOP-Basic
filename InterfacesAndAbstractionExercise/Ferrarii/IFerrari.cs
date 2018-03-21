using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrarii
{
    interface IFerrari
    {
        string Model { get; }
        string Brakes();
        string PushGas();
    }
}
