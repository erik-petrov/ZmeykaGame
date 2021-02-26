using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ZmeykaGame
{
	class GameOver
	{
		private Program og = new Program();
		private string name;
		
		public GameOver(int score)
		{
			Console.Clear();
			Console.SetWindowSize(48, 8);
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Впишите свое имя: ");
			name = Console.ReadLine();
			StreamWriter f = new StreamWriter(@"..\..\..\Last.txt", true);
			f.WriteLine($"{name} - {score}");
			f.Close();
		}
		
		public void Ending()
		{
			Console.Clear();
			//int xOff = Program.mapX/5;
			//int yOff = (Program.mapY - 10)/3;
			int xOff = 6;
			int yOff = 12;
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
