using System;
using System.Collections.Generic;
using System.Linq;

namespace  RectangleIntersection
{
    class RectangleIntersection
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectangles = new List<Rectangle>();
            for (int i = 0; i < input[0]; i++)
            {
                var regInfo = Console.ReadLine().Split();
                var id = regInfo[0];
                var width = double.Parse(regInfo[1]);
                var height = double.Parse(regInfo[2]);
                var x = double.Parse(regInfo[3]);
                var y = double.Parse(regInfo[4]);
                var reg=new Rectangle(id,width,height,x,y);
                rectangles.Add(reg);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var command = Console.ReadLine().Split();
                var check = rectangles.Where(x => x.Id == command[0]).First();
                var check1 = rectangles.Where(x => x.Id == command[1]).First();
                
                Console.WriteLine(Intersect(check1,check) ? "true" : "false");
            }
        }
        public static bool Intersect(Rectangle a, Rectangle b)
        {
            bool intersect = a.X+a.Width>=b.X&&
                a.X<=b.X+b.Width&&
                a.Y>=b.Y-b.Height&&
                a.Y-a.Height<=b.Y;
            
            return intersect;
        }
    }

}
