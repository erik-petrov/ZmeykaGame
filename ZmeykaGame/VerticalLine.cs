using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void ddrow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
