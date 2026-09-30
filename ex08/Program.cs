using System;
class Program {
	static void Main(){
		int n = int.Parse(Console.ReadLine());
		bool[,] caiu = new bool[501, 501];
		int resposta = 0;

		for(int i = 0; i < n; i++){
			string[] p = Console.ReadLine().Split(' ');
			int x = int.Parse(p[0]);
			int y = int.Parse(p[1]);

			if(caiu[x, y])
				resposta = 1;
			caiu[x, y] = true;
		}
		Console.WriteLine(resposta);
	}
}// fim do Program