using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SWLoading
{
	internal static class Program
	{
		private static Stopwatch _stopwatch = new Stopwatch();

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		public static bool EnumThreadsForPid(int pID)
		{
			try
			{
				Process.GetProcessById(pID);
			}
			catch
			{
				return false;
			}
			return true;
		}

		[STAThread]
		private static void Main(string[] args)
		{
			if (args.Length <= 1)
			{
				return;
			}
			if (args[0] != "liongames_soulworker_startwork")
			{
				return;
			}
			int pID = int.Parse(args[1]);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (MainForm mainForm = new MainForm())
			{
				float fElapsedTime = 0f;
				mainForm.Left = Screen.PrimaryScreen.Bounds.Right / 2 - mainForm.Bounds.Right / 2;
				mainForm.Top = Screen.PrimaryScreen.Bounds.Bottom / 2 - mainForm.Bounds.Bottom / 2;
				mainForm.Show();
				bool flag = false;
				while (mainForm.Created)
				{
					if (!Program.EnumThreadsForPid(pID))
					{
						break;
					}
					Program._stopwatch.Restart();
					Thread.Sleep(10);
					Application.DoEvents();
					if (!flag)
					{
						flag = mainForm.Opening(fElapsedTime);
					}
					else
					{
						mainForm.Run(fElapsedTime);
					}
					Program._stopwatch.Stop();
					fElapsedTime = (float)Program._stopwatch.ElapsedMilliseconds * 0.001f;
				}
			}
		}
	}
}
