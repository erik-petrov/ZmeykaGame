using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//крч исправь пж ничо не робит я не умею думать, ещё музыку найди
namespace ZmeykaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSetup game = new GameSetup();
            int winH = diff.mapY;
            int winW = diff.mapX;

            Console.SetWindowSize(diff.mapX + 10, diff.mapY);

            Walls walls = new Walls(diff.mapX, diff.mapY);
            walls.Draw();

            FoodCreator foodCreator = new FoodCreator(diff.mapX, diff.mapY, '0');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(0);

            Point p = new Point(4, 5, '/');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.oneUp();
                    score.scUpdate();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(diff.snSpeed);
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

