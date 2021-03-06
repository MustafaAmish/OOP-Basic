﻿using System;
using System.Collections.Generic;

namespace Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        decimal.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);

                }


            }
            var teams = new Team("new");
            foreach (var person in persons)
            {
                teams.AddPlayer(person);
            }
            Console.WriteLine($"First team has {teams.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {teams.ReserveTeam.Count} players.");
        }
    }
}
