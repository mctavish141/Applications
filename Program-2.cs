using System;

namespace Line
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string line = "  Hello, World!    @123 567   ";
			string newLine = "";

			bool newWord = true;
			bool newWordLetterOrDigit = true;

			for (int i = 0; i < line.Length; i++) {
				if (newWord == true) {
					if (char.IsLetterOrDigit (line [i])) {
						newLine = string.Concat (newLine, line [i].ToString ());
						newWord = false;
					} else {
						if (line [i] == ' ') {
							newWordLetterOrDigit = true;
						} else {
							newWord = false;
							newWordLetterOrDigit = false;
						}
					}
				} else {
					if (char.IsLetterOrDigit (line [i])) {
						if (newWordLetterOrDigit == true) {
							newLine = string.Concat (newLine, line [i].ToString ());
						}
					} else {
						if (newWordLetterOrDigit == true) {
							newLine = string.Concat (newLine, " ");
						}
						newWord = true;
						newWordLetterOrDigit = true;
					}
				}
			}

			Console.WriteLine (newLine);
		}
	}
}
