using System;
class Program {
	static int Maior(int[,] mat){
		int maior = mat[0,0];
		for(int i = 0; i < mat.GetLength(0); i++)
			for(int j = 0; j < mat.GetLength(1); j++)
				if(mat[i, j] > maior)
					maior = mat[i, j];
		return maior;
	}// fim funcao maior
	
	static void Main(){
		Random rnd = new Random();

		Console.Write("Linhas: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Colunas: ");
		int m = int.Parse(Console.ReadLine());

		int[,] mat = new int[n, m];
		for(int i = 0; i < n; i++){
			for(int j = 0; j < m; j++){
				mat[i, j] = rnd.Next(0, 101);
				Console.Write(mat[i, j] + "\t");
			}
			Console.WriteLine();
		}
		Console.WriteLine("Maior valor: " + Maior(mat));
	}
	
}// fim do Program