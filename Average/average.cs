using System;

namespace Average
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int value = 0;
			string input;
			double count = 0;
			double sum = 0;
			double average = 0;


			while (value != -999)
			{
				Console.WriteLine("Enter a number");
				input = Console.ReadLine();
				value = int.Parse(input);

				if (value != -999)
				{
					count += 1;
					sum += value;

					average = sum / count;
				}
			}

			Console.WriteLine("The average is " + average);
		}
	}
}
