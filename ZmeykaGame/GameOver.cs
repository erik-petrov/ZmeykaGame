using System;
using System.Collections.Generic;
using System.Text;

namespace ZmeykaGame
{
    class GameOver
    {
        private Program og = new Program();
        
        public void Ending()
        {
            Console.Clear();
            int xOff = Program.mapX/5;
            int yOff = (Program.mapY - 10)/3;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xOff, yOff++);
            WriteText("=====================================", xOff, yOff++);
            WriteText("G A M E   O V E R", xOff + 10, yOff++);
            yOff++;
            WriteText("Cringe", xOff + 14, yOff++);
            WriteText("Oh no.", xOff + 1, yOff++);
            WriteText("=====================================", xOff, yOff++);
        }

        static void WriteText(string text, int xOff, int yOff)
        {
            Console.SetCursorPosition(xOff, yOff);
            Console.WriteLine(text);
        }
    }
}
