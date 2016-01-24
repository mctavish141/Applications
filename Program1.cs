using System;

namespace Program1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string line1 = "Hello, World!";
			string line2 = "";
			foreach (char ch in line1) {
				if (Char.IsLetter (ch)) {
					if (Char.IsLower (ch)) {
						line2 = string.Concat (line2, Char.ToUpper (ch).ToString ());
					} else {
						line2 = string.Concat (line2, Char.ToLower (ch).ToString ());
					}
				} else {
					line2 = string.Concat (line2, ch.ToString ());
				}
			}
			Console.WriteLine (line2);
		}
	}
}
