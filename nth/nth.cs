using System;
using System.Text;

namespace nth
{
	public class nth
	{
		public static double calcNth(Byte[] bArray, double seed, double offset = 0)
		{
			double nth = 0;
			for (long i = 0; i < bArray.Length; i++)
			{
				nth = nth + ((double)(bArray[i] + offset)) * Math.Pow(seed,i);
			}
			return nth;
		}

		public static double calcNthASCII(string sText, bool bCaseSensitive = true, int offset = 0)
		{
			if (!bCaseSensitive) sText = sText.ToUpper();

			Encoding ascii = Encoding.ASCII;
			Byte[] encodedBytes = ascii.GetBytes(sText);

			return calcNth(encodedBytes, 128D, offset);
		}

		public static double calcNthAlpha(string sText, bool bCaseSensitive = false)
		{
			// need to check bytes that are not Alpha characters
			if (!bCaseSensitive) sText = sText.ToUpper();

			Encoding ascii = Encoding.ASCII;
			Byte[] encodedBytes = ascii.GetBytes(sText);

			return calcNth(encodedBytes, 32D, -64);
		}

		public static double calcNthUTF8(string sText, bool bCaseSensitive = false)
		{
			// need to check bytes that are not Alpha characters
			if (!bCaseSensitive) sText = sText.ToUpper();

			Encoding utf8 = Encoding.UTF8;
			Byte[] encodedBytes = utf8.GetBytes(sText);

			return calcNth(encodedBytes, 2048D, -64);
		}
	}
}
