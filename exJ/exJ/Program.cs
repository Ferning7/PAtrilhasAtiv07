
using System;

namespace exJ
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] lojas = new string[8]
			{"C&A", "Youcom", "Renner", "Riachuelo",
				"Zara", "Adidas", "Nike", "Centauro"};
			
			string[] produtos = new string[4]
			{"Jaqueta de Couro", "Camisa de malha preta",
				"Tênis de Corrida", "Blusa de Frio azul"};
			
			double[,] precos = {
				{100.00, 79.99, 114.90, 118.90},
				{110.00, 59.99, 106.70, 114.90},
				{91.79, 69.99, 117.99, 111.90},
				{98.89, 80.99, 119.90, 112.90},
				{119.90, 49.99, 115.00, 100.90},
				{87.99, 79.59, 110.00, 99.90},
				{109.90, 85.99, 120.00, 110.90},
				{100.00, 79.99, 120.00, 115.90}
			};
			
			
			for (int i = 0; i < 8; i++) {
				Console.WriteLine("\nLoja: {0}", lojas[i]);
				
				for (int j = 0; j < 4; j++) {
					if (precos[i,j] < 120.00) {
						Console.WriteLine(" {0}:   R${1}", produtos[j], precos[i, j]);
					}
				}
			}
			Console.ReadKey(true);
		}
	}
}