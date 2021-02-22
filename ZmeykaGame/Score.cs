using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class Score
    {
        private int score;

        public Score(int score)
        {
            this.score = score;
            Console.SetCursorPosition(69, 2);
            Console.WriteLine($"Score: {score}");
        }
        public void oneUp()
        {
            score++;
        }
        public void scUpdate()
        {
            Console.SetCursorPosition(69, 2);
            Console.WriteLine($"Score: {score}");
        }
    }
}
