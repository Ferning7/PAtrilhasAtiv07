
using System;

namespace exD
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[10, 10];
			
			Random rnd = new Random();
			Console.WriteLine("Insira valores para uma matriz 10x10: ");
			
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					
					Console.WriteLine("Elemento [{0} , {1}]: ", i+1, j+1);
					//matriz[i, j] = int.Parse(Console.ReadLine());
					matriz[i, j] = rnd.Next(1, 9);
				}
			}
			
			Console.ReadKey(true);
			Console.Clear();
			
		
			
			Console.WriteLine("\nMatriz 10x10: ");
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 10; j++) {
					Console.Write(" "+matriz[i, j]);
				}
			}
			
				Console.WriteLine("\n\nAperte uma tecla para mostrar a diagonal");
			Console.ReadKey(true);
			Console.WriteLine("\n\nElementos da Diagonal Principal:");
			for (int i = 0; i < 10; i++)
			{
				Console.Write(" {0}", matriz[i, i]);
			}

			Console.ReadKey(true);
			
		}
	}
}