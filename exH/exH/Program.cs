
using System;

namespace exH
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = new int[10, 10];
			Random rnd = new Random();
			int somaPri = 0;
			int somaSeq = 0;
			double mediaPri = 0;
			double mediaSeq = 0;
			
			Console.WriteLine("Insira valores inteiros para uma Matriz 10x10: ");
			
			Console.WriteLine("(L, C)");
			
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					Console.WriteLine("[{0},{1}]: ", i, j);
					 matriz[i, j] = int.Parse(Console.ReadLine());
				}
			}
			
			Console.WriteLine("Clique para continuar...");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("MATRIZ 10X10");
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 10; j++) {
					Console.Write("{0}  ", matriz[i, j]);
					
				}
			}
			
			// ============= PRINCIPAL ==============
			
			for (int i = 0; i < 10; i++) {
				somaPri += matriz[i, i];
			}
			
			mediaPri = somaPri / 10;
			
			
			Console.Write("\n\nDiagonal Principal: ");
			for (int i = 0; i < 10; i++) {
				Console.Write("{0} ", matriz[i, i]);
			}
			Console.WriteLine("\nSoma diagonal principal: {0}", somaPri);
			Console.WriteLine("Média diagonal principal: {0}", mediaPri);
			// ============= PRINCIPAL ==============
			
			
			
			
			// ============= SECUNDARIA ==============
			for (int i = 0; i < 10; i++) {
				somaSeq += matriz[i, 10 - 1 - i];
			}
			
			mediaSeq = somaSeq / 10;
			
			Console.Write("\n\nDiagonal Secundária: ");
			for (int i = 0; i < 10; i++) {
				Console.Write("{0} ", matriz[i, 10 - 1 -i]);
			}
			
			Console.WriteLine("\nSoma diagonal principal: {0}", somaSeq);
			Console.WriteLine("Média diagonal principal: {0}", mediaSeq);
			
			// ============= SECUNDARIA ==============
			
			Console.ReadKey(true);
		}
	}
}
