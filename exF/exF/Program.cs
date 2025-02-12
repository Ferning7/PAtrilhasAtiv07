
using System;

namespace exF
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[3, 3];
			Random rnd = new Random();
			int maior = 0;
			
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					matriz[i, j] = rnd.Next(1, 101);
				}
			}
			
			Console.WriteLine("Matriz 3x3 randomizada");
			
			for (int i = 0; i < 3; i++) {
				Console.WriteLine(" ");
				
				for (int j = 0; j < 3; j++) {
					Console.Write("{0} ", matriz[i, j]);
					
					if (matriz[i, j] > maior) {
						maior = matriz[i, j];
					}
					
				}
			}
			
			
			Console.WriteLine("\n\nO maior é: {0}", maior);
			Console.ReadKey(true);
		}
	}
}