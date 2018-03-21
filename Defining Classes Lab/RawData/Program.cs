using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < inputCount; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                var carName = input[0];
                var engen = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]), input[4]);
                var tires = new Tire[]
                {
                    new Tire(double.Parse(input[6]), double.Parse(input[5])),
                    new Tire(double.Parse(input[8]), double.Parse(input[7])),
                    new Tire(double.Parse(input[10]), double.Parse(input[9])),
                    new Tire(double.Parse(input[12]), double.Parse(input[11])),
                };
                var car = new Car(carName, engen, cargo, tires);
                cars.Add(car);
            }
            var comand = Console.ReadLine();
            if (comand == "fragile")
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.Where(c => c.Cargo.Type == "fragile").Where(c => c.Tires.Where(t => t.TirePressure < 1).FirstOrDefault() != null).Select(c => c.Model)));

            }
            else
            {
               
                foreach (var car in  cars.Where(c => c.Cargo.Type == "flamable").Where(c => c.Engine.EnginePower >= 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
