using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapW, int mapH)
        {
            wallList = new List<Figure>();

            HorizontalLine hUpLine = new HorizontalLine(0, mapW - 2, 0, '#');
            HorizontalLine hDownLine = new HorizontalLine(0, mapW - 2, mapH - 1, '#');
            VerticalLine vLeftLine = new VerticalLine(0, mapH - 1, 0, '#');
            VerticalLine vRightLine = new VerticalLine(0, mapH - 1, mapW - 2, '#');

            wallList.Add(hUpLine);
            wallList.Add(hDownLine);
            wallList.Add(vLeftLine);
            wallList.Add(vRightLine);
        }
            internal bool IsHit(Figure figure)
            {
                foreach(var wall in wallList)
                {
                    if (wall.IsHit(figure))
                    {
                        return true;
                    }
                }
                return false;
            }

            public void Draw()
            {
                foreach(var wall in wallList)
                {
                    wall.Draw();
                }
            }
        }
}
