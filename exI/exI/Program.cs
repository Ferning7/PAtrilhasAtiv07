
using System;

namespace exI
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[,] matriz = new int[10,10];
			Random rnd = new Random();
			
			Console.WriteLine("Insira valores inteiros na Matriz 10x10");
			Console.WriteLine("[L, C]");
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					Console.WriteLine("[{0},{1}]: ", i, j);
					// matriz[i, j] = int.Parse(Console.ReadLine());
					matriz[i, j] = rnd.Next(1, 10);
				}
			}
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("MATRIZ 10X10");
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 10; j++) {
					Console.Write("{0}  ", matriz[i, j]);
					
				}
			}
			
			Console.ReadKey(true);
		}
	}
}