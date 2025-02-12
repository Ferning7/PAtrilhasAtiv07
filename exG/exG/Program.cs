
using System;

namespace exG
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[4, 4];
			Random rnd = new Random();
			
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 4; j++) {
					matriz[i, j] = rnd.Next(1, 10);
				}
			}
			
			
			Console.WriteLine("Exibindo apenas os valores pares da matriz 4x4 gerada com random:");
			for (int i = 0; i < 4; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 4; j++) {
					if (matriz[i, j] % 2 == 0) {
						Console.Write("{0} ", matriz[i, j]);
					}
					
				}
			}
			Console.ReadKey(true);
		}
	}
}