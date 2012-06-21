using System;
using System.Windows.Forms;

using nth.Utilities;
using System.Collections.Generic;
using System.Numerics;

namespace nth.Test
{
    public partial class nF_Main : Form
    {
        public nF_Main()
        {
            InitializeComponent();
        }

		private void nB_Calc_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			BigInteger value = nth.calcNthAlpha(nT_Text.Text, false);
			nT_NthValue.Text = value.ToString();
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
		}


		private void nB_Calc2_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();

			BigInteger nthValue;
			int seed;

			bool test = true;
			test &= BigInteger.TryParse(nT_NthValue2.Text, out nthValue);
			test &= int.TryParse(nT_Seed.Text, out seed);

			if (test)
			{
				if (seed > 1)
				{
					List<BigInteger> nthArray = nth.calcNthArray(nthValue, seed);

					string sNthArray = "";
					for (int i = 0; i < nthArray.Count; i++)
					{
						sNthArray += nthArray[i].ToString() + ",";
					}
					sNthArray = "[" + sNthArray.Substring(0, sNthArray.Length - 1) + "]";
					nT_NthArray.Text = sNthArray;
				}
				else
				{
					nT_NthArray.Text = "Seed value needs to be positive integer greater than 1.";
				}
			}
			else
			{
				nT_NthArray.Text = "Both values need to be an integer.";
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
		}

		private void nB_CalcASCII2_Click(object sender, EventArgs e)
		{
			nT_Seed.Text = "128";
			nB_Calc2_Click(sender, e);
		}

		private void nB_CalcASCII_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			BigInteger value = nth.calcNthASCII(nT_Text.Text, false);
			nT_NthValue.Text = value.ToString();
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
		}

		private void nB_TestAlpha1000_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 10; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					nth.calcNthAlpha(Randomizer.RandomStringAlpha(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestAlphaDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestAlphaMillion_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 10; i++)
			{
				for (long j = 1; j < 1000000; j++)
				{
					nth.calcNthAlpha(Randomizer.RandomStringAlpha(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestAlphaDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestAlpha1000x100_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 100; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					nth.calcNthAlpha(Randomizer.RandomStringAlpha(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestAlphaDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestAlphaMillionx100_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 100; i++)
			{
				for (long j = 1; j < 1000000; j++)
				{
					nth.calcNthAlpha(Randomizer.RandomStringAlpha(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestAlphaDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestAlphaBillion_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			string test = Randomizer.RandomStringAlpha(10);
			for (long j = 1; j < 1000000000; j++)
			{
				nth.calcNthAlpha(test, false);
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestAlphaDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestASCII1000_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 10; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					nth.calcNthASCII(Randomizer.RandomStringASCII(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestASCIIDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestASCIIMillion_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 10; i++)
			{
				for (long j = 1; j < 1000000; j++)
				{
					nth.calcNthASCII(Randomizer.RandomStringASCII(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestASCIIDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestASCII1000x100_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 100; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					nth.calcNthASCII(Randomizer.RandomStringASCII(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestASCIIDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestASCIIMillionx100_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 100; i++)
			{
				for (long j = 1; j < 1000000; j++)
				{
					nth.calcNthASCII(Randomizer.RandomStringASCII(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestASCIIDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestASCIIBillion_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			string test = Randomizer.RandomStringASCII(10);
			for (long j = 1; j < 1000000000; j++)
			{
				nth.calcNthASCII(test, false);
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestASCIIDuration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestUTF81000_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 10; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					nth.calcNthUTF8(Randomizer.RandomStringUTF8(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestUTF8Duration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestUTF8Million_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 10; i++)
			{
				for (long j = 1; j < 1000000; j++)
				{
					nth.calcNthUTF8(Randomizer.RandomStringUTF8(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestUTF8Duration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestUTF81000x100_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 100; i++)
			{
				for (int j = 1; j < 1000; j++)
				{
					nth.calcNthUTF8(Randomizer.RandomStringUTF8(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestUTF8Duration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestUTF8Millionx100_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			for (int i = 1; i < 100; i++)
			{
				for (long j = 1; j < 1000000; j++)
				{
					nth.calcNthUTF8(Randomizer.RandomStringUTF8(i), false);
				}
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestUTF8Duration.Text = DoubleConverter.ToExactString(pt.Duration);
		}

		private void nB_TestUTF8Billion_Click(object sender, EventArgs e)
		{
			HiPerfTimer pt = new HiPerfTimer();
			pt.Start();
			string test = Randomizer.RandomStringUTF8(10);
			for (long j = 1; j < 1000000000; j++)
			{
				nth.calcNthUTF8(test, false);
			}
			pt.Stop();
			Console.WriteLine("Calcuation Duration: {0} sec\n", pt.Duration);
			nT_TestUTF8Duration.Text = DoubleConverter.ToExactString(pt.Duration);
		}





    }
}
