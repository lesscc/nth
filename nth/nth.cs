using System;
using System.Text;
using System.Collections.Generic;
using System.Numerics;

namespace nth
{
	public class nth
	{
		public static BigInteger calcNth(Byte[] bArray, int seed, int offset = 0)
		{
			BigInteger nth = 0;
			for (long i = 0; i < bArray.Length; i++)
			{
				nth = (nth * seed) + (bArray[i] + offset);
			}
			return nth;
		}

		public static List<BigInteger> calcNthArray(BigInteger nth, int seed, int offset = 0)
		{
			List<BigInteger> nthArray = new List<BigInteger>();
			while (nth > 0)
			{
				BigInteger remainder = nth % seed;
				nthArray.Add(remainder);
				nth = nth / seed;
			}
			return nthArray;
		}

		public static BigInteger calcNthASCII(string sText, bool bCaseSensitive = true, int offset = 0)
		{
			if (!bCaseSensitive) sText = sText.ToUpper();

			Encoding ascii = Encoding.ASCII;
			Byte[] encodedBytes = ascii.GetBytes(sText);

			return calcNth(encodedBytes, 128, offset);
		}

		public static BigInteger calcNthAlpha(string sText, bool bCaseSensitive = false)
		{
			// need to check bytes that are not Alpha characters
			if (!bCaseSensitive) sText = sText.ToUpper();

			Encoding ascii = Encoding.ASCII;
			Byte[] encodedBytes = ascii.GetBytes(sText);

			return calcNth(encodedBytes, 26, -64);
		}

		public static BigInteger calcNthUTF8(string sText, bool bCaseSensitive = false)
		{
			// need to check bytes that are not Alpha characters
			if (!bCaseSensitive) sText = sText.ToUpper();

			Encoding utf8 = Encoding.UTF8;
			Byte[] encodedBytes = utf8.GetBytes(sText);

			return calcNth(encodedBytes, 2048, -64);
		}
	}
}
