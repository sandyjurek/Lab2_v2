using System;
using System.Text;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "";
			string message = "";
			int checksum = 0;

			Console.WriteLine("What is your message?");

			input = Console.ReadLine();

			string inputUppercase = input.ToUpper();
			byte[] asciiValues = Encoding.ASCII.GetBytes(inputUppercase);

			for (int i = 0; i < asciiValues.Length; i++)
			{
				int temp = (int)asciiValues[i];

				message += (temp - (int)64);

				//this excludes the last dash

				if (i < asciiValues.Length - 1)
				{
					message += "-";
				}

				checksum += temp;
			}

			// Print 
			Console.WriteLine("Your encoded message is " + message);
			Console.WriteLine("Message checksum is " + checksum);
			Console.ReadLine();
		}
	}
}