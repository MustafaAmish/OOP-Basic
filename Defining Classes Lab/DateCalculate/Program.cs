using System;

namespace DateCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine();
            var second = Console.ReadLine();
            var date=new DateModifier(firstInput,second);
            Console.WriteLine(date.Days());
        }
    }
}
