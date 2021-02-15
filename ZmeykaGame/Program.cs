using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZmeykaGame
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            HorizontalLine hUpLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine hDownLine = new HorizontalLine(0, 78, 24,'#');
            VerticalLine vLeftLine = new VerticalLine(0, 24, 0, '#');
            VerticalLine vRightLine = new VerticalLine(0, 24, 78, '#');
            hUpLine.Drow();
            vRightLine.Drow();
            vLeftLine.Drow();
            hDownLine.Drow();

            Point p = new Point(4, 5, '/');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(50);
                snake.Move();
            }
        }
    }
}

