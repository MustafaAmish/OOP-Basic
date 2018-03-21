using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Engin
{
    public static void Start()
    {
        var adoptet=new List<string>();
        var adoptetCentres=new List<AdoptionCenter>();
        var clinned=new List<string>();
        var clinnedCeneters=new List<CleansingCenter>();
        var castrationCenter=new List<CastrationCenter>();
        var castrationAnimals=new List<string>();
        string inputLine;
        while ((inputLine=Console.ReadLine())!= "Paw Paw Pawah")
        {
            var command = inputLine.Split(new string[]{" | "}, StringSplitOptions.RemoveEmptyEntries);
            var cmdArg = command[0];
            string name = null;
            if (command.Length>1)
            {
                name = command[1];
            }
            switch (cmdArg)
            {
                case "RegisterCleansingCenter":var clining=new CleansingCenter(name);
                    clinnedCeneters.Add(clining);
                    break;
                case "RegisterAdoptionCenter":var adop=new AdoptionCenter(name);
                    adoptetCentres.Add(adop);
                    break;
                case "RegisterDog":var dog=new Dog(name,int.Parse(command[2]), int.Parse(command[3]),command[4]);
                    adoptetCentres.First(n=>n.Name==command[4]).AddAnimal(dog);
                    break;
                case "RegisterCat":
                    var cat = new Cat(name, int.Parse(command[2]), int.Parse(command[3]), command[4]);
                    adoptetCentres.First(n => n.Name == command[4]).AddAnimal(cat);
                    break;
                case "SendForCleansing":
                    var forClining = adoptetCentres.First(c => c.Name == name);
                    var cliniin = clinnedCeneters.First(c => c.Name == command[2]);
                    cliniin.AddForClining(forClining.Animals);
                    break;
                case "Cleanse":
                    var clin = clinnedCeneters.First(c => c.Name == name);
                    foreach (var clinAnimal in clin.Animals)
                    {
                        clinned.Add(clinAnimal.Name);
                    }
                    clin.CliningAnimal();
                    break;
                case "Adopt":
                    var adopt = adoptetCentres.FirstOrDefault(c => c.Name == name);
                    if (adopt!=null)
                    {
                        foreach (var clinAnimal in adopt.Animals)
                        {
                            if (clinAnimal.Status)
                            {
                                adoptet.Add(clinAnimal.Name);
                            }
                        }
                    }
                    adopt.Adopt(adoptet);
                    break;
                case "RegisterCastrationCenter":var center=new CastrationCenter(name);
                    castrationCenter.Add(center);
                    break;
                case "SendForCastration": var adoptetCenter = adoptetCentres.FirstOrDefault(c => c.Name == name);
                    var centerCast = castrationCenter.FirstOrDefault(c => c.Name == command[2]);
                    if (adoptetCenter!=null&&centerCast!=null)
                    {
                        centerCast.AddAnimalCastration(adoptetCenter.Animals);
                    }
                    break;
                case "Castrate":var cst= castrationCenter.First(c => c.Name == name);
                    foreach (var cstAnimal in cst.Animals)
                    {
                        castrationAnimals.Add(cstAnimal.Name);
                    }
                    cst.Castration();
                    break;
                case "CastrationStatistics":var sbb=new StringBuilder();
                    sbb.AppendLine($"Paw Inc. Regular Castration Statistics")
                        .AppendLine($"Castration Centers: {castrationCenter.Count}");
                    if (castrationAnimals.Count!=0)
                    {
                        sbb.AppendLine($"Castrated Animals: {string.Join(", ", castrationAnimals.OrderBy(x => x))}");
                    }
                    else
                    {
                        sbb.AppendLine($"Castrated Animals: None");
                    }
                    Console.WriteLine(sbb.ToString().Trim());
                    break;


            }

        }

        var sb = new StringBuilder();
        sb.AppendLine($"Paw Incorporative Regular Statistics")
            .AppendLine($"Adoption Centers: {adoptetCentres.Count}")
            .AppendLine($"Cleansing Centers: {clinnedCeneters.Count}");
        if (adoptet.Count==0)
        {
            sb.AppendLine($"Adopted Animals: None");
        }
        else
        {
            sb.AppendLine($"Adopted Animals: {string.Join(", ", adoptet.OrderBy(x => x))}");
        }
        if (clinned.Count == 0)
        {
            sb.AppendLine($"Cleansed Animals: None");
        }
        else
        {
            sb.AppendLine($"Cleansed Animals: {string.Join(", ", clinned.OrderBy(x=>x))}");
        }
        int count = 0;
        foreach (var VARIABLE in adoptetCentres.SelectMany(x=>x.Animals))
        {
            if (VARIABLE.Status)
            {
                count++;
            }
        }
        sb.AppendLine($"Animals Awaiting Adoption: {count}");
        int coont = 0;
        foreach (var VARIABLE in clinnedCeneters.SelectMany(x => x.Animals))
        {
            if (!VARIABLE.Status)
            {
                coont++;
            }
        }
        sb.AppendLine($"Animals Awaiting Cleansing: {coont}");
        var result = sb.ToString().Trim();
        Console.WriteLine(result);

    }
}
