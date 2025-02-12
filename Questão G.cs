using System;

namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] matriz = {
                {1, 2, 3, 11},
                {4, 5, 6, 13}, 
                {7, 8, 9, 25},
                {10, 20, 30, 33}
            };

            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] % 2 == 0) //numero par
                    {
                        Console.Write(matriz[i, j] + "-par-\t");
                    }
                    else // Se o número for ímpar
                    {
                        Console.WriteLine(matriz[i, j] + " -ímpar-");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey(); 
        }
    }
}
