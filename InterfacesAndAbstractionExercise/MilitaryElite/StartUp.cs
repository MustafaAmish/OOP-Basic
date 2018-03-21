using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryElite.Interface;
using MilitaryElite.Soldiers;

namespace MilitaryElite
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var soldiers = new List<ISoldier>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    var soldierInput = input.Split();
                    var id = int.Parse(soldierInput[1]);
                    var firstName = soldierInput[2];
                    var lastName = soldierInput[3];
                    var sodierType = soldierInput[0];
                    var salary = decimal.Parse(soldierInput[4]);

                    ISoldier sodier = null;
                    switch (sodierType)
                    {
                        case "Private":
                            sodier = new Private(id, firstName, lastName, salary);
                            ;
                            break;
                        case "Spy":
                            sodier = new Spy(id, firstName, lastName, int.Parse(soldierInput[4]));

                            break;
                        case "LeutenantGeneral":
                            var general = new LeutenantGeneral(id, firstName, lastName, salary);
                            for (int i = 5; i < soldierInput.Length; i++)
                            {
                                int iid = int.Parse(soldierInput[i]);
                                ISoldier bbSoldier = soldiers.First(x => x.Id == iid);
                                general.AddPrivate(bbSoldier);
                            }

                            sodier = general;
                            break;
                        case "Engineer":
                            var eng = new Engineer(id, firstName, lastName, salary, soldierInput[5]);
                            for (int i = 6; i < soldierInput.Length; i++)
                            {
                                try
                                {

                                    string partName = soldierInput[i];
                                    int hourWorked = int.Parse(soldierInput[++i]);
                                    IRepair repeir = new Repair(partName, hourWorked);
                                    eng.AddRepiar(repeir);
                                }
                                catch { }
                            }
                            sodier = eng;
                            break;
                        case "Commando":

                            var commando = new Commando(id, firstName, lastName, salary, soldierInput[5]);
                            for (int i = 6; i < soldierInput.Length; i++)
                            {

                                try
                                {
                                    string codeName = soldierInput[i];
                                    string state = soldierInput[++i];
                                    IMission mission = new Mission(codeName, state);
                                    commando.AddMision(mission);

                                }
                                catch
                                {

                                }
                            }
                            sodier = commando;
                            break;
                        default:throw new ArgumentException();
                    }
                    soldiers.Add(sodier);
                }
                catch { }
                
            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
