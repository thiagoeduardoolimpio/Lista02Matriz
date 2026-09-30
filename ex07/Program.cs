using System;
class Program {
	
	static int[,] Gerar(int n, int m){
		Random rnd = new Random();
		int[,] mat = new int[n, m];
		for(int i =0; i < n; i++)
			for(int j = 0; j < m; j++)
				mat[i, j] = rnd.Next(0, 10);
		return mat;
	}// fim funcao gerar
	
	static void Somar(int[,] a, int[,] b){
		if(a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1)){
			Console.WriteLine("As matrizes nao tem a mesma ordem!");
			return;
		}

		int[,] c = new int[a.GetLength(0), a.GetLength(1)];
		for(int i = 0; i < c.GetLength(0); i++){
			for(int j = 0; j < c.GetLength(1); j++){
				c[i, j] = a[i, j] + b[i, j];
				Console.Write(c[i, j] + "\t");
			}
			Console.WriteLine();
		}
		
	}// fim funcao somar
	static void Main(){
		Console.Write("Linhas da matriz 1: ");
		int n1 = int.Parse(Console.ReadLine());
		Console.Write("Colunas da matriz 1: ");
		int m1 = int.Parse(Console.ReadLine());
		Console.Write("Linhas da matriz 2: ");
		int n2 = int.Parse(Console.ReadLine());
		Console.Write("Colunas da matriz 2: ");
		int m2 = int.Parse(Console.ReadLine());

		Somar(Gerar(n1, m1), Gerar(n2, m2));
	}
	
}// fim do Program