using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class CarSalesman
    {
        static void Main(string[] args)
        {
            int numEng = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            for (int i = 0; i < numEng; i++)
            {
                var eng = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = eng[0];
                var power = int.Parse(eng[1]);
                if (eng.Length==4)
                {
                    var displanement = int.Parse(eng[2]);
                    var efficiency = eng[3];
                    var engAdd=new Engine(model,power,displanement,efficiency);
                    engines.Add(engAdd);
                    continue;
                }
                if (eng.Length==3)
                {
                    int displanement;
                    bool check = int.TryParse(eng[2], out displanement);
                    if (!check)
                    {
                        var engAdd=new Engine(model,power,eng[2]);
                        engines.Add(engAdd);
                        continue;
                    }
                    var engAddd = new Engine(model, power, displanement);
                    engines.Add(engAddd);
                    continue;
                }
                var engg=new Engine(model,power);
                engines.Add(engg);
            }

            int carModelCount = int.Parse(Console.ReadLine());
              
            var cars=new List<Car>();
            for (int i = 0; i < carModelCount; i++)
            {
                var car = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = car[0];
                var eng = engines.FirstOrDefault(x => x.Model==car[1]);
                if (car.Length==4)
                {
                    var weight = int.Parse(car[2]);
                    var color = car[3];
                   var carr = new Car(model,eng,weight,color);
                    cars.Add(carr);
                    continue;
                }
                if (car.Length==3)
                {
                    int weight;
                    bool isDigit = int.TryParse(car[2], out weight);
                    if (!isDigit)
                    {
                        var carr=new Car(model,eng,car[2]);
                        cars.Add(carr);
                        continue;  
                    }
                    var caar=new Car(model,eng,weight);
                    cars.Add(caar);
                    continue;
                }
                var carrr=new Car(model,eng);
                cars.Add(carrr);
            }
            foreach (var car in cars)
            {

                Console.WriteLine(car.ToString());
            }
        }
    }
}
