using System;
class Program {
	static void Imprimir(double[,] mat){
		for(int i = 0; i < mat.GetLength(0); i++){
			for(int j = 0; j < mat.GetLength(1); j++)
				Console.Write(mat[i, j] + "\t");
			Console.WriteLine();
		}
	}// fim funcao imprimir
	static void Main(){
		Random rnd = new Random();

		Console.Write("Linhas: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Colunas: ");
		int m = int.Parse(Console.ReadLine());

		double[,] a = new double[n, m];
		double[,] b = new double[n, m];
		for(int i = 0; i < n; i++){
			for(int j = 0; j < m; j++){
				a[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
				b[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
			}
		}

		string op;
		do{
			Console.WriteLine("(a) Somar  (b) Subtrair  (c) Somar constante  (d) Imprimir  (s) Sair");
			op = Console.ReadLine();

			if(op == "a"){
				double[,] c = new double[n, m];
				for(int i = 0; i < n; i++)
					for(int j = 0; j < m; j++)
						c[i, j] = a[i, j] + b[i, j];
				Imprimir(c);
			}
			else if(op == "b"){
				double[,] c = new double[n, m];
				for(int i = 0; i < n; i++)
					for(int j = 0; j < m; j++)
						c[i, j] = b[i, j] - a[i, j];
				Imprimir(c);
			}
			else if(op == "c"){
				Console.Write("Constante: ");
				double k = double.Parse(Console.ReadLine());
				for(int i = 0; i < n; i++){
					for(int j = 0; j < m; j++){
						a[i, j] += k;
						b[i, j] += k;
					}
				}
			}
			else if(op == "d"){
				Console.WriteLine("Matriz A:");
				Imprimir(a);
				Console.WriteLine("Matriz B:");
				Imprimir(b);
			}
		}while(op != "s");
	}
}// fim do Program