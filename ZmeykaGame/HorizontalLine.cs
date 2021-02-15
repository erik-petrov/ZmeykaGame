using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
