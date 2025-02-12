
using System;

namespace exB
{
	class Program
	{
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			
			int[,] matriz = new int[10,10];
			
			Console.WriteLine("Matriz 10x10: ");
			
			for (int i = 0; i < 2; i++) {
				Console.WriteLine(" ");
				for (int j = 0; j < 10; j++) {
					matriz[i ,j] = int.Parse(Console.ReadLine());
				}
			}
			
			for (int i = 0; i < 10; i++) {
				
					if (i == i) {
						Console.Write(" "+matriz[i , i] );
					}
					
				}
			
			
			Console.ReadKey(true);
		}
	}
}