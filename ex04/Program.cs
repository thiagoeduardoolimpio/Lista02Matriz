using System;
class Program {
	static void Main(){
		Random rnd = new Random();

		Console.Write("Ordem da matriz: ");
		int n = int.Parse(Console.ReadLine());

		int[,] mat = new int[n, n];
		for(int i = 0; i < n; i++){
			for(int j = 0; j < n; j++){
				mat[i, j] = rnd.Next(0, 100);
				Console.Write(mat[i, j] + "\t");
			}
			Console.WriteLine();
		}

		Console.WriteLine("Diagonal secundaria:");
		for(int i = 0; i < n; i++)
			Console.Write(mat[i, n - 1 - i] + " ");
		Console.WriteLine();
	}
}// fim do Program
