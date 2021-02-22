using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class GameSetup
    {
        int speed;
        int map;

        public GameSetup()
        {
            Console.WriteLine("Welcome to Snake: Another game\nPlease enter the speed of your snake");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, now enter the map size(3 for small, 2 for medium and 1 for large)");
            map = Convert.ToInt32(Console.ReadLine());
            Difficulty diff = new Difficulty(speed, map);
            diff.diffSet(speed, map);
            Console.Clear();
        }
    }
}
