using System;
using System.Collections;
using System.Collections.Generic;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new List<Vehicle>();
            for (int i = 0; i < 3; i++)
            {
               vehicle.Add( VehicleFactory.GetVahicle(Console.ReadLine().Split()));
            }
            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                try
                {
                    DriveOreRefuel.GetVehicleAtion(Console.ReadLine().Split(),vehicle);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }
            foreach (var vehicle1 in vehicle)
            {
                Console.WriteLine(vehicle1);
            }
        }
    }
}
