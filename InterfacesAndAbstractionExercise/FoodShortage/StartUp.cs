using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfBayers = int.Parse(Console.ReadLine());
            var society = new List<Society>();
            for (int i = 0; i < numberOfBayers; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                if (input.Length==3)
                {
                    var group = input[2];
                    var rebel=new Rebel(name,age,group);
                    society.Add(rebel);
                    continue;
                }
                else if (input.Length==4)
                {
                    var id = input[2];
                    var birthdate = input[3];
                    var citizen=new Citizen(name,age,id,birthdate);
                    society.Add(citizen);
                }
            }
            string inputLine;
            while ((inputLine=Console.ReadLine())!="End")
            {
                try
                {
                    society.First(s=>s.Name==inputLine).BuyFood();
                }
                catch 
                {
                    
                }
            }
            Console.WriteLine(society.Sum(x => x.Food));
        }
    }
}
