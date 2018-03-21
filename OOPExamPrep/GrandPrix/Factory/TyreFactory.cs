using System;
using System.Collections.Generic;
using System.Text;

public class TyreFactory
{
    public static Tyre CreateTyre(List<string> args)
    {
        //var args = commandArgs.Skip(4).ToArray();

        if (args[0] == "Ultrasoft")
        {
            var grip = double.Parse(args[2]);
            return new UltrasoftTyre(double.Parse(args[1]), grip);
        }

        return new HardTyre(double.Parse(args[1]));
    }
}