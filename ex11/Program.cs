using System;
class Program {
	static void Main(){
		Random rnd = new Random();

		Console.Write("Tamanho N da matriz: ");
		int n = int.Parse(Console.ReadLine());

		int[,] mapa = new int[n, n];
		Console.WriteLine("Mapa do Tesouro (Quantidade de moedas em cada regiao):");
		for(int i = 0; i < n; i++){
			for(int j = 0; j < n; j++){
				mapa[i, j] = rnd.Next(1, 101);
				Console.Write(mapa[i, j] + "\t");
			}
			Console.WriteLine();
		}

		int principal = 0;
		int secundaria = 0;
		for(int i = 0; i < n; i++){
			principal += mapa[i, i];
			secundaria += mapa[i, n - 1 - i];
		}

		Console.WriteLine("Soma da Diagonal Principal: " + principal);
		Console.WriteLine("Soma da Diagonal Secundaria: " + secundaria);

		if(principal > secundaria)
			Console.WriteLine("O maior tesouro esta na diagonal principal, vamos para la ");
		else if(secundaria > principal)
			Console.WriteLine("O maior tesouro esta na diagonal secundaria, vamos para la ");
		else
			Console.WriteLine("As duas diagonais tem a mesma quantidade de moedas ");
	}
}// fim do Program