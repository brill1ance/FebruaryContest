using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		static void Main(string[] args)
		{
			// The solution implementation goes here
			
			Console.ForegroundColor = ConsoleColor.Green;
		
			//Console.WriteLine(new string(block, 30));

			for (int i= 0; i < 15; i++)
			{
				
				for (int x = 0; x < 30; x++)
				{
					if (i > 0 && i < 14)
						Console.ForegroundColor = (x > 0 && x < 29 ? ConsoleColor.Yellow : ConsoleColor.Green);
					Console.Write(block);
				}
				Console.WriteLine();
			}

			//Console.WriteLine(new string(block, 30));

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
