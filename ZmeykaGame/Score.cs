using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class Score
    {
        private int score;
        public Program og = new Program();

        public Score(int score,int mapX)
        {
            this.score = score;
            Console.SetCursorPosition(Program.mapX - 8, 2);
            Console.WriteLine($"Score: {score}");
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
    }
}
