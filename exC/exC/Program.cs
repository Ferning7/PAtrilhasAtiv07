
using System;

namespace exC
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[,] matriz = new int[4, 2];
			int soma = 0;
			
			Random rnd = new Random();
			
			Console.WriteLine("Matriz 4x2 gerada com Random");
			for (int i = 0; i < 4; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 2; j++) {
					matriz[i ,j] = rnd.Next(1, 11);
					Console.Write("  " + matriz[i, j]);
					soma += matriz[i, j];
					
				}
			}
			Console.WriteLine("\n\nA soma de todos valores desta matriz: "+soma);
			Console.ReadKey(true);
		}
	}
}