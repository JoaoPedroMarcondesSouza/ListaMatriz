using System;

class Program
{
    static void Main()
    {
        int N;

       
        Console.Write("Digite o tamanho da matriz (N): ");
        N = int.Parse(Console.ReadLine());

       
        int[,] matrizTesouro = new int[N, N];
        PreencherMatriz(matrizTesouro);

        
        Console.WriteLine("\nMapa do Tesouro (Quantidade de Moedas em Cada Região):");
        ExibirMatriz(matrizTesouro);

        
        int somaDiagonalPrincipal = CalcularSomaDiagonalPrincipal(matrizTesouro);
        int somaDiagonalSecundaria = CalcularSomaDiagonalSecundaria(matrizTesouro);

       
        Console.WriteLine($"\nSoma da Diagonal Principal: {somaDiagonalPrincipal}");
        Console.WriteLine($"Soma da Diagonal Secundária: {somaDiagonalSecundaria}");

       
        if (somaDiagonalPrincipal > somaDiagonalSecundaria)
        {
            Console.WriteLine("\nO maior tesouro está na diagonal principal, vamos para lá!");
        }
        else if (somaDiagonalSecundaria > somaDiagonalPrincipal)
        {
            Console.WriteLine("\nO maior tesouro está na diagonal secundária, vamos para lá!");
        }
        else
        {
            Console.WriteLine("\nAmbas as diagonais têm o mesmo número de moedas de ouro.");
        }
    }

    
    static void PreencherMatriz(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rand.Next(1, 101); 
            }
        }
    }

    
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    
    static int CalcularSomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i];  
        }
        return soma;
    }

    
    static int CalcularSomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        int N = matriz.GetLength(0);
        for (int i = 0; i < N; i++)
        {
            soma += matriz[i, N - 1 - i]; 
        }
        return soma;
    }
}
