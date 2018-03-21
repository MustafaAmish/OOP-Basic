using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int inputCarNumber = int.Parse(Console.ReadLine());
            var cars = new List<Car>(); 
            for (int i = 0; i < inputCarNumber; i++)
            {
                var inputCar = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var car =new Car(inputCar[0],double.Parse(inputCar[1]),double.Parse(inputCar[2]));
                cars.Add(car);
            }
            string inpitLine;
            while ((inpitLine=Console.ReadLine())!="End")
            {
                var commad=inpitLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var car in cars.Where(x=>x.Model==commad[1]))
                {
                    car.CarMuve(car.Model,double.Parse(commad[2]));
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,cars.Select(c=>$"{c.Model} {c.FuelAmount:F} {c.Distance}")));
        }
    }
}
