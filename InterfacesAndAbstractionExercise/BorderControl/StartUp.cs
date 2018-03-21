using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var citizens=new List<Citizen>();
            var pets=new List<Pet>();
            string inputLine;
            while ((inputLine=Console.ReadLine())!="End")
            {
                var input = inputLine.Split();
                var type = input[0];
                if (type== "Citizen")
                {
                    var name = input[1];
                    var age = int.Parse(input[2]);
                    var id = input[3];
                    var birtday = input[4];
                    var person=new Citizen(name,age,id,birtday);
                    citizens.Add(person);
                    continue;
                }
                else if(type=="Pet")
                {
                    var pet=new Pet(input[1],input[2]);
                    pets.Add(pet);
                }
            }
            string numberIdCheck = Console.ReadLine();

            var bd = citizens.Where(x => x.Birthdate.EndsWith(numberIdCheck)).Select(x => x.Birthdate).ToList()
                .Concat(pets.Where(p => p.Birthdate.EndsWith(numberIdCheck)).Select(b => b.Birthdate).ToList());
            Console.WriteLine(string.Join(Environment.NewLine, bd));
        }
    }
}
