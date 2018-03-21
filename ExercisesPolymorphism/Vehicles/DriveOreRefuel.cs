using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DriveOreRefuel
{
    public static void GetVehicleAtion(string[] move, ICollection<Vehicle> vehicles)
    {
        var typeAtion = move[0];
        var vehicle = move[1];

        switch (typeAtion.ToLower())
        {
            case "drive":
                switch (vehicle.ToLower())
                {
                    case "car":
                        var car = vehicles.First(x => x.GetType().Name == "Car");
                        car.Drive(double.Parse(move[2]));
                        break;
                    case "truck":
                        var truck = vehicles.First(x => x.GetType().Name.ToLower() == "truck");
                        truck.Drive(double.Parse(move[2]));
                        break;
                    case "bus":
                        var bus = vehicles.First(x => x.GetType().Name == "Bus");
                        bus.Drive(double.Parse(move[2]));
                        break;
                }
                break;
            case "refuel":
                switch (vehicle.ToLower())
                {
                    case "car":
                        var car = vehicles.First(x => x.GetType().Name == "Car");
                        car.Refuel(double.Parse(move[2]));
                        break;
                    case "truck":
                        var truck = vehicles.First(x => x.GetType().Name.ToLower() == "truck");
                        truck.Refuel(double.Parse(move[2]));
                        break;
                    case "bus":
                        var bus = vehicles.First(x => x.GetType().Name == "Bus");
                        bus.Refuel(double.Parse(move[2]));
                        break;
                }
                break;
            case "driveempty":
                switch (vehicle.ToLower())
                {
                    case "bus":
                        var busEmpty = vehicles.First(x => x.GetType().Name == "Bus");
                        busEmpty.DriveEmpty(double.Parse(move[2]));
                        break;
                }
                break;

        }
    }
}

