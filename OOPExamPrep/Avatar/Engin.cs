using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engin
{
    public void Start()
    {
        var nations=new NationsBuilder();
        string inpuLine;
        bool isEnd = false;
        while (!isEnd)
        {
            inpuLine = Console.ReadLine();
            var command = inpuLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var cmd = command[0];
            command.RemoveAt(0);
            switch (cmd)
            {
                case "Bender":nations.AssignBender(command);
                    break;
                case "Monument":nations.AssignMonument(command);
                    break;
                case "Status":
                    Console.WriteLine(nations.GetStatus(command[0]));
                    break;
                case "War":nations.IssueWar(command[0]);
                    break;
                case "Quit":
                    Console.WriteLine(nations.GetWarsRecord());
                    isEnd = true;
                    break;
                
            }
        }
    }
}