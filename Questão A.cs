using System;

namespace Project
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] matriz = {
	
				{1, 2, 3},
				{4, 5, 6}, 
				{7, 8, 9}
			
			};
				for (int i = 0; i < 3; i++)
				
			{ // Percorre as linhas
				for (int j = 0; j < 3; j++)
				
			{ // Percorre as colunas
		
		Console.Write(matriz [i, j] + " ");
	} 
	
		Console.WriteLine();
	}
		Console.ReadKey();
		}
	}
}
