using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class Difficulty
    {
        public int speed;
        public int mapSize;
        public int mapX;
        public int mapY;
        public int snSpeed;

        public Difficulty(int speed, int mapSize)
        {
            this.speed = speed;
            this.mapSize = mapSize;
        }
        public Difficulty()
        {

        }
        public void diffSet(int speed, int mapSize)
        {
            switch (speed)
            {
                case 1:
                    snSpeed = 150;
                    break;
                case 2:
                    snSpeed = 100;
                    break;
                case 3:
                    snSpeed = 50;
                    break;
            }
            switch (mapSize)
            {
                case 1:
                    mapX = Console.LargestWindowWidth - 10;
                    mapY = Console.LargestWindowHeight - 10;
                    Console.SetWindowSize(mapX, mapY);
                    break;
                case 2:
                    mapX = 80;
                    mapY = 34;
                    Console.SetWindowSize(mapX + 8, mapY);
                    break;
                case 3:
                    mapX = 40;
                    mapY = 17;
                    Console.SetWindowSize(mapX + 3, mapY);
                    break;
            }
            
        }
    }
}
