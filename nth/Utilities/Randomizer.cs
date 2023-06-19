using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nth.Utilities
{
	public class Randomizer
	{
		private static HiPerfTimer pt = new HiPerfTimer();
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

		public static string[] createRandomStringArray(int strLen, int count)
		{
			string[] array = new string[count * strLen];
			int length = 0;

			pt.Start();
			for (int i = 0; i < strLen * count; i++)
			{
				if (i % count == 0)
					length++;
				array[i] = Randomizer.RandomStringAlpha(length);
			}
			pt.Stop();
			Console.WriteLine("Array Creation Duration: {0} sec\n", pt.Duration);
			return array;
		}

		public static List<string> RandomList(int strLen, int count)
		{
			int length = 0;
			List<string> list = new List<string>();

			pt.Start();
			for (int i = 0; i < strLen * count; i++)
			{
				if (i % count == 0)
					length++;
				list.Add(Randomizer.RandomStringAlpha(length));
			}
			pt.Stop();
			Console.WriteLine("List Creation Duration: {0} sec\n", pt.Duration);
			return list;
		}

		public static Byte[][] RandomByteArray(int strLen, int count)
		{
			pt.Start();
			Byte[][] bytes = new Byte[count * strLen][];
			for (int j = 1; j < strLen + 1; j++)
			{
				for (int i = ((j - 1) * count); i < (j * count); i++)
				{
					bytes[i] = new Byte[j];
					_random.NextBytes(bytes[i]);
				}
			}
			pt.Stop();
			Console.WriteLine("Byte Array Creation Duration: {0} sec\n", pt.Duration);
			return bytes;
		}

		public static Byte[][] RandomByteArray(int strLen, int count, int seed)
		{
			pt.Start();
			Random random = new Random();
			Byte[][] bytes = new Byte[count * strLen][];
			int j = 0;
			for (int i = 0; i < strLen * count; i++)
			{
				if (i % count == 0)
					j++;
				bytes[i] = new Byte[j];
				for (int k = 0; k < j; k++)
					bytes[i][k] = (Byte)Math.Floor(random.NextDouble() * seed);
			}
			pt.Stop();
			Console.WriteLine("Byte Array Creation Duration: {0} sec\n", pt.Duration);
			return bytes;
		}
	}
}