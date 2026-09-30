using System;
class Program {
	static void Main(){
		int n = int.Parse(Console.ReadLine());
		bool[,] mar = new bool[1001, 1001];

		for(int i = 0; i < n; i++){
			string[] p = Console.ReadLine().Split(' ');
			int xi = int.Parse(p[0]);
			int xf = int.Parse(p[1]);
			int yi = int.Parse(p[2]);
			int yf = int.Parse(p[3]);

			for(int x = xi; x <= xf; x++)
				for(int y = yi; y <= yf; y++)
					mar[x, y] = true;
		}

		int area = 0;
		for(int x = 0; x <= 1000; x++)
			for(int y = 0; y <= 1000; y++)
				if(mar[x, y])
					area++;

		Console.WriteLine(area);
	}
}// fim do Program