﻿using System;
using System.Collections.Generic;
using System.Text;


    public class Car : Vehicle
    {
        private const double Air_Conditioners = 0.9;

        public Car(double fuel, double fuelPerKm,double tankCapacity) : base(fuel, fuelPerKm,tankCapacity)
        {

        }

        public override void Drive(double distens)
        {
            double fullNeed = (this.Litter + Air_Conditioners) * distens;
            if (fullNeed > this.Quantity)
            {
                throw new ArgumentException($"Car needs refueling");
            }
            this.Quantity -= fullNeed;
            Console.WriteLine($"{this.GetType().Name} travelled {distens} km");

        }



        public override void Refuel(double distens)
        {
            this.Quantity += ValidatorRefuel.RefuelValidator(distens,this.TankCapacity);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Quantity:F}";
        }
    }
