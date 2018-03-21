using System;
using System.Collections.Generic;
using System.Text;

public class UltrasoftTyre:Tyre,IUltrasoftTyre
{
    public UltrasoftTyre( double hardness,double grip) : base( hardness)
    {
        this.Grip = grip;
    }

    public double Grip { get; }
    private double degradation;

    public override string Name => "Ultrasoft";

    public override double Degradation
    {
        get
        {
            return this.degradation;
        }
        protected set
        {
            if (Degradation < 30)
            {
                throw new ArgumentException(ERRORMESSEG.TyreBlown);
            }
            degradation = value;
        }
    }

    public override void ReduceDegradation()
    {
      this.Degradation-= this.Hardness+this.Grip ;
    }
}