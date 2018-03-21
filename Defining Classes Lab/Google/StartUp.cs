using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var perssons = new List<Persson>();
            string inpuLine;
            while ((inpuLine=Console.ReadLine())!="End")
            {
                var input = inpuLine.Split().Select(x => x.Trim()).ToArray();
                var name = input[0];
                var currentPerson = perssons.Where(p => p.Name == name).FirstOrDefault();
                var person=new Persson(name);
                if (currentPerson==null)
                {
                    perssons.Add(person);
                }
                currentPerson = perssons.Where(p => p.Name == name).FirstOrDefault();
                var categori = input[1].ToLower();
                switch (categori)
                {
                    case "car":
                        var car = new Car(input[2], int.Parse(input[3]));
                        currentPerson.Car = car;
                        break;
                    case "company":
                        var cmp = new Company(input[2], decimal.Parse(input[4]), input[3]);
                        currentPerson.Company = cmp;
                        break;
                    case "pokemon":
                        var pkmn = new Pokemon(input[2], input[3]);
                        currentPerson.Pokemons.Add(pkmn);
                        break;
                    case "parents": var parent = new Parents(input[2],input[3]);
                        currentPerson.Parentses.Add(parent);
                        break;
                    case "children":var children=new Children(input[2], input[3]);
                        currentPerson.Childrens.Add(children);
                        break;
                }
            }
            inpuLine = Console.ReadLine().Trim();
            var personn = perssons.FirstOrDefault(p => p.Name == inpuLine);
            if (personn!=null)
            {
                Console.Write(personn.ToString());
            }
        }
    }
}
