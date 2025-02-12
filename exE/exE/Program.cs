
using System;

namespace exE
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[,] matriz = new double[2,2];
			Random rnd = new Random();
			double media = 0;
			Console.WriteLine("Insira valores decimais na matriz 2x2: ");
			
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j < 2; j++) {
					Console.Write("Elemento [{0},{1}] ",i, j);
					matriz[i, j] = double.Parse(Console.ReadLine());
					media += (matriz[i, j])/4;
				}
			}
			
			for (int i = 0; i < 2; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 2; j++) {
					Console.Write("{0} ", matriz[i, j]);
					
				}
			}
			
			Console.WriteLine("\n\nMédia da matriz: {0}", media);
			
			
			Console.ReadKey(true);
		}
	}
}