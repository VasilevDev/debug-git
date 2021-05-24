using System;
using System.Collections.Generic;

namespace DebugGitApplication
{
	/// <summary>
	/// Program
	/// </summary>
	class Program
	{
		/// <summary>
		/// Main
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("Application started...");
			Console.ReadLine();
		}

		private static IEnumerable<string> GetRandomStrings(int stringCount, int stringSymbolCount = 30)
		{
			for (int i = 0; i < stringCount; i++)
				yield return StringRandomizer.GetString(stringSymbolCount);
		}

		private static void ShowStringsOnConsole(IEnumerable<string> values)
		{
			foreach (var value in values)
				Console.WriteLine(value);
		}
	}
}
