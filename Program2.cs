using System;

namespace Program2
{
	class MainClass
	{
		public static void ShowMatrix (int[,] matrix, int dimension) {
			for (int i = 0; i < dimension; i++) {
				for (int j = 0; j < dimension; j++) {
					Console.Write (matrix [i, j]);
					Console.Write (" ");
				}
				Console.WriteLine ();
			}
		}
		public static void Main (string[] args)
		{
			Random random = new Random ();

			int dimension = 7;
			int maxNumber = 100;

			int [,]matrix = new int[dimension,dimension];
			for (int i = 0; i < dimension; i++) {
				for (int j = 0; j < dimension; j++) {
					matrix [i, j] = random.Next (0, maxNumber + 1);
				}
			}

			ShowMatrix (matrix, dimension);

			int sum = 0;
			for (int i = 0; i < dimension; i++) {
				sum += matrix [i, dimension - i - 1];
			}
			
			Console.WriteLine (sum);
		}
	}
}
