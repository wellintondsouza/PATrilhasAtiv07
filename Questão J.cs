using System;

class Program
{
    static void Main()
    {
        string[] lojas = new string [8];

        Console.WriteLine("Escreva os 8 nomes das lojas:");
        for (int i = 0; i < 8; i++) {
            Console.WriteLine("Loja {0}", i + 1);
            lojas[i] = Console.ReadLine();
        }

        string[] produtos = new string[4];
        Console.WriteLine("Digite os nomes dos 4 produtos:");
        for (int i = 0; i < 4; i++){
            Console.WriteLine("Produtos {0}", i + 1);
            produtos[i] = Console.ReadLine();
        }
        double [,] precos = new double [8, 4];
        Console.WriteLine("Digite os valores dos produtos:");
        for (int L = 0; L < 8; L++){
            for (int C = 0; C < 4; C++){
                Console.WriteLine("Preço dos produto {0} na loja {1}: R$", produtos[L], lojas[C]);
                precos[L, C] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Produtos com ate 120 R$");
        for (int i = 0; i < 8; i++){
            for (int j = 0; j < 4; j++){
                if (precos[i, j] <+ 120.00){
                   Console.WriteLine("Produto: {0}, Loja {1}, Preço: R$ {2} ", produtos,lojas,precos); 
                }
            }
        }

        Console.Write("\nPressione algo para sair . . . ");
        Console.ReadKey(true);
    }
}
