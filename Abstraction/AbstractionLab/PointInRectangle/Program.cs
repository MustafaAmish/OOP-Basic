using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangle=new Rectangle(points);
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rectangle.Contains(Console.ReadLine().Split().Select(int.Parse).ToArray()));
            }
        }
    }
}
