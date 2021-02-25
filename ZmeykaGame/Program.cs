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
        static int map;
        static int speed;
        public static int mapX;
        public static int mapY;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake: Another game\nPlease enter the speed of your snake");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, now enter the map size(3 for small, 2 for medium and 1 for large)");
            map = Convert.ToInt32(Console.ReadLine());
            Difficulty diff = new Difficulty(speed, map);
            diff.diffSet(speed, map);
            mapX = diff.mapX;
            mapY = diff.mapY;
            Console.Clear();
            //да, это много кода, я не знаю как его раскидать по функциям не ломая луп
            Walls walls = new Walls(mapX - 10, mapY);
            walls.Draw();

            FoodCreator foodCreator = new FoodCreator(mapX - 10, mapY, '0');
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
            GameOver over = new GameOver(score); //выводи скор, пж
            over.Ending();
            Console.ReadLine();
        }
    }
}

