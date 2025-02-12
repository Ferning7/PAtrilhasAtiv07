
using System;

namespace exA
{
	class Program
	{
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			
			int[,] matriz = new int[3,3];
			
			Console.WriteLine("Matriz 3x3: ");
			
			for (int i = 0; i < 3; i++) {
				Console.WriteLine(" ");
				
				for (int j = 0; j < 3; j++) {
					matriz[i ,j] = rnd.Next(1, 9);
					Console.Write(" "+matriz[i ,j] );
				}
			}
			
			Console.ReadKey(true);
		}
	}
}