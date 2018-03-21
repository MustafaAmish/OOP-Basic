using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engin
{
    public void Start()
    {
        var drafManager=new DraftManager();
        bool isEnd = false;
        while (!isEnd)
        {
           var inputLine = Console.ReadLine().Split().ToList();
            var type = inputLine[0];
            inputLine.RemoveAt(0);

            switch (type)
            {
                case "RegisterHarvester":
                    Console.WriteLine(drafManager.RegisterHarvester(inputLine));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(drafManager.RegisterProvider(inputLine));
                    break;
                   case "Day":
                    Console.WriteLine(drafManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(drafManager.Mode(inputLine));
                    break;
                case "Check":
                    Console.WriteLine(drafManager.Check(inputLine));
                    break;
                case "Shutdown":
                    Console.WriteLine(drafManager.ShutDown());
                    isEnd = true;
                    break;
            }


        }
    }

}
