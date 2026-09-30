using System;
class Program {
	static int Contar(int[,] mat, int x){
		int cont = 0;
		for(int i = 0; i < mat.GetLength(0); i++)
			for(int j = 0; j < mat.GetLength(1); j++)
				if(mat[i, j] == x)
					cont++;
		return cont;
	}// fim funcao contar
	static void Main(){
		Random rnd = new Random();

		Console.Write("Linhas: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Colunas: ");
		int m = int.Parse(Console.ReadLine());

		int[,] mat = new int[n, m];
		for(int i = 0; i < n; i++){
			for(int j = 0; j < m; j++){
				mat[i, j] = rnd.Next(0, 10);
				Console.Write(mat[i, j] + "\t");
			}
			Console.WriteLine();
		}

		Console.Write("Valor de X: ");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("O valor " + x + " aparece " + Contar(mat, x) + " vez(es)");
	}
}// fim do Program