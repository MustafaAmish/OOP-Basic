using System;

namespace GrandPrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var raceTower = new RaceTower();
            var engine = new Engin(raceTower);
            engine.Start();
        }
    }
}
