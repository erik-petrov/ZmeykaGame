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

            int winH = 34;
            int winW = 80;

            /*Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            Console.SetWindowSize(winW, winH);

            Walls walls = new Walls(winW, winH);
            walls.Draw();


            FoodCreator foodCreator = new FoodCreator(winW, winH, '0');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Point p = new Point(4, 5, '/');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                if(walls.IsHit(snake)|| snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(50);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            GameOver();
            Console.ReadLine();

            static void GameOver()
            {
                int xOff = 25;
                int yOff = 8;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(xOff, yOff++);
                WriteText("=====================================", xOff, yOff++);
                WriteText("G A M E   O V E R", xOff + 10, yOff++);
                yOff++;
                WriteText("Cringe", xOff+14, yOff++);
                WriteText("Oh no.", xOff +1 , yOff++);
                WriteText("=====================================", xOff, yOff++);
            }
            
            static void WriteText(string text, int xOff, int yOff)
            {
                Console.SetCursorPosition(xOff, yOff);
                Console.WriteLine(text);
            }
        }
    }
}

