using System;
using System.Windows.Forms;

using nth.Utilities;

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
			double value = nth.calcNthAlpha(nT_Text.Text, false);
			nT_nthValue.Text = DoubleConverter.ToExactString(value);
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
