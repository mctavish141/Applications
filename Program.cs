using System;

namespace Matrix
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

			int dimension = 5;
			int maxNumber = 100;

			int [,]matrix = new int[dimension,dimension];
			for (int i = 0; i < dimension; i++) {
				for (int j = 0; j < dimension; j++) {
					matrix [i, j] = random.Next (0, maxNumber + 1);
				}
			}

			ShowMatrix (matrix, dimension);

			int sum = 0;
			int count = 0;
			for (int i = 0; i < dimension; i++) {
				for (int j = 0; j < dimension; j++) {
					if ((i != j) && (i + j != dimension - 1)) {
						count++;
						sum += matrix [i, j];
					}
				}
			}

			int average = sum / count;
			Console.WriteLine ("\nAverage: {0}", average);
		}
	}
}

