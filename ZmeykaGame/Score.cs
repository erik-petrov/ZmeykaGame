﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class Score
    {
        public int score;
        public Program og = new Program();

        public Score(int score)
        {
            this.score = score;
            Console.SetCursorPosition(Program.mapX - 8, 2);
            Console.WriteLine($"Score: {score}");
        }
        public Score()
        {

        }
        public void oneUp()
        {
            score++;
        }
        public void scUpdate()
        {
            Console.SetCursorPosition(Program.mapX - 8, 2);
            Console.WriteLine($"Score: {score}");
        }
        public void paused()
        {
            Console.SetCursorPosition(Program.mapX - 8, 2);
            Console.WriteLine("PAUSED..");
        }
    }
}
