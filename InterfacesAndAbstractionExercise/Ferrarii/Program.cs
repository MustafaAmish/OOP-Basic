using System;

namespace Ferrarii
{
    class Program
    {
        static void Main(string[] args)
        {
           IFerrari car=new Ferrari(Console.ReadLine());
            Console.WriteLine(car);
        }
    }
}
