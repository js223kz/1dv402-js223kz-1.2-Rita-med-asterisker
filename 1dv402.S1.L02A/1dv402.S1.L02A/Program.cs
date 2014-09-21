using System;

namespace dv402.S1.L02A
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int rows = 0;
			int columns = 0;

			//row iteration
			for (rows = 0; rows < 25; rows++) { 
				Console.WriteLine ();

				//Modulus division returns the remainder. The remainder is always equal to 0 when you are at an even multiple.
				if ((rows+1) % 2 == 0) {
					Console.Write (" ");
				}
					
				switch (rows % 3) {
					case 0:
				
						Console.ForegroundColor = ConsoleColor.Yellow;
						break;

					case 1:

						Console.ForegroundColor = ConsoleColor.Magenta;
						break;
				
					case 2:
				
						Console.ForegroundColor = ConsoleColor.Green;
						break;

				}
				//column iteration
				for (columns = 0; columns < 39; columns++) { 
					Console.Write ("* ");

				}
			} 
		}
	}
}
