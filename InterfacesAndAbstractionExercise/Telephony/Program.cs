using System;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var url = Console.ReadLine().Split();
            var smatrphone=new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(smatrphone.Call(number));
            }
            foreach (var s in url)
            {
                Console.WriteLine(smatrphone.Browsing(s));
            }
        }
    }
}
