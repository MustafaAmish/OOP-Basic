using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
   public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distance;

        public string Model { get { return this.model; } private set { this.model = value; } }
        public double FuelAmount { get { return this.fuelAmount; } private set { this.fuelAmount = value; } }
        public double FuelConsumption { get { return this.fuelConsumption; } private set { this.fuelConsumption = value; } }
        public double Distance { get { return this.distance; } private set { this.distance = value; } }

        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public void CarMuve(string model, double kmDistance)
        {
            var needFuel = kmDistance * this.FuelConsumption;
            if (needFuel<=this.FuelAmount)
            {
                this.Distance += kmDistance;
                this.FuelAmount -= needFuel;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

    }
}
