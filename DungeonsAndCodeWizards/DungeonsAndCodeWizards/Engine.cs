using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards
{
  public  class Engine
    {
        public void Start()
        {
            var dungeon=new DungeonMaster();
            bool game = false;
            while (!game)
            {
                try
                {
                    var inputLine = Console.ReadLine().Split();
                    var command = inputLine[0];
                    var args = inputLine.Skip(1).ToArray();
                    switch (command)
                    {
                        case "JoinParty": Console.WriteLine(dungeon.JoinParty(args));
                            break;
                        case "AddItemToPool": Console.WriteLine(dungeon.AddItemToPool(args));
                            break;
                        case "PickUpItem": Console.WriteLine(dungeon.PickUpItem(args));
                            break;
                        case "UseItem": Console.WriteLine(dungeon.UseItem(args));
                            break;
                        case "UseItemOn": Console.WriteLine(dungeon.UseItemOn(args));
                            break;
                        case "GiveCharacterItem": Console.WriteLine(dungeon.GiveCharacterItem(args));
                            break;
                        case "GetStats": Console.WriteLine(dungeon.GetStats());
                            break;
                        case "Attack": Console.WriteLine(dungeon.Attack(args));
                            break;
                        case "Heal": Console.WriteLine(dungeon.Heal(args));
                            break;
                        case "EndTurn": Console.WriteLine(dungeon.EndTurn(args));
                            game = dungeon.IsGameOver();
                            if (game)
                            {
                                Console.WriteLine($"Final stats:");
                                Console.WriteLine(dungeon.GetStats());
                            }
                            break;
                        case "IsGameOver": game=dungeon.IsGameOver();
                            Console.WriteLine($"Final stats:");
                            Console.WriteLine(dungeon.GetStats());
                            break;
                            default:
                                game = true;
                                Console.WriteLine($"Final stats:");
                                Console.WriteLine(dungeon.GetStats());
                            break;

                    }
                    //if (string.IsNullOrWhiteSpace(command))
                    //{
                    //    game = true;
                    //    Console.WriteLine($"Final stats:");
                    //    Console.WriteLine(dungeon.GetStats());
                    //}
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Parameter Error: " + e.Message);
                    
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine("Invalid Operation: " + e.Message);

                }
            }
        }
    }
}
