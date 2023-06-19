using System;
using System.Text;

namespace nth.Test
{
	public static class Randomizer
	{
		private static Random _random = new Random();

		public static string RandomStringAlpha(int size)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < size; i++)
			{
				//26 letters in the alfabet, ascii + 65 for the capital letters
				builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * _random.NextDouble() + 65))));
			}
			return builder.ToString();
		}

		public static string RandomStringASCII(int size)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < size; i++)
			{
				//26 letters in the alfabet, ascii + 65 for the capital letters
				builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(128 * _random.NextDouble()))));
			}
			return builder.ToString();
		}

		public static string RandomStringUTF8(int size)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < size; i++)
			{
				//26 letters in the alfabet, ascii + 65 for the capital letters
				builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(2048 * _random.NextDouble()))));
			}
			return builder.ToString();
		}
	}
}
