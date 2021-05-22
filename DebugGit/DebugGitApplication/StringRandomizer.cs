using System;
using System.Linq;

namespace DebugGitApplication
{
	public static class StringRandomizer
	{
		private static Random random;

		static StringRandomizer()
		{
			random = new Random();
		}

		public static string GetString(int length = 10)
		{
			return new string(Enumerable
				.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
				.Select(s => s[random.Next(s.Length)]).ToArray()
			);
		}
	}
}
