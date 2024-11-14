using System;

class Program
{
    static void Main()
    {
        int R, C;

        
        Console.Write("Digite o número de regiões (R): ");
        R = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de cidades por região (C): ");
        C = int.Parse(Console.ReadLine());

        
        int[,] matrizTropas = new int[R, C];
        PreencherMatriz(matrizTropas);

        
        Console.WriteLine("\nMatriz das Tropas (Quantidade de Tropas por Cidade):");
        ExibirMatriz(matrizTropas);

       
        Console.WriteLine("\nForça Total das Regiões:");
        for (int i = 0; i < R; i++)
        {
            int somaRegiao = CalcularSomaRegiao(matrizTropas, i);
            Console.WriteLine($"Região {i + 1}: {somaRegiao} tropas");
        }
    }

    
    static void PreencherMatriz(int[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)  
        {
            for (int j = 0; j < matriz.GetLength(1); j++)  
            {
                matriz[i, j] = rand.Next(0, 101); 
            }
        }
    }

    
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write("Região " + (i + 1) + ": ");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

   
    static int CalcularSomaRegiao(int[,] matriz, int linha)
    {
        int soma = 0;
        for (int j = 0; j < matriz.GetLength(1); j++) 
        {
            soma += matriz[linha, j];
        }
        return soma;
    }
}
