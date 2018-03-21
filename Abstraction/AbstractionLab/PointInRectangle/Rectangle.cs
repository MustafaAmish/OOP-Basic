using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    class Rectangle
    {
        public Point TopLeftXY { get; private set; }
        public Point bottomLeftXY { get; private set; }

        public Rectangle(int[] poInts)
        {
            TopLeftXY=new Point(poInts[0],poInts[1]);
            bottomLeftXY=new Point(poInts[2],poInts[3]);
        }

        public bool Contains(int[] poInts)
        {
            return (TopLeftXY.Y <= poInts[1] && bottomLeftXY.Y >= poInts[1]) &&
                   (TopLeftXY.X <= poInts[0] && bottomLeftXY.X >= poInts[0]);
        }
    }
}
