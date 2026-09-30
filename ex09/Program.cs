using System;
class Program {
	static void Main(){
		Random rnd = new Random();

		Console.Write("Numero de regioes: ");
		int r = int.Parse(Console.ReadLine());
		Console.Write("Numero de cidades por regiao: ");
		int c = int.Parse(Console.ReadLine());

		int[,] tropas = new int[r, c];
		for(int i = 0; i < r; i++)
			for(int j = 0; j < c; j++)
				tropas[i, j] = rnd.Next(0, 101);

		Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
		for(int i = 0; i < r; i++){
			Console.Write("Regiao " + (i + 1) + ": ");
			for(int j = 0; j < c; j++)
				Console.Write(tropas[i, j] + " ");
			Console.WriteLine();
		}

		Console.WriteLine("Forca Total das Regioes:");
		for(int i = 0; i < r; i++){
			int soma = 0;
			for(int j = 0; j < c; j++)
				soma += tropas[i, j];
			Console.WriteLine("Regiao " + (i + 1) + ": " + soma + " tropas");
		}
	}
}// fim do Program